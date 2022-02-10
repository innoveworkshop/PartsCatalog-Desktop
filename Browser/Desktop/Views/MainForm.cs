using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PartsCatalog.Models;
using PartsCatalog.DesktopForms.Views;
using System.Reflection;

namespace PartsCatalog.Browsers.Views {
	/// <summary>
	/// Main form of the application.
	/// </summary>
	public partial class MainForm : Form {
		private BindingList<Category> categories;
		private BindingList<SubCategory> subCategories;
		private BindingList<PartsCatalog.Models.Component> partsComponents;

		/// <summary>
		/// Initializes the form and its components.
		/// </summary>
		public MainForm() {
			categories = new BindingList<Category>();
			subCategories = new BindingList<SubCategory>();
			partsComponents = new BindingList<PartsCatalog.Models.Component>();
			InitializeComponent();

			// Setup the categories list data source.
			lstCategories.DataSource = categories;
			lstCategories.DisplayMember = "Name";
			lstCategories.ValueMember = "ID";

			// Setup the sub-categories list data source.
			lstSubCategories.DataSource = subCategories;
			lstSubCategories.DisplayMember = "Name";
			lstSubCategories.ValueMember = "ID";

			// Setup the components table data source.
			grdResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
			grdResults.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing;
			SetupGridDoubleBuffering(grdResults);
			grdResults.DataSource = partsComponents;
			SetupGridColumns();
		}

		/// <summary>
		/// Sets up all of the grid columns and their styles.
		/// </summary>
		private void SetupGridColumns() {
			// Quantity
			grdResults.Columns["Quantity"].DisplayIndex = 0;
			grdResults.Columns["Quantity"].Width = 45;
			grdResults.Columns["Quantity"].HeaderText = "Qnt";

			// Name
			grdResults.Columns["Name"].DisplayIndex = 1;
			grdResults.Columns["Name"].Width = 100;

			// Description
			grdResults.Columns["Description"].DisplayIndex = 2;
			grdResults.Columns["Description"].Width = 255;

			// Package
			grdResults.Columns["Package"].DisplayIndex = 3;
			grdResults.Columns["Package"].Width = 80;

			// Category
			grdResults.Columns["Category"].DisplayIndex = 4;
			grdResults.Columns["Category"].Width = 115;

			// Sub-Category
			grdResults.Columns["SubCategory"].DisplayIndex = 5;
			grdResults.Columns["SubCategory"].Width = 115;
			grdResults.Columns["SubCategory"].HeaderText = "Sub-Category";

			// Picture
			grdResults.Columns["Picture"].Visible = false;

			// Datasheet
			grdResults.Columns["Datasheet"].Visible = false;

			// ID
			grdResults.Columns["ID"].DisplayIndex = 8;
			grdResults.Columns["ID"].Width = 35;
		}

		/// <summary>
		/// Refreshes the categories list with new data.
		/// </summary>
		public void RefreshCategoriesList() {
			new Category().List(categories);

			// Select the first one just to show the user something.
			if (categories.Count > 0) {
				lstCategories.SelectedIndex = -1;
				lstCategories.SelectedIndex = 0;
			}
		}

		/// <summary>
		/// Populates the sub-categories list with data from a given category.
		/// </summary>
		/// <param name="category">Category to get sub-categories from.</param>
		public void PopulateSubCategoriesList(Category category) {
			// Start with a blank slate.
			subCategories.Clear();

			// Do nothing if the category is null.
			if (category == null)
				return;

			// Go through sub-categories filling the local object.
			foreach (SubCategory subCategory in category.SubCategories) {
				subCategories.Add(subCategory);
			}

			// Select the first one just to show the user something.
			if (subCategories.Count > 0) {
				lstSubCategories.SelectedIndex = -1;
				lstSubCategories.SelectedIndex = 0;
			}
		}

		/// <summary>
		/// Populates the components table view with data from a specific criteria.
		/// </summary>
		/// <param name="criteria">Object that will be used as criteria for fetching the
		/// components via the <see cref="PartsCatalog.Models.List<T>"/> call.</param>
		/// <param name="queryParam">URL parameter query name.</param>
		public void PopulateComponentsGrid<T>(RemoteObject<T> criteria, string queryParam)
				where T : RemoteObject<T>, new() {
			if (criteria == null)
				return;

			new PartsCatalog.Models.Component().List<T>(partsComponents, queryParam, criteria);
		}

		/// <summary>
		/// Enables double buffering to improve the performance in a <see cref="DataGridView"/>
		/// </summary>
		/// <param name="gridView">Grid view to have double buffering enabled.</param>
		private void SetupGridDoubleBuffering(DataGridView gridView) {
			// Make sure we are not running under Remote Desktop.
			if (!System.Windows.Forms.SystemInformation.TerminalServerSession) {
				Type dgvType = gridView.GetType();

				PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
					BindingFlags.Instance | BindingFlags.NonPublic);
				pi.SetValue(gridView, true, null);
			}
		}

		/******************
		 * Event Handlers *
		 ******************/

		private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
			Application.Exit();
		}

		private void MainForm_Load(object sender, EventArgs e) {
			tslServer.Text = PartsCatalog.Configuration.Domain;
			RefreshCategoriesList();
		}

		private void lstCategories_SelectedIndexChanged(object sender, EventArgs e) {
			PopulateSubCategoriesList((Category)lstCategories.SelectedItem);
		}

		private void lstSubCategories_SelectedIndexChanged(object sender, EventArgs e) {
			PopulateComponentsGrid<SubCategory>((SubCategory)lstSubCategories.SelectedItem,
				"subcategory");
		}

		private void grdResults_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) {
			ComponentForm form = new ComponentForm(
				(PartsCatalog.Models.Component)grdResults.CurrentRow.DataBoundItem);
			form.Show();
		}

		private void refreshToolStripMenuItem_Click(object sender, EventArgs e) {
			partsComponents.Clear();
			RefreshCategoriesList();
		}
	}
}