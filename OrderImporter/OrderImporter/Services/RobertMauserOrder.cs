using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using OrderImporter.Models;
using EMLParser.Models;

namespace OrderImporter.Services {
	/// <summary>
	/// Processes a Robert Mauser Lda order CSV file.
	/// </summary>
	public class RobertMauserOrder : DistributorOrder<RobertMauserOrderItem> {
		/// <summary>
		/// Creates an empty Robert Mauser Lda order object.
		/// </summary>
		public RobertMauserOrder() : base() {
		}

		/// <summary>
		/// Creates a Robert Mauser Lda order object from an order EML file.
		/// </summary>
		/// <param name="filePath">Robert Mauser Lda order EML file.</param>
		public RobertMauserOrder(string filePath) : base(filePath) {
		}

		protected override void ParseOrder() {
			// Do some things first.
			base.ParseOrder();

			// Parse the EML file.
			EmailMessage message = EMLParser.EMLParser.ParseFile(FilePath);
			EmailBody body = null;

			// Get the appropriate message body.
			foreach (EmailBody bd in message.Bodies) {
				// Only get the HTML body.
				if (bd.ContentType == "text/html") {
					body = bd;
					break;
				}
			}

			// Check if we actually got something.
			if (body == null)
				throw new Exception("Couldn't find an HTML body in the order file");

			// Go through the order.
			Items.Clear();
			while (false) {
				// Get fields.
				//string[] fields = parser.ReadFields();
				
				// Populate the items list.
				//Items.Add(new FarnellOrderItem(fields));
			}
		}
	}
}
