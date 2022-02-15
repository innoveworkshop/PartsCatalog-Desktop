using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PartsCatalog.Models;
using PartsCatalog.DesktopForms.Views;
using PartsCatalog.DesktopForms.Dialogs;
using PartsCatalog.DesktopForms.Utilities;
using OrderImporter.Services;
using OrderImporter.Models;

namespace OrderImporter.Views {
	/// <summary>
	/// Main form of the application.
	/// </summary>
	public partial class MainForm : Form {
		private CommonComponentControls commonComponentControls;
		private WebLoadingDialog dlgLoading;

		/// <summary>
		/// Initializes an empty form and its components.
		/// </summary>
		public MainForm() {
			InitializeComponent();

			// Setup the common component controls.
			commonComponentControls = new CommonComponentControls(this,
				new PartsCatalog.Models.Component(), cmbCategory, cmbSubCategory,
				cmbPackage, grdProperties);
		}

		/// <summary>
		/// Sets the order to be imported by the form.
		/// </summary>
		/// <typeparam name="T">Type of order item that will be used in the
		/// distributor's order object.</typeparam>
		/// <param name="order">Order to be imported.</param>
		public void SetOrder<T>(DistributorOrder<T> order) where T : OrderItem {
			// Attach the order items to the navigation binding source.
			navBinding.BindingSource.DataSource = order.Items;
		}

		/// <summary>
		/// Imports an item into the system.
		/// </summary>
		/// <param name="item">Order item to be imported.</param>
		public void ImportItem(OrderItem item) {
			ImportItem(item, true);
		}

		/// <summary>
		/// Imports an item into the system.
		/// </summary>
		/// <param name="item">Order item to be imported.</param>
		/// <param name="checkIfExists">Check if this is a duplicate and ask the
		/// user they want to just update the quantity.</param>
		public void ImportItem(OrderItem item, bool checkIfExists) {
			// If the order is already in the database or we don't need to check
			// for duplicates then just save it already.
			if (item.IsValid() || !checkIfExists) {
				item.Save();
				return;
			}

			// Check with the user if they want to merge.
			if (!CheckDatabaseAndMerge(item, false)) {
				// User didn't merge.
				MessageBox.Show(this, "No component was imported into the database.",
					"No operation was performed", MessageBoxButtons.OK,
					MessageBoxIcon.Warning);
				return;
			}

			// If nothing was merged let's save the new item then.
			if (!item.IsValid()) {
				item.Save();

				// Save the component properties.
				foreach (Property property in item.Properties)
					property.Save();

				// Download the datasheet if needed.
				if (txtDatasheetURL.Text.Length > 0) {
					CurrentOrderItem.Datasheet.AssociatedComponent = CurrentOrderItem;
					CurrentOrderItem.Datasheet.UploadFromURL(txtDatasheetURL.Text);
				}

				// Update the view.
				UpdateItemView();
			}
		}

		/// <summary>
		/// Checks the database if there's a match with the order item and asks
		/// the user if they want to merge the components.
		/// </summary>
		/// <param name="item">Order item to check for.</param>
		/// <param name="showNotFoundDialog">Show a 'no matching component found'
		/// type of dialog?</param>
		/// <returns><c>true</c> if the user has merged the components or if there's
		/// no match in the database. Otherwise <c>false</c> will be returned.</returns>
		public bool CheckDatabaseAndMerge(OrderItem item, bool showNotFoundDialog) {
			// The item has already been merged. No need to do anything.
			if (item.IsValid())
				return true;

			// Let's check if we have something in the database that might match this.
			PartsCatalog.Models.Component component = GetComponentFromItem(item);
			if (component == null) {
				// Show a nice dialog?
				if (showNotFoundDialog) {
					MessageBox.Show(this, "No suitable matching component was found " +
						"in the database to merge with this order item.",
						"No matching component found", MessageBoxButtons.OK,
						MessageBoxIcon.Information);
				}

				return true;
			}

			// Ask the user about what we should do.
			DialogResult dialog = MessageBox.Show(this, "There's already a '" + item.Name +
				"' component in the database. Do you with to just update its quantity?",
				"Merge with component already in the database?", MessageBoxButtons.YesNo,
				MessageBoxIcon.Question);

			// Ignore if the user was mistaken.
			if (dialog == DialogResult.No)
				return false;

			// Merge the components and update the view.
			MergeOrderWithComponent(item, component);
			UpdateItemView();

			return true;
		}

		/// <summary>
		/// Shows a persistent component in its own component window.
		/// </summary>
		/// <param name="item">Component to be shown.</param>
		public void ShowComponent(OrderItem item) {
			// Check if the component is actually persistent.
			if (!item.IsPersistent())
				throw new Exception("Can't show a component that's not persistent.");

			// Show the actual component form.
			ComponentForm form = new ComponentForm(item);
			form.Show();
		}

