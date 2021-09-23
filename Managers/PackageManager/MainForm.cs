using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PartsCatalog.Models;

namespace PackageManager {
	/// <summary>
	/// Application to manage component packages in the system.
	/// </summary>
	public partial class MainForm : Form {
		private BindingList<Package> packages;

		/// <summary>
		/// Initializes the form an its controls.
		/// </summary>
		public MainForm() {
			InitializeComponent();
			packages = new BindingList<Package>();

			// Setup data binding for the list.
			lstPackages.DataSource = packages;
			lstPackages.DisplayMember = "Name";
			lstPackages.ValueMember = "ID";

			// Start from a blank slate.
			PopulateDetails(null);
		}

		/// <summary>
		/// Populates the packages list with data from the database.
		/// </summary>
		/// <param name="selected">Select this package after populating.</param>
		public void PopulatePackagesList(Package selected) {
			packages.Clear();
			new Package().List(packages);

			// Select a package if supplied.
			if (selected != null)
				lstPackages.SelectedValue = selected.ID;
		}

		/// <summary>
		/// Populates the packages list with data from the database.
		/// </summary>
		public void PopulatePackagesList() {
			PopulatePackagesList(null);
		}

		/// <summary>
		/// Populates the package form with data from the specified object.
		/// </summary>
		/// <param name="package">Package that will be edited.</param>
		public void PopulateDetails(Package package) {
			// Reset the control bindings.
			lblID.DataBindings.Clear();
			txtName.DataBindings.Clear();

			// Check if we are deselecting a package.
			if (package == null) {
				// Disable the controls that are not useful.
				btnRename.Enabled = false;
				btnRemove.Enabled = false;
				txtName.Text = "";
				lblID.Text = "";

				return;
			}

			// Bind data to fields.
			lblID.DataBindings.Add("Text", package, "ID", true,
				DataSourceUpdateMode.OnPropertyChanged);
			txtName.DataBindings.Add("Text", package, "Name", true,
				DataSourceUpdateMode.OnPropertyChanged);

			// Enable the controls that are now useful.
			btnRename.Enabled = true;
			btnRemove.Enabled = true;
		}

		/// <summary>
		/// Adds a new package to the database.
		/// </summary>
		public void AddPackage() {
			Package package = new Package();
			package.Name = txtName.Text;
			package.Save();

			// Append the new package to the list.
			if (package.IsPersistent()) {
				packages.Add(package);
				PopulateDetails(package);
				PopulatePackagesList(package);
			}
		}

		/// <summary>
		/// Renames the package in the database.
		/// </summary>
		/// <param name="package">Package that will be renamed.</param>
		public void RenamePackage(Package package) {
			package.Save();
			PopulatePackagesList(package);
		}

		/// <summary>
		/// Removes a package from the database.
		/// </summary>
		/// <param name="package">Package that will be deleted.</param>
		public void DeletePackage(Package package) {
			DialogResult dialog = MessageBox.Show("Are you sure you want to delete " +
				"the package '" + package.Name + "'?", "Delete package?",
				MessageBoxButtons.YesNo);

			// Ignore if the user was mistaken.
			if (dialog == DialogResult.No)
				return;

			package.Delete();
			PopulateDetails(null);
			PopulatePackagesList();
		}

		/******************
		 * Event Handlers *
		 ******************/

		private void MainForm_Load(object sender, EventArgs e) {
			PopulatePackagesList();
		}

		private void lstPackages_SelectedIndexChanged(object sender, EventArgs e) {
			Package package = (Package)lstPackages.SelectedItem;
			if (package == null)
				return;

			PopulateDetails(package);
		}

		private void btnAdd_Click(object sender, EventArgs e) {
			AddPackage();
		}

		private void btnRename_Click(object sender, EventArgs e) {
			Package package = (Package)lstPackages.SelectedItem;
			if (package == null)
				return;

			RenamePackage(package);
		}

		private void btnRemove_Click(object sender, EventArgs e) {
			Package package = (Package)lstPackages.SelectedItem;
			if (package == null)
				return;

			DeletePackage(package);
		}
	}
}