using System;
using System.Collections.Generic;
using System.Text;
using PartsCatalog.Models;

namespace OrderImporter.Models {
	/// <summary>
	/// Ordered component abstraction.
	/// </summary>
	public abstract class OrderItem : Component {
		private string _distributorPartNum;

		/// <summary>
		/// Creates an empty component order item.
		/// </summary>
		public OrderItem() : base() {
			DistributorPartNumber = null;
		}

		/// <summary>
		/// Creates an component order item and populates it from CSV fields.
		/// </summary>
		/// <param name="fields">Order CSV row fields.</param>
		public OrderItem(string[] fields) : base() {
			ImportFromCSV(fields);
		}

		/// <summary>
		/// Imports a component order item from a set of CSV fields.
		/// </summary>
		/// <param name="fields">CSV row fields.</param>
		public abstract void ImportFromCSV(string[] fields);

		/// <summary>
		/// Gets the distributor's web page for this component.
		/// </summary>
		/// <returns>Distributor's web page for this component.</returns>
		public abstract string GetComponentPage();

		/// <summary>
		/// Opens the distributor website for this component.
		/// </summary>
		public void OpenComponentPage() {
			System.Diagnostics.Process.Start(GetComponentPage());
		}

		/// <summary>
		/// Distributor's part number for this component.
		/// </summary>
		public string DistributorPartNumber {
			get { return _distributorPartNum; }
			set { _distributorPartNum = value; }
		}
	}
}
