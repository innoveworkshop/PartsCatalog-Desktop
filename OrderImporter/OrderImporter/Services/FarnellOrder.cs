using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic.FileIO;
using System.ComponentModel;
using OrderImporter.Models;

namespace OrderImporter.Services {
	/// <summary>
	/// Processes a Farnell order CSV file.
	/// </summary>
	public class FarnellOrder {
		private string _filePath;
		private BindingList<FarnellOrderItem> _items;

		/// <summary>
		/// Creates an empty Farnell order object.
		/// </summary>
		public FarnellOrder() {
			Items = new BindingList<FarnellOrderItem>();
		}

		/// <summary>
		/// Creates a Farnell order object from an order CSV file.
		/// </summary>
		/// <param name="filePath">Farnell order CSV file.</param>
		public FarnellOrder(string filePath) : this() {
			FilePath = filePath;
		}

		/// <summary>
		/// Parses the order file and populates the items list.
		/// </summary>
		private void ParseOrder() {
			// Check if the file actually exists.
			if (!File.Exists(FilePath))
				throw new Exception("Order file path doesn't exist");

			// Setup the parser.
			TextFieldParser parser = new TextFieldParser(FilePath);
			parser.TextFieldType = FieldType.Delimited;
			parser.SetDelimiters(",");

			// Go through the order.
			Items.Clear();
			while (!parser.EndOfData) {
				// Get fields.
				string[] fields = parser.ReadFields();
				if (!IsValidRow(fields))
					continue;

				// Populate the items list.
				Items.Add(new FarnellOrderItem(fields));
			}

			parser.Close();
		}

		/// <summary>
		/// Checks if an order row is actually valid.
		/// </summary>
		/// <param name="fields">Row fields.</param>
		/// <returns>True if the row is valid.</returns>
		private bool IsValidRow(string[] fields) {
			// For some reason Farnell does this weird thing when part of an
			// order is canceled where only the cancelled row will have all
			// of the fields in the header populated for some obscure reason.
			// So we can ignore all of those.
			return fields.Length == 22;
		}

		/// <summary>
		/// Path to the order's CSV file.
		/// </summary>
		public string FilePath {
			get { return _filePath; }
			set {
				_filePath = value;
				ParseOrder();
			}
		}

		/// <summary>
		/// List of items in the order.
		/// </summary>
		public BindingList<FarnellOrderItem> Items {
			get { return _items; }
			set { _items = value; }
		}
	}
}
