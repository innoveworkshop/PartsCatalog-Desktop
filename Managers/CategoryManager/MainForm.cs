using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PartsCatalog.Models;

namespace CategoryManager {
	/// <summary>
	/// Application to manage the categories and the sub-categories in the system.
	/// </summary>
	public partial class MainForm : Form {
		private BindingList<Category> categories;
		private BindingList<SubCategory> subCategories;

		/// <summary>
		/// Initializes the form and its components.
		/// </summary>
		public MainForm() {
			InitializeComponent();
			categories = new BindingList<Category>();
			subCategories = new BindingList<SubCategory>();

			// Setup data bindings for the lists.
			lstCategories.DataSource = categories;
			lstCategories.DisplayMember = "Name";
			lstCategories.ValueMember = "ID";
			lstSubCategories.DataSource = subCategories;
			lstSubCategories.DisplayMember = "Name";
			lstSubCategories.ValueMember = "ID";

			// Start from a blank slate.
			PopulateCategoryGroup(null);
		}

		/// <summary>
		/// Populates the categories list with data from the database.
		/// </summary>
		public void PopulateCategoriesList() {
			categories.Clear();
			new Category().List(categories);
		}

		/// <summary>
		/// Populates the sub-categories list with data from the database.
		/// </summary>
		/// <param name="parent">Parent category.</param>
		public void PopulateSubCategoriesList(Category parent) {
			// Populate the sub-categories list.
			subCategories.Clear();
			foreach (SubCategory subCategory in parent.SubCategories) {
				subCategories.Add(subCategory);
			}

			// Populates the category editor.
			PopulateCategoryGroup(parent);
		}

		/// <summary>
		/// Populates the category form with data from the specified object.
		/// </summary>
		/// <param name="category">Category that will be edited.</param>
		public void PopulateCategoryGroup(Category category) {
			// Reset the control bindings.
			lblCategoryID.DataBindings.Clear();
			txtCategory.DataBindings.Clear();
			PopulateSubCategoryGroup(null);

			// Check if we are deselecting a category.
			if (category == null) {
				// Disable the controls that are now useful.
				btnCategoryRename.Enabled = false;
				btnCategoryRemove.Enabled = false;
				txtCategory.Text = "";
				lblCategoryID.Text = "";

				return;
			}

			// Bind data to fields.
			lblCategoryID.DataBindings.Add("Text", category, "ID", true,
				DataSourceUpdateMode.OnPropertyChanged);
			txtCategory.DataBindings.Add("Text", category, "Name", true,
				DataSourceUpdateMode.OnPropertyChanged);

			// Enable the controls that are now useful.
			btnCategoryRename.Enabled = true;
			btnCategoryRemove.Enabled = true;
		}

		/// <summary>
		/// Populates the sub-category form with data from the specified object.
		/// </summary>
		/// <param name="subCategory">Sub-category that will be edited.</param>
		public void PopulateSubCategoryGroup(SubCategory subCategory) {
			// Reset the control bindings.
			lblSubCategoryID.DataBindings.Clear();
			txtSubCategory.DataBindings.Clear();

			// Check if we are deselecting a sub-category.
			if (subCategory == null) {
				// Disable the controls that are now useful.
				btnSubCategoryRename.Enabled = false;
				btnSubCategoryRemove.Enabled = false;
				txtSubCategory.Text = "";
				lblSubCategoryID.Text = "";

				return;
			}

			// Bind data to fields.
			lblSubCategoryID.DataBindings.Add("Text", subCategory, "ID", true,
				DataSourceUpdateMode.OnPropertyChanged);
			txtSubCategory.DataBindings.Add("Text", subCategory, "Name", true,
				DataSourceUpdateMode.OnPropertyChanged);

			// Enable the controls that are now useful.
			btnSubCategoryRename.Enabled = true;
			btnSubCategoryRemove.Enabled = true;
		}

		/******************
		 * Event Handlers *
		 ******************/

		private void MainForm_Load(object sender, EventArgs e) {
			PopulateCategoriesList();
		}

		private void lstCategories_SelectedIndexChanged(object sender, EventArgs e) {
			Category category = (Category)lstCategories.SelectedItem;
			if (category == null)
				return;

			PopulateSubCategoriesList(category);
		}

		private void lstSubCategories_SelectedIndexChanged(object sender, EventArgs e) {
			SubCategory subCategory = (SubCategory)lstSubCategories.SelectedItem;
			if (subCategory == null)
				return;

			PopulateSubCategoryGroup(subCategory);
		}
	}
}