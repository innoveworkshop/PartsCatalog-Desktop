using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PartsCatalog.Models;
using OrderImporter.Services;
using OrderImporter.Models;

namespace OrderImporter {
	/// <summary>
	/// Main form of the application.
	/// </summary>
	public partial class MainForm : Form {
		private OrderItem currentItem;
		private BindingList<Property> properties;

		/// <summary>
		/// Initializes the form and its components.
		/// </summary>
		public MainForm() {
			InitializeComponent();

			// Initialize some variables.
			currentItem = null;
			properties = new BindingList<Property>();

			// Setup the properties table.
			grdProperties.AutoGenerateColumns = false;
			grdProperties.DataSource = properties;
			grdProperties.Columns.Add("Name", "Property");
			grdProperties.Columns.Add("Value", "Value");
			grdProperties.Columns["Name"].DataPropertyName = "Name";
			grdProperties.Columns["Value"].DataPropertyName = "Value";
			grdProperties.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			grdProperties.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			grdProperties.Columns["Value"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

			// Create a test Farnell order and attach its items to a binding source.
			FarnellOrder order = new FarnellOrder(
				@"\\MULBERRY\Master\Orders\Farnell\2021-06-09-ORDERLINEOrderDetail.csv");
			navBinding.BindingSource.DataSource = order.Items;
		}

		/******************
		 * Event Handlers *
		 ******************/

		private void bindingSource_CurrentChanged(object sender, EventArgs e) {
			currentItem = (OrderItem)bindingSource.Current;

			// Quantity field.
			updQuantity.DataBindings.Clear();
			updQuantity.DataBindings.Add("Value", currentItem, "Quantity",
				true, DataSourceUpdateMode.OnPropertyChanged);

			// Name field.
			txtName.DataBindings.Clear();
			txtName.DataBindings.Add("Text", currentItem, "Name", true,
				DataSourceUpdateMode.OnPropertyChanged);

			// Description field.
			txtDescription.DataBindings.Clear();
			txtDescription.DataBindings.Add("Text", currentItem, "Description",
				true, DataSourceUpdateMode.OnPropertyChanged);

			// Populate the properties table.
			properties.Clear();
			foreach (Property property in currentItem.Properties) {
				properties.Add(property);
			}
		}
	}
}