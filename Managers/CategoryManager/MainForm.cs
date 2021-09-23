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
		/// <param name="selected">Select this category after populating.</param>
		public void PopulateCategoriesList(Category selected) {
			categories.Clear();
			new Category().List(categories);
			PopulateSubCategoriesList(null);

			// Select a category if supplied.
			if (selected != null)
				lstCategories.SelectedValue = selected.ID;
		}

		/// <summary>
		/// Populates the categories list with data from the database.
		/// </summary>
		public void PopulateCategoriesList() {
			PopulateCategoriesList(null);
		}

		/// <summary>
		/// Populates the sub-categories list with data from the database.
		/// </summary>
		/// <param name="parent">Parent category.</param>
		/// <param name="selected">Select this sub-category after populating.</param>
		public void PopulateSubCategoriesList(Category parent, SubCategory selected) {
			// Populate the sub-categories list.
			subCategories.Clear();
			if (parent != null) {
				foreach (SubCategory subCategory in parent.SubCategories) {
					subCategories.Add(subCategory);
				}
			}

			// Populates the category editor.
			PopulateCategoryGroup(parent);

			// Select the sub-category if supplied.
			if (selected != null)
				lstSubCategories.SelectedValue = selected.ID;
		}

		/// <summary>
		/// Populates the sub-categories list with data from the database.
		/// </summary>
		/// <param name="parent">Parent category.</param>
		public void PopulateSubCategoriesList(Category parent) {
			PopulateSubCategoriesList(parent, null);
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
			btnSubCategoryAdd.Enabled = true;
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
				btnSubCategoryAdd.Enabled = false;
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
			btnSubCategoryAdd.Enabled = true;
		}

		/// <summary>
		/// Adds a new category to the database.
		/// </summary>
		public void AddCategory() {
			Category category = new Category();
			category.Name = txtCategory.Text;
			category.Save();

			// Append the new category to the list.
			if (category.IsPersistent()) {
				categories.Add(category);
				PopulateCategoryGroup(category);
				PopulateCategoriesList(category);
			}
		}

		/// <summary>
		/// Adds a new sub-category to the database.
		/// </summary>
		/// <param name="parent">New sub-category's parent category.</param>
		public void AddSubCategory(Category parent) {
			SubCategory subCategory = new SubCategory();
			subCategory.Name = txtSubCategory.Text;
			subCategory.Parent = parent;
			subCategory.Save();

			// Append the new sub-category to the lists.
			if (subCategory.IsPersistent()) {
				parent.SubCategories.Add(subCategory);
				subCategories.Add(subCategory);
				PopulateSubCategoryGroup(subCategory);
				PopulateSubCategoriesList(parent, subCategory);
			}
		}

		/// <summary>
		/// Renames the category in the database.
		/// </summary>
		/// <param name="category">Category that will be renamed.</param>
		public void RenameCategory(Category category) {
			category.Save();
			PopulateCategoriesList(category);
		}

		/// <summary>
		/// Renames the sub-category in the database.
		/// </summary>
		/// <param name="subCategory">Sub-category that will be renamed.</param>
		public void RenameSubCategory(SubCategory subCategory) {
			subCategory.Save();
			PopulateSubCategoriesList(subCategory.Parent, subCategory);
		}

		/// <summary>
		/// Removes a category from the database.
		/// </summary>
		/// <param name="category">Category that will be deleted.</param>
		public void DeleteCategory(Category category) {
			DialogResult dialog = MessageBox.Show("Are you sure you want to delete " +
				"the category '" + category.Name + "' and all of its sub-categories?",
				"Delete category?", MessageBoxButtons.YesNo);

			// Ignore if the user was mistaken.
			if (dialog == DialogResult.No)
				return;

			category.Delete();
			PopulateCategoryGroup(null);
			PopulateCategoriesList();
		}

		/// <summary>
		/// Removes a sub-category from the database.
		/// </summary>
		/// <param name="subCategory">Sub-category that will be deleted.</param>
		public void DeleteSubCategory(SubCategory subCategory) {
			DialogResult dialog = MessageBox.Show("Are you sure you want to delete " +
				"the sub-category '" + subCategory.Name + "'?", "Delete sub-category?",
				MessageBoxButtons.YesNo);

			// Ignore if the user was mistaken.
			if (dialog == DialogResult.No)
				return;

			Category parent = subCategory.Parent;
			subCategory.Delete();
			PopulateCategoryGroup(parent);
			PopulateCategoriesList(parent);
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

		private void btnCategoryAdd_Click(object sender, EventArgs e) {
			AddCategory();
		}

		private void btnCategoryRename_Click(object sender, EventArgs e) {
			Category category = (Category)lstCategories.SelectedItem;
			if (category == null)
				return;

			RenameCategory(category);
		}

		private void btnCategoryRemove_Click(object sender, EventArgs e) {
			Category category = (Category)lstCategories.SelectedItem;
			if (category == null)
				return;

			DeleteCategory(category);
		}

		private void btnSubCategoryAdd_Click(object sender, EventArgs e) {
			Category category = (Category)lstCategories.SelectedItem;
			if (category == null)
				return;

			AddSubCategory(category);
		}

		private void btnSubCategoryRename_Click(object sender, EventArgs e) {
			SubCategory subCategory = (SubCategory)lstSubCategories.SelectedItem;
			if (subCategory == null)
				return;

			RenameSubCategory(subCategory);
		}

		private void btnSubCategoryRemove_Click(object sender, EventArgs e) {
			SubCategory subCategory = (SubCategory)lstSubCategories.SelectedItem;
			if (subCategory == null)
				return;

			DeleteSubCategory(subCategory);
		}
	}
}