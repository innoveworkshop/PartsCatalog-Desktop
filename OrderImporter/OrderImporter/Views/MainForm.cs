using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PartsCatalog.Models;
using PartsCatalog.DesktopForms.Views;
using PartsCatalog.DesktopForms.Utilities;
using OrderImporter.Services;
using OrderImporter.Models;

namespace OrderImporter {
	/// <summary>
	/// Main form of the application.
	/// </summary>
	public partial class MainForm : Form {
		private CommonComponentControls commonComponentControls;
		private OrderItem _currentItem;
		private FarnellOrder order;

		/// <summary>
		/// Initializes the form and its components.
		/// </summary>
		public MainForm() {
			InitializeComponent();

			// Setup the common component controls.
			_currentItem = new GenericOrderItem();
			commonComponentControls = new CommonComponentControls(this,
				CurrentOrderItem, cmbCategory, cmbSubCategory, cmbPackage,
				grdProperties);

			// Create a test Farnell order and attach its items to a binding source.
			order = new FarnellOrder(
				@"\\MULBERRY\Master\Orders\Farnell\2021-06-09-ORDERLINEOrderDetail.csv");
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
			// TODO
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
			// TODO
		}

		/// <summary>
		/// Gets a component from the system based in an order item.
		/// </summary>
		/// <param name="item">Order item to get component with.</param>
		/// <returns>Component in case one was found, <c>null</c> otherwise.</returns>
		public PartsCatalog.Models.Component GetComponentFromItem(OrderItem item) {
			PartsCatalog.Models.Component component = new PartsCatalog.Models.Component();

			// TODO

			return component;
		}

		/// <summary>
		/// Updates the view when the current selected item has changed.
		/// </summary>
		private void CurrentItemChanged() {
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

			// Is this order item already in the system?
			tsbImport.Enabled = !CurrentOrderItem.IsPersistent();
			tsbViewComponent.Enabled = CurrentOrderItem.IsPersistent();

			// Populate common controls.
			commonComponentControls.PopulateWithComponent(false);
		}

		/// <summary>
		/// Currently displayed order item.
		/// </summary>
		public OrderItem CurrentOrderItem {
			get { return _currentItem; }
			set {
				_currentItem = value;
				commonComponentControls.AssociatedComponent = _currentItem;
				CurrentItemChanged();
			}
		}

		/******************
		 * Event Handlers *
		 ******************/

		private void bindingSource_CurrentChanged(object sender, EventArgs e) {
			CurrentOrderItem = (OrderItem)bindingSource.Current;
		}

		private void tsbImport_Click(object sender, EventArgs e) {
			ImportItem((OrderItem)bindingSource.Current);
		}

		private void tsbViewComponent_Click(object sender, EventArgs e) {
			ShowComponent((OrderItem)bindingSource.Current);
		}
	}
}