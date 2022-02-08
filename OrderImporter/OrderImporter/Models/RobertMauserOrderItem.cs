using System;
using System.Collections.Generic;
using System.Text;
using PartsCatalog.Models;
using HtmlAgilityPack;

namespace OrderImporter.Models {
	/// <summary>
	/// Robert Mauser Lda component order item.
	/// </summary>
	public class RobertMauserOrderItem : OrderItem {
		/// <summary>
		/// Creates an empty Robert Mauser Lda component order item.
		/// </summary>
		public RobertMauserOrderItem() : base() {
		}

		/// <summary>
		/// Creates a Robert Mauser Lda component order item and populates it
		/// from an HTML node.
		/// </summary>
		/// <param name="node">Order item HTML node.</param>
		public RobertMauserOrderItem(HtmlNode node) : base() {
			ImportFromHTML(node);
		}

		/// <summary>
		/// Parses the mess that is Farnell's description field.
		/// </summary>
		/// <param name="field">CSV description field.</param>
		private void ParseDescription(string field) {
			string[] fields = field.Split(';');

			// Get description.
			Description = fields[0];

			// Go through properties.
			for (int i = 1; i < fields.Length; i++) {
				// Get property and check for invalid ones.
				string[] prop = fields[i].Split(':');
				if (prop.Length != 2)
					continue;

				// Add the new property.
				Property property = new Property(prop[0], prop[1]);
				property.Parent = this;
				Properties.Add(property);
			}
		}

		/// <summary>
		/// Populates this object with data from an HTML node.
		/// </summary>
		/// <param name="node">Order item HTML node.</param>
		public void ImportFromHTML(HtmlNode node) {
			// Do some primitive parsing.
			string descHtml = node.SelectSingleNode("./td[2]").InnerHtml;
			string[] fields = descHtml.Split(new string[] { "<br>" }, 2,
				StringSplitOptions.RemoveEmptyEntries);
			string strQnt = node.SelectSingleNode("./td[3]").InnerHtml.Split(' ')[0];

			// Populate the object.
			DistributorPartNumber = fields[0].Trim();
			Description = fields[1].Trim();
			Quantity = int.Parse(strQnt);
		}

		/// <summary>
		/// DO NOT USE THIS. Mauser orders do not come in CSV format.
		/// </summary>
		public override void ImportFromCSV(string[] fields) {
			throw new Exception("Robert Mauser Lda orders do not come as CSV files");
		}

		public override string GetComponentPage() {
			return "https://mauser.pt/catalog/product_info.php?products_id=" +
				DistributorPartNumber;
		}
	}
}
