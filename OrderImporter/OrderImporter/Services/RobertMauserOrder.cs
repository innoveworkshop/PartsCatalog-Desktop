using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using OrderImporter.Models;
using EMLParser.Models;
using HtmlAgilityPack;

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

			// Parse the EML file and get the HTML document.
			EmailMessage message = EMLParser.EMLParser.ParseFile(FilePath);
			HtmlDocument doc = GetOrderDocument(message);

			// Get the order items table.
			HtmlNode table = doc.DocumentNode.SelectSingleNode(@"(//table)[5]");
			HtmlNodeCollection nodes = table.SelectNodes("./tr[position()>1]");

			// Go through the order.
			Items.Clear();
			foreach (HtmlNode item in nodes) {
				// Populate the items list.
				Items.Add(new RobertMauserOrderItem(item));
			}
		}

		/// <summary>
		/// Gets the order HTML document from the order message.
		/// </summary>
		/// <param name="message">Order email archive.</param>
		/// <returns>HTML document for the order.</returns>
		private HtmlDocument GetOrderDocument(EmailMessage message) {
			HtmlDocument doc = new HtmlDocument();
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

			// Parse our message body.
			doc.LoadHtml(body.Contents);

			return doc;
		}
	}
}
