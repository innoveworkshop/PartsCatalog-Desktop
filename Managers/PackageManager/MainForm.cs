using System;
using System.IO;
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

			// Allow drag and drop of an image.
			picImage.AllowDrop = true;

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

			// Populate the image.
			PopulateImage(package, true);

			// Enable the controls that are now useful.
			btnRename.Enabled = true;
			btnRemove.Enabled = true;
		}

		/// <summary>
		/// Populates the package image control.
		/// </summary>
		/// <param name="package">Currently selected package.</param>
		/// <param name="retrieve">Should we retrieve the image object?</param>
		public void PopulateImage(Package package, bool retrieve) {
			// Clear the image if there's already one in place.
			if (picImage.Image != null) {
				picImage.Image.Dispose();
				picImage.Image = null;

				ctmImage.Enabled = false;
				imageToolStripMenuItem.Enabled = false;
			}

			// Retrieve the image object.
			if (retrieve)
				package.Retrieve();

			// Associate the image.
			if (package.Picture.HasImage()) {
				MemoryStream ms = new MemoryStream();

				ms.Write(package.Picture.FileContent, 0,
					Convert.ToInt32(package.Picture.FileContent.Length));
				picImage.Image = System.Drawing.Image.FromStream(ms);
				
				ms.Dispose();
			}
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

		/// <summary>
		/// Sets the package image and uploads it to the server.
		/// </summary>
		/// <param name="package">Package that will have its image updated.</param>
		/// <param name="filePath">Image file to be uploaded.</param>
		public void SetImage(Package package, string filePath) {
			// Set the component image and upload the file.
			package.Picture.AssociatedPackage = new Package(package.ID);
			package.Picture.FileContent = File.ReadAllBytes(filePath);
			package.Picture.Save();

			// Show the new image.
			PopulateImage(package, false);
		}

		/// <summary>
		/// Browses and selects a package image and uploads it to the server.
		/// </summary>
		/// <param name="package">Package that will have its image updated.</param>
		public void SelectImage(Package package) {
			// Browse for a new package image.
			if (dlgOpenImage.ShowDialog() != DialogResult.OK)
				return;

			// Set the component image and upload the file.
			SetImage(package, dlgOpenImage.FileName);
		}

		/// <summary>
		/// Deletes the package image from the form and the server.
		/// </summary>
		/// <param name="package">Package that will have its image deleted.</param>
		public void DeleteImage(Package package) {
			DialogResult dialog = MessageBox.Show("Are you sure you want to delete " +
				"this package's image?", "Delete package image?",
				MessageBoxButtons.YesNo);

			// Ignore if the user was mistaken.
			if (dialog == DialogResult.No)
				return;

			// Actually delete the image.
			package.Picture.Delete();
			if (picImage.Image != null) {
				picImage.Image.Dispose();
				picImage.Image = null;
			}
		}

		/******************
		 * Event Handlers *
		 ******************/

		private void MainForm_Load(object sender, EventArgs e) {
			tslServer.Text = PartsCatalog.Configuration.Domain;
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

		private void browseImageToolStripMenuItem_Click(object sender, EventArgs e) {
			Package package = (Package)lstPackages.SelectedItem;
			if (package == null)
				return;

			SelectImage(package);
		}

		private void deleteImageToolStripMenuItem_Click(object sender, EventArgs e) {
			Package package = (Package)lstPackages.SelectedItem;
			if (package == null)
				return;

			DeleteImage(package);
		}

		private void contextBrowseImageToolStripMenuItem_Click(object sender, EventArgs e) {
			Package package = (Package)lstPackages.SelectedItem;
			if (package == null)
				return;

			SelectImage(package);
		}

		private void contextDeleteImageToolStripMenuItem_Click(object sender, EventArgs e) {
			Package package = (Package)lstPackages.SelectedItem;
			if (package == null)
				return;

			DeleteImage(package);
		}

		private void picImage_DragEnter(object sender, DragEventArgs e) {
			// Display a nice copy effect if we actually have a file being dropped.
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
				e.Effect = DragDropEffects.Copy;
		}

		private void picImage_DragDrop(object sender, DragEventArgs e) {
			Package package = (Package)lstPackages.SelectedItem;
			if (package == null)
				return;

			// Get the file and check if we only have a single one.
			string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
			if (files.Length > 1)
				throw new Exception("Only a single file should be dragged and dropped");

			// Associate the new image.
			SetImage(package, files[0]);
		}
	}
}