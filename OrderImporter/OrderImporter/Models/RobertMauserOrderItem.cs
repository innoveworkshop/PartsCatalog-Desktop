using System;
using System.Collections.Generic;
using System.Text;
using PartsCatalog.Models;

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

		public RobertMauserOrderItem(string[] fields) : base(fields) {
			throw new Exception("Robert Mauser Lda orders do not come as CSV files");
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

		public override void ImportFromCSV(string[] fields) {
#if DEBUG
			for (int i = 0; i < fields.Length; i++) {
				System.Diagnostics.Debug.WriteLine("Field #" + i + ": " +
					fields[i]);
			}

			System.Diagnostics.Debug.WriteLine("");
#endif
			// Order item properties.
			DistributorPartNumber = fields[13];

			// Component properties.
			Name = fields[18];
			Quantity = (int)float.Parse(fields[19]);
			ParseDescription(fields[16]);
		}

		public override string GetComponentPage() {
			return "https://mauser.pt/catalog/product_info.php?products_id=" +
				DistributorPartNumber;
		}
	}
}
