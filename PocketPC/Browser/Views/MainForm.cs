using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PartsCatalog.Models;

namespace Browser.Views {
	public partial class MainForm : Form {
		private BindingList<Category> categories;
		private BindingList<SubCategory> subCategories;
		private BindingList<PartsCatalog.Models.Component> partsComponents;

		public MainForm() {
			categories = new BindingList<Category>();
			subCategories = new BindingList<SubCategory>();
			partsComponents = new BindingList<PartsCatalog.Models.Component>();
			InitializeComponent();

			// Setup the categories list data source.
			cmbCategories.DataSource = categories;
			cmbCategories.DisplayMember = "Name";
			cmbCategories.ValueMember = "ID";

			// Setup the sub-categories list data source.
			cmbSubCategories.DataSource = subCategories;
			cmbSubCategories.DisplayMember = "Name";
			cmbSubCategories.ValueMember = "ID";

			// Setup the components table data source.
			grdResults.DataSource = partsComponents;
		}

		/// <summary>
		/// Refreshes the categories list with new data.
		/// </summary>
		public void RefreshCategoriesList() {
			new Category().List(categories);
		}

		/// <summary>
		/// Populates the sub-categories list with data from a given category.
		/// </summary>
		/// <param name="category">Category to get sub-categories from.</param>
		public void PopulateSubCategoriesList(Category category) {
			// Was the category even valid?
			if (category == null)
				return;

			// Start with a blank slate.
			subCategories.Clear();

			// Go through sub-categories filling the local object.
			foreach (SubCategory subCategory in category.SubCategories) {
				subCategories.Add(subCategory);
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

		/******************
		 * Event Handlers *
		 ******************/

		private void MainForm_Load(object sender, EventArgs e) {
			Text += " (" + PartsCatalog.Configuration.Domain + ")";
			RefreshCategoriesList();
		}

		private void cmbCategories_SelectedValueChanged(object sender, EventArgs e) {
			PopulateSubCategoriesList((Category)cmbCategories.SelectedItem);
			//PopulateComponentsGrid<Category>((Category)lstCategories.SelectedItem,
			//	"category");
		}

		private void cmbSubCategories_SelectedValueChanged(object sender, EventArgs e) {
			PopulateComponentsGrid<SubCategory>((SubCategory)cmbSubCategories.SelectedItem,
				"subcategory");
		}

		private void grdResults_DoubleClick(object sender, EventArgs e) {

		}
	}
}