		/// <summary>
		/// Checks if an order item is already a component in the system.
		/// </summary>
		/// <param name="item">Order item to be tested for duplicates.</param>
		/// <returns>True if the item is already in the system.</returns>
		public bool IsDuplicate(OrderItem item) {
			return GetComponentFromItem(item) != null;
		}

		/// <summary>
		/// Updates the quantity of a component in the system based on an order item.
		/// This function will overwrite the order item with the updated contents of
		/// the component in the system.
		/// </summary>
		/// <param name="item">Order item to merge with component.</param>
		/// <param name="component">Component to be updated.</param>
		private void MergeOrderWithComponent(OrderItem item,
				PartsCatalog.Models.Component component) {
			int quantity = item.Quantity;

			// Combine the two components.
			item.ID = component.ID;
			item.Retrieve();

			// Change the quantity and save.
			item.Quantity += quantity;
			item.Save();
		}

		/// <summary>
		/// Gets a component from the system based in an order item.
		/// </summary>
		/// <param name="item">Order item to get component with.</param>
		/// <returns>Component in case one was found, <c>null</c> otherwise.</returns>
		public PartsCatalog.Models.Component GetComponentFromItem(OrderItem item) {
			try {
				// Get a component using its name.
				PartsCatalog.Models.Component component =
					new PartsCatalog.Models.Component(item.Name);
				component.Retrieve();

				return component;
			} catch {
				return null;
			}
		}

		/// <summary>
		/// Updates the view when the current selected item has changed.
		/// </summary>
		private void UpdateItemView() {
			// Quantity field.
			updQuantity.DataBindings.Clear();
			updQuantity.DataBindings.Add("Value", CurrentOrderItem, "Quantity",
				true, DataSourceUpdateMode.OnPropertyChanged);

			// Name field.
			txtName.DataBindings.Clear();
			txtName.DataBindings.Add("Text", CurrentOrderItem, "Name", true,
				DataSourceUpdateMode.OnPropertyChanged);

			// Description field.
			txtDescription.DataBindings.Clear();
			txtDescription.DataBindings.Add("Text", CurrentOrderItem, "Description",
				true, DataSourceUpdateMode.OnPropertyChanged);

			// Populate common controls.
			commonComponentControls.PopulateWithComponent(false);

			// Is this order item already in the system?
			tsbImport.Enabled = !CurrentOrderItem.IsPersistent();
			tsbViewComponent.Enabled = CurrentOrderItem.IsPersistent();
			tsbCheckDatabase.Enabled = !CurrentOrderItem.IsPersistent();
			tsbRefresh.Enabled = !CurrentOrderItem.IsPersistent();
			panFields.Enabled = !CurrentOrderItem.IsPersistent();
			panProperties.Enabled = !CurrentOrderItem.IsPersistent();
			grdProperties.Enabled = !CurrentOrderItem.IsPersistent();
			foreach (Control ctrl in panFields.Controls) {
				ctrl.Enabled = !CurrentOrderItem.IsPersistent();
			}
		}

		/// <summary>
		/// Populates the form with the currently selected component.
		/// </summary>
		private void PopulateComponent() {
			dlgLoading = new WebLoadingDialog();
			dlgLoading.ShowFetching(this, "component '" + CurrentOrderItem.Name + "'");

			commonComponentControls.AssociatedComponent = CurrentOrderItem;
			UpdateItemView();

			dlgLoading.Close();
		}

		/// <summary>
		/// Currently displayed order item.
		/// </summary>
		public OrderItem CurrentOrderItem {
			get { return (OrderItem)bindingSource.Current; }
		}

		/******************
		 * Event Handlers *
		 ******************/

		private void MainForm_Load(object sender, EventArgs e) {
			tslServer.Text = PartsCatalog.Configuration.Domain;
		}

		private void bindingSource_CurrentChanged(object sender, EventArgs e) {
			PopulateComponent();
		}

		private void tsbImport_Click(object sender, EventArgs e) {
			ImportItem(CurrentOrderItem);
		}

		private void tsbViewComponent_Click(object sender, EventArgs e) {
			ShowComponent(CurrentOrderItem);
		}

		private void tsbDistributorWebsite_Click(object sender, EventArgs e) {
			CurrentOrderItem.OpenComponentPage();
		}

		private void tsbCheckDatabase_Click(object sender, EventArgs e) {
			CheckDatabaseAndMerge(CurrentOrderItem, true);
		}

		private void tsbRefresh_Click(object sender, EventArgs e) {
			commonComponentControls.PopulateWithComponent(true);
		}
	}
}