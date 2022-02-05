using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic.FileIO;
using System.ComponentModel;
using OrderImporter.Models;

namespace OrderImporter.Services {
	/// <summary>
	/// Abstracts away the different distributor's orders.
	/// </summary>
	public abstract class DistributorOrder<T> where T : OrderItem {
		private string _filePath;
		private BindingList<T> _items;

		/// <summary>
		/// Creates an empty order object.
		/// </summary>
		public DistributorOrder() {
			Items = new BindingList<T>();
		}

		/// <summary>
		/// Creates an order object from the distributor's exported order file.
		/// </summary>
		/// <param name="filePath">Path to the distributor's exported order file.</param>
		public DistributorOrder(string filePath) : this() {
			FilePath = filePath;
		}

		/// <summary>
		/// Parses the order file and populates the items list.
		/// </summary>
		protected virtual void ParseOrder() {
			// Check if the file actually exists.
			if (!File.Exists(FilePath))
				throw new Exception("Order file path doesn't exist");
		}

		/// <summary>
		/// Path to the distributor's exported order file.
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
		public BindingList<T> Items {
			get { return _items; }
			set { _items = value; }
		}
	}
}
