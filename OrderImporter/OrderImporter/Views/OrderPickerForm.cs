using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OrderImporter.Services;
using OrderImporter.Models;

namespace OrderImporter.Views {
	/// <summary>
	/// A simple form to let the user pick an order to import.
	/// </summary>
	public partial class OrderPickerForm : Form {
		// Supported distributors helper variables.
		public enum SupportedDistributors {
			Invalid = -1,
			FarnellPT = 0,
			RobertMauser
		};
		private string[] _supportedDistributorNames = {
			"Farnell (PT)",
			"Robert Mauser Lda"
		};
		public enum SupportedExtensions {
			CSV = 0,
			EML,
			AllFiles
		};

		/// <summary>
		/// Initializes the form and its components.
		/// </summary>
		public OrderPickerForm() {
			// Initialize the controls.
			InitializeComponent();
			InitializeDistributorList();

			// Setup the open file dialog.
			dlgOpenFile.Filter = "CSV File|*.csv|Email Export|*.eml|All Files|*.*";

			// Use a sample Mauser order for testing.
			FilePath = @"\\MULBERRY\Master\Orders\MauserExample.eml";
			cmbDistributor.SelectedIndex = 1;
		}

		/// <summary>
		/// Opens the order imported form with an order populated in it and
		/// hide this one.
		/// </summary>
		protected void ImportOrder() {
			MainForm frmMain = new MainForm();

			// Set the appropriate order type in the form.
			switch (SelectedDistributor) {
			case SupportedDistributors.FarnellPT:
				// Farnell (PT)
				frmMain.SetOrder<FarnellOrderItem>(new FarnellOrder(FilePath));
				break;
			case SupportedDistributors.RobertMauser:
				// Robert Mauser Lda
				frmMain.SetOrder<RobertMauserOrderItem>(
					new RobertMauserOrder(FilePath));
				break;
			default:
				MessageBox.Show("You need to specify a supported distributor " +
					"before importing an order.", "Invalid Distributor Choosen",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				frmMain.Dispose();
				return;
			}

			// Do this crappy hack to make sure we properly show only the
			// importer form and properly close the application when that form
			// is closed.
			Hide();
			frmMain.ShowDialog();
			Close();
		}

		/// <summary>
		/// Browse for an order file to import.
		/// </summary>
		public void BrowseOrderFile() {
			// Set the appropriate attributes depending on the selected distributor.
			switch (SelectedDistributor) {
			case SupportedDistributors.FarnellPT:
				// Farnell (PT)
				SetOpenDialogFilter(SupportedExtensions.CSV);
				break;
			case SupportedDistributors.RobertMauser:
				// Robert Mauser Lda
				SetOpenDialogFilter(SupportedExtensions.EML);
				break;
			default:
				SetOpenDialogFilter(SupportedExtensions.AllFiles);
				break;
			}

			// Open the open file dialog.
			if (dlgOpenFile.ShowDialog() != DialogResult.OK)
				return;

			// Set the selected file path.
			FilePath = dlgOpenFile.FileName;
		}

		/// <summary>
		/// Initializes the distributor's ComboBox with the supported
		/// distributors.
		/// </summary>
		protected void InitializeDistributorList() {
			// Start from scratch.
			cmbDistributor.Items.Clear();

			// Populate the list making sure it'll track the distributor's enum.
			for (int i = 0; i < SupportedDistributorNames.Length; i++) {
				cmbDistributor.Items.Insert(i, SupportedDistributorNames[i]);
			}

			// Set the first one as the default.
			cmbDistributor.SelectedIndex = 0;
		}

		/// <summary>
		/// Sets the open dialog extension filter.
		/// </summary>
		/// <param name="ext">Extension to filter for.</param>
		protected void SetOpenDialogFilter(SupportedExtensions ext) {
			dlgOpenFile.FilterIndex = (int)ext + 1;
		}

		/// <summary>
		/// Path to the distributor's exported order file.
		/// </summary>
		public string FilePath {
			get { return txtOrderFile.Text; }
			set { txtOrderFile.Text = value; }
		}

		/// <summary>
		/// List of supported distributor's names.
		/// </summary>
		public string[] SupportedDistributorNames {
			get { return _supportedDistributorNames; }
		}

		/// <summary>
		/// Currently selected distributor.
		/// </summary>
		public SupportedDistributors SelectedDistributor {
			get { return (SupportedDistributors)cmbDistributor.SelectedIndex; }
		}

		/******************
		 * Event Handlers *
		 ******************/

		private void importOrderToolStripMenuItem_Click(object sender, EventArgs e) {
			ImportOrder();
		}

		private void openOrderFileToolStripMenuItem_Click(object sender, EventArgs e) {
			BrowseOrderFile();
		}

		private void btnBrowseOrder_Click(object sender, EventArgs e) {
			BrowseOrderFile();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
			Close();
		}

		private void btnImportOrder_Click(object sender, EventArgs e) {
			ImportOrder();
		}
	}
}