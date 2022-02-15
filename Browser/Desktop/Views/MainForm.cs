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

namespace PartsCatalog.Browsers.Views {
	/// <summary>
	/// Main form of the application.
	/// </summary>
	public partial class MainForm : Form {
		private BindingList<Category> categories;
		private BindingList<SubCategory> subCategories;
		private ComponentGridHelper gridHelper;

		/// <summary>
		/// Initializes the form and its components.
		/// </summary>
		public MainForm() {
			categories = new BindingList<Category>();
			subCategories = new BindingList<SubCategory>();
			InitializeComponent();

			// Setup the categories list data source.
			lstCategories.DataSource = categories;
			lstCategories.DisplayMember = "Name";
			lstCategories.ValueMember = "ID";

			// Setup the sub-categories list data source.
			lstSubCategories.DataSource = subCategories;
			lstSubCategories.DisplayMember = "Name";
			lstSubCategories.ValueMember = "ID";

			// Setup the components table.
			gridHelper = new ComponentGridHelper(grdResults);
			gridHelper.SetupDefaultDoubleClickEvent();
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
			gridHelper.PopulateWithCriteria<SubCategory>((SubCategory)lstSubCategories.SelectedItem,
				"subcategory");
		}

		private void refreshToolStripMenuItem_Click(object sender, EventArgs e) {
			gridHelper.Clear();
			RefreshCategoriesList();
		}

		private void searchToolStripMenuItem_Click(object sender, EventArgs e) {
			new ComponentSearchForm().Show(this);
		}

		private void categoriesToolStripMenuItem_Click(object sender, EventArgs e) {
			new CategoryManager.MainForm().ShowDialog(this);
		}

		private void packagesToolStripMenuItem_Click(object sender, EventArgs e) {
			new PackageManager.MainForm().ShowDialog(this);
		}

		private void projectsToolStripMenuItem_Click(object sender, EventArgs e) {
			new ProjectManager.MainForm().ShowDialog(this);
		}

		private void importOrderToolStripMenuItem_Click(object sender, EventArgs e) {
			new OrderImporter.Views.OrderPickerForm().Show(this);
		}
	}
}