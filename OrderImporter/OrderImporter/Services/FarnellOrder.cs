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
	public class FarnellOrder : DistributorOrder<FarnellOrderItem> {
		/// <summary>
		/// Creates an empty Farnell order object.
		/// </summary>
		public FarnellOrder() : base() {
		}

		/// <summary>
		/// Creates a Farnell order object from an order CSV file.
		/// </summary>
		/// <param name="filePath">Farnell order CSV file.</param>
		public FarnellOrder(string filePath) : base(filePath) {
		}

		protected override void ParseOrder() {
			// Do some things first.
			base.ParseOrder();

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
	}
}
