using System;
using System.Collections.Generic;
using System.Text;
using PartsCatalog.Models;

namespace OrderImporter.Models {
	/// <summary>
	/// Generic component order item.
	/// </summary>
	public class GenericOrderItem : OrderItem {
		/// <summary>
		/// Creates an empty generic component order item.
		/// </summary>
		public GenericOrderItem() : base() {
		}

		public override void ImportFromCSV(string[] fields) {
			throw new NotImplementedException(
				"Generic component orders can't have CSV imports");
		}

		public override string GetComponentPage() {
			return "https://www.google.com/search?q=" + DistributorPartNumber;
		}
	}
}
