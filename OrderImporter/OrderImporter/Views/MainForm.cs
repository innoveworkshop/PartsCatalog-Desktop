using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OrderImporter.Services;

namespace OrderImporter {
	public partial class MainForm : Form {
		public MainForm() {
			InitializeComponent();

			FarnellOrder order = new FarnellOrder(@"\\MULBERRY\Master\Orders\Farnell\2021-06-09-ORDERLINEOrderDetail.csv");
			//
		}

		/******************
		 * Event Handlers *
		 ******************/

	}
}