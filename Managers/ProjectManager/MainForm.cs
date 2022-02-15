using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PartsCatalog.Models;
using PartsCatalog.DesktopForms.Views;

namespace ProjectManager {
	/// <summary>
	/// Application to manage projects in the system.
	/// </summary>
	public partial class MainForm : Form {
		private BindingList<Project> projects;
		private BindingList<BOMItem> bomItems;
		private BindingList<string> refDesignators;

		/// <summary>
		/// Initializes the form and its controls.
		/// </summary>
		public MainForm() {
			InitializeComponent();
			projects = new BindingList<Project>();
			bomItems = new BindingList<BOMItem>();
			refDesignators = new BindingList<string>();

			// Setup data binding for the lists.
			lstProjects.DataSource = projects;
			lstProjects.ValueMember = "ID";
			lstProjects.DisplayMember = "";
			lstBOMItems.DataSource = bomItems;
			lstBOMItems.DisplayMember = "RefDesString";
			lstBOMItems.ValueMember = "ID";
			lstRefDes.DataSource = refDesignators;
		}

		/// <summary>
		/// Populates the projects list with data from the database.
		/// </summary>
		/// <param name="selected">Select this project after populating.</param>
		public void PopulateProjectsList(Project selected) {
			projects.Clear();
			new Project().List(projects);
			PopulateProjectGroup(null, false);

			// Select the first item just in case.
			lstProjects.SelectedIndex = -1;
			if (selected == null) {
				if (projects.Count > 0)
					lstProjects.SelectedIndex = 0;

				return;
			}

			// Select the supplied project.
			lstProjects.SelectedValue = selected.ID;
		}

		/// <summary>
		/// Populates the projecs list with data from the database.
		/// </summary>
		public void PopulateProjectsList() {
			PopulateProjectsList(null);
		}

		/// <summary>
		/// Populates the project control group with data from the specified object.
		/// </summary>
		/// <param name="project">Project that will be edited.</param>
		/// <param name="retrieveProject">Force retrieve the project object?</param>
		public void PopulateProjectGroup(Project project, bool retrieveProject) {
			// Reset the control bindings.
			lblProjectID.DataBindings.Clear();
			txtProjectName.DataBindings.Clear();
			txtProjectRevision.DataBindings.Clear();
			txtProjectDescription.DataBindings.Clear();

			// Check if we are deselecting a project.
			if (project == null) {
				// Disable the controls that are not useful.
				btnProjectSave.Enabled = false;
				btnProjectRemove.Enabled = false;
				projectToolStripMenuItem.Enabled = false;

				// Reset some fields.
				lblProjectID.Text = "";
				txtProjectName.Text = "";
				txtProjectRevision.Text = "";
				txtProjectDescription.Text = "";

				PopulateProjectBOMList(null, null, false);
				return;
			}

			// Should we retrieve the project object again?
			if (retrieveProject)
				project.Retrieve();

			// Bind data to fields.
			lblProjectID.DataBindings.Add("Text", project, "ID", true,
				DataSourceUpdateMode.OnPropertyChanged);
			txtProjectName.DataBindings.Add("Text", project, "Name", true,
				DataSourceUpdateMode.OnPropertyChanged);
			txtProjectRevision.DataBindings.Add("Text", project, "Revision", true,
				DataSourceUpdateMode.OnPropertyChanged);
			txtProjectDescription.DataBindings.Add("Text", project, "Description",
				true, DataSourceUpdateMode.OnPropertyChanged);

			// Enable the controls that are now useful.
			btnProjectSave.Enabled = true;
			btnProjectRemove.Enabled = true;
			projectToolStripMenuItem.Enabled = true;

			// Populate the BOM list.
			PopulateProjectBOMList(project, null, retrieveProject);
		}

		/// <summary>
		/// Populates the BOM items list for a given project.
		/// </summary>
		/// <param name="project">Project that will be used to get a BOM from.</param>
		/// <param name="selected">Pre-selected BOM item.</param>
		/// <param name="retrieveProject">Force retrieve the project object?</param>
		public void PopulateProjectBOMList(Project project, BOMItem selected,
										   bool retrieveProject) {
			bomItems.Clear();
			PopulateBOMItemGroup(null);

			// Check if we are deselecting a project.
			if (project == null) {
				// Disable the controls that are not useful.
				btnItemAdd.Enabled = false;
				btnItemRemove.Enabled = false;
				btnItemSave.Enabled = false;
				bOMItemToolStripMenuItem.Enabled = false;

				return;
			}

			// Should we retrieve the project object again?
			if (retrieveProject)
				project.Retrieve();

			// Go through the BOM populating the list.
			foreach (BOMItem item in project.BOM) {
				bomItems.Add(item);
			}

			// Select the BOM item if needed.
			lstBOMItems.SelectedIndex = -1;
			if (selected != null) {
				// Select the item that we were asked to select.
				for (int i = 0; i < bomItems.Count; i++) {
					if (bomItems[0].ID == selected.ID) {
						lstBOMItems.SelectedIndex = i;
						break;
					}
				}
			} else {
				// Looks like we've just loaded in the list, so just select the first item.
				if (lstBOMItems.Items.Count > 0)
					lstBOMItems.SelectedIndex = 0;
			}

			// Enable the controls that are now useful.
			btnItemAdd.Enabled = true;
			bOMItemToolStripMenuItem.Enabled = true;
		}

		/// <summary>
		/// Populates the labels related to the selected component. 
		/// </summary>
		/// <param name="component">Component that was selected.</param>
		public void PopulateComponent(PartsCatalog.Models.Component component) {
			// Reset the control bindings.
			lblComponentName.DataBindings.Clear();
			lblComponentDescription.DataBindings.Clear();

			// Ignore the bindings if we are clearing.
			if (component == null) {
				lblComponentName.Text = "";
				lblComponentDescription.Text = "";

				return;
			}

			// Bind data to fields.
			lblComponentName.DataBindings.Add("Text", component, "Name");
			lblComponentDescription.DataBindings.Add("Text", component,
				"Description");
		}

		/// <summary>
		/// Populates the BOM item control group with data from the specified object.
		/// </summary>
		/// <param name="item">BOM item that will be edited.</param>
		public void PopulateBOMItemGroup(BOMItem item) {
			txtComponentValue.DataBindings.Clear();
			chkComponentPopulate.DataBindings.Clear();
			refDesignators.Clear();
			PopulateComponent(null);

			// Check if we are deselecting a BOM item.
			if (item == null) {
				// Disable the controls that are not useful.
				btnSelectComponent.Enabled = false;
				txtComponentValue.Enabled = false;
				lstRefDes.Enabled = false;
				txtRefDes.Enabled = false;
				btnRefDesAdd.Enabled = false;
				btnRefDesRename.Enabled = false;
				btnRefDesRemove.Enabled = false;
				btnRefDesClear.Enabled = false;
				chkComponentPopulate.Enabled = false;
				btnItemRemove.Enabled = false;
				btnItemSave.Enabled = false;

				// Reset some values.
				chkComponentPopulate.Checked = false;
				txtComponentValue.Text = "";

				return;
			}

			// Populate the controls.
			PopulateComponent(item.Part);
			txtComponentValue.DataBindings.Add("Text", item, "Value", true,
				DataSourceUpdateMode.OnPropertyChanged);
			chkComponentPopulate.DataBindings.Add("Checked", item, "Populate",
				true, DataSourceUpdateMode.OnPropertyChanged);
			foreach (string refDes in item.RefDes) {
				refDesignators.Add(refDes);
			}

			// Enable the controls that are now useful.
			btnSelectComponent.Enabled = true;
			txtComponentValue.Enabled = true;
			lstRefDes.Enabled = true;
			txtRefDes.Enabled = true;
			btnRefDesAdd.Enabled = true;
			btnRefDesClear.Enabled = true;
			chkComponentPopulate.Enabled = true;
			btnItemRemove.Enabled = true;
			btnItemSave.Enabled = true;
		}

		/// <summary>
		/// Populates the reference designator control group.
		/// </summary>
		/// <param name="refDes">Reference designator</param>
		public void PopulateRefDesGroup(string refDes) {
			// Check if we are deselecting a reference designator.
			if (refDes == null) {
				// Disable the controls that are not useful.
				btnRefDesRename.Enabled = false;
				btnRefDesRemove.Enabled = false;
				txtRefDes.Text = "";

				return;
			}

			txtRefDes.Text = refDes;
			btnRefDesRename.Enabled = true;
			btnRefDesRemove.Enabled = true;
		}

		/// <summary>
		/// Displays a dialog to let the user select a component and populates
		/// it in the form if a selection was made.
		/// </summary>
		public void SelectComponent() {
			ComponentSearchForm frmSearch = new ComponentSearchForm();
			DialogResult result = frmSearch.ShowDialogSelection(this);

			// Did the user select anything for us to use?
			if (result == DialogResult.OK)
				PopulateComponent(frmSearch.SelectedComponent);
		}

		/// <summary>
		/// Creates a new project.
		/// </summary>
		public void AddProject() {
			Project project = new Project();
			project.Name = txtProjectName.Text;
			project.Revision = txtProjectRevision.Text;
			project.Description = txtProjectDescription.Text;
			project.Save();

			// Append the new project to the list.
			if (project.IsPersistent()) {
				projects.Add(project);
				PopulateProjectsList(project);
			}
		}

		/// <summary>
		/// Edits the details of a project.
		/// </summary>
		public void SaveProject(Project project) {
			project.Save();
			PopulateProjectsList(project);
		}

		/// <summary>
		/// Removes a project from the database.
		/// </summary>
		/// <param name="project">Project that will be deleted.</param>
		public void DeleteProject(Project project) {
			DialogResult dialog = MessageBox.Show("Are you sure you want to delete " +
				"the " + project + " project?", "Delete project?",
				MessageBoxButtons.YesNo);

			// Ignore if the user was mistaken.
			if (dialog == DialogResult.No)
				return;

			projects.Remove(project);
			project.Delete();
			PopulateProjectsList(null);
		}

		/// <summary>
		/// Creates a new BOM item.
		/// </summary>
		/// <param name="project">BOM item's parent project.</param>
		public void AddBOMItem(Project project) {
			// Create a brand new BOM item.
			BOMItem item = new BOMItem();
			item.Parent = project;
			
			// Add it to the list and select it.
			bomItems.Add(item);
			lstBOMItems.SelectedIndex = bomItems.Count - 1;
		}

		/// <summary>
		/// Saves changes to the BOM item.
		/// </summary>
		/// <param name="item">BOM item that will be edited.</param>
		public void SaveBOMItem(BOMItem item) {
			// Edit the item.
			item.RefDes = new List<string>(refDesignators);
			if (lblComponentName.DataBindings.Count == 1) {
				if (lblComponentName.DataBindings[0] != null) {
					item.Part = (PartsCatalog.Models.Component)
						lblComponentName.DataBindings[0].DataSource;
				}
			}

			// Save and reload the form.
			item.Save();
			PopulateProjectBOMList(item.Parent, item, true);
		}

		/// <summary>
		/// Removes a BOM item from the database.
		/// </summary>
		/// <param name="item">BOM item that will be deleted.</param>
		public void DeleteBOMItem(BOMItem item) {
			DialogResult dialog = MessageBox.Show("Are you sure you want to delete " +
				"this BOM item?", "Delete BOM item?",
				MessageBoxButtons.YesNo);

			// Ignore if the user was mistaken.
			if (dialog == DialogResult.No)
				return;

			Project parent = item.Parent;
			bomItems.Remove(item);
			item.Delete();
			PopulateProjectBOMList(parent, null, true);
		}

		/// <summary>
		/// Adds a reference designator to the list.
		/// </summary>
		/// <param name="refDes">Reference designator.</param>
		public void AddRefDes(string refDes) {
			foreach (string str in refDes.Split(' ')) {
				if (str.Length > 0)
					refDesignators.Add(str);
			}

			PopulateRefDesGroup(null);
		}

		/// <summary>
		/// Renames a reference designators from the list.
		/// </summary>
		/// <param name="original">Original reference designator value.</param>
		/// <param name="newValue">New reference designator value.</param>
		public void RenameRefDes(string original, string newValue) {
			refDesignators.Remove(original);

			foreach (string str in newValue.Split(' ')) {
				if (str.Length > 0)
					refDesignators.Add(str);
			}

			PopulateRefDesGroup(null);
		}

		/// <summary>
		/// Removes a reference designators from the list.
		/// </summary>
		/// <param name="refDes">Reference designator to be deleted.</param>
		public void DeleteRefDes(string refDes) {
			refDesignators.Remove(refDes);
			PopulateRefDesGroup(null);
		}

		/******************
		 * Event Handlers *
		 ******************/

		private void MainForm_Load(object sender, EventArgs e) {
			tslServer.Text = PartsCatalog.Configuration.Domain;
			PopulateProjectsList();
		}

		private void lstProjects_SelectedIndexChanged(object sender, EventArgs e) {
			Project project = (Project)lstProjects.SelectedItem;
			if (project == null)
				return;

			PopulateProjectGroup(project, true);
		}

		private void lstBOMItems_SelectedIndexChanged(object sender, EventArgs e) {
			BOMItem item = (BOMItem)lstBOMItems.SelectedItem;
			if (item == null)
				return;
			
			PopulateBOMItemGroup(item);
		}

		private void lstRefDes_SelectedIndexChanged(object sender, EventArgs e) {
			PopulateRefDesGroup((string)lstRefDes.SelectedItem);
		}

		private void btnRefDesAdd_Click(object sender, EventArgs e) {
			AddRefDes(txtRefDes.Text);
		}

		private void btnRefDesRename_Click(object sender, EventArgs e) {
			RenameRefDes((string)lstRefDes.SelectedItem, txtRefDes.Text);
		}

		private void btnRefDesRemove_Click(object sender, EventArgs e) {
			DeleteRefDes((string)lstRefDes.SelectedItem);
		}

		private void btnItemAdd_Click(object sender, EventArgs e) {
			Project project = (Project)lstProjects.SelectedItem;
			if (project == null)
				throw new Exception("Can't add a BOM item if a project isn't selected");

			AddBOMItem(project);
		}

		private void btnSelectComponent_Click(object sender, EventArgs e) {
			SelectComponent();
		}

		private void btnItemSave_Click(object sender, EventArgs e) {
			BOMItem item = (BOMItem)lstBOMItems.SelectedItem;
			if (item == null)
				return;

			SaveBOMItem(item);
		}

		private void btnItemRemove_Click(object sender, EventArgs e) {
			BOMItem item = (BOMItem)lstBOMItems.SelectedItem;
			if (item == null)
				return;

			DeleteBOMItem(item);
		}

		private void btnRefDesClear_Click(object sender, EventArgs e) {
			refDesignators.Clear();
		}

		private void btnProjectAdd_Click(object sender, EventArgs e) {
			AddProject();
		}

		private void btnProjectSave_Click(object sender, EventArgs e) {
			Project project = (Project)lstProjects.SelectedItem;
			if (project == null)
				return;

			SaveProject(project);
		}

		private void btnProjectRemove_Click(object sender, EventArgs e) {
			Project project = (Project)lstProjects.SelectedItem;
			if (project == null)
				return;

			DeleteProject(project);
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
			Close();
		}

		private void refreshProjectsToolStripMenuItem_Click(object sender, EventArgs e) {
			PopulateProjectsList();
		}

		private void refreshComponentsToolStripMenuItem_Click(object sender, EventArgs e) {
			PopulateProjectGroup((Project)lstProjects.SelectedItem, true);
		}

		private void selectComponentToolStripMenuItem_Click(object sender, EventArgs e) {
			btnSelectComponent_Click(sender, e);
		}

		private void txtRefDes_KeyPress(object sender, KeyPressEventArgs e) {
			if (e.KeyChar == (char)Keys.Enter)
				btnRefDesAdd_Click(sender, null);
		}
	}
}