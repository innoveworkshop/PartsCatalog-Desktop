namespace OrderImporter.Views {
	partial class OrderPickerForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderPickerForm));
			this.stpStatus = new System.Windows.Forms.StatusStrip();
			this.panOrderSelector = new System.Windows.Forms.Panel();
			this.btnImportOrder = new System.Windows.Forms.Button();
			this.btnBrowseOrder = new System.Windows.Forms.Button();
			this.txtOrderFile = new System.Windows.Forms.TextBox();
			this.lblExportedOrderFile = new System.Windows.Forms.Label();
			this.cmbDistributor = new System.Windows.Forms.ComboBox();
			this.lblSelDistributor = new System.Windows.Forms.Label();
			this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
			this.stpMenu = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openOrderFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.importOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tslServer = new System.Windows.Forms.ToolStripStatusLabel();
			this.stpStatus.SuspendLayout();
			this.panOrderSelector.SuspendLayout();
			this.stpMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// stpStatus
			// 
			this.stpStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslServer});
			this.stpStatus.Location = new System.Drawing.Point(0, 111);
			this.stpStatus.Name = "stpStatus";
			this.stpStatus.Size = new System.Drawing.Size(557, 22);
			this.stpStatus.TabIndex = 0;
			// 
			// panOrderSelector
			// 
			this.panOrderSelector.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.panOrderSelector.Controls.Add(this.btnImportOrder);
			this.panOrderSelector.Controls.Add(this.btnBrowseOrder);
			this.panOrderSelector.Controls.Add(this.txtOrderFile);
			this.panOrderSelector.Controls.Add(this.lblExportedOrderFile);
			this.panOrderSelector.Controls.Add(this.cmbDistributor);
			this.panOrderSelector.Controls.Add(this.lblSelDistributor);
			this.panOrderSelector.Location = new System.Drawing.Point(9, 27);
			this.panOrderSelector.Name = "panOrderSelector";
			this.panOrderSelector.Size = new System.Drawing.Size(539, 78);
			this.panOrderSelector.TabIndex = 1;
			// 
			// btnImportOrder
			// 
			this.btnImportOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.btnImportOrder.Location = new System.Drawing.Point(0, 45);
			this.btnImportOrder.Name = "btnImportOrder";
			this.btnImportOrder.Size = new System.Drawing.Size(539, 33);
			this.btnImportOrder.TabIndex = 25;
			this.btnImportOrder.Text = "Import Order";
			this.btnImportOrder.UseVisualStyleBackColor = true;
			this.btnImportOrder.Click += new System.EventHandler(this.btnImportOrder_Click);
			// 
			// btnBrowseOrder
			// 
			this.btnBrowseOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBrowseOrder.Location = new System.Drawing.Point(510, 17);
			this.btnBrowseOrder.Name = "btnBrowseOrder";
			this.btnBrowseOrder.Size = new System.Drawing.Size(29, 20);
			this.btnBrowseOrder.TabIndex = 24;
			this.btnBrowseOrder.Text = "...";
			this.btnBrowseOrder.UseVisualStyleBackColor = true;
			this.btnBrowseOrder.Click += new System.EventHandler(this.btnBrowseOrder_Click);
			// 
			// txtOrderFile
			// 
			this.txtOrderFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtOrderFile.Location = new System.Drawing.Point(149, 17);
			this.txtOrderFile.Name = "txtOrderFile";
			this.txtOrderFile.Size = new System.Drawing.Size(355, 20);
			this.txtOrderFile.TabIndex = 23;
			// 
			// lblExportedOrderFile
			// 
			this.lblExportedOrderFile.AutoSize = true;
			this.lblExportedOrderFile.Location = new System.Drawing.Point(146, 0);
			this.lblExportedOrderFile.Name = "lblExportedOrderFile";
			this.lblExportedOrderFile.Size = new System.Drawing.Size(97, 13);
			this.lblExportedOrderFile.TabIndex = 22;
			this.lblExportedOrderFile.Text = "Exported Order File";
			// 
			// cmbDistributor
			// 
			this.cmbDistributor.FormattingEnabled = true;
			this.cmbDistributor.Location = new System.Drawing.Point(0, 16);
			this.cmbDistributor.Name = "cmbDistributor";
			this.cmbDistributor.Size = new System.Drawing.Size(140, 21);
			this.cmbDistributor.TabIndex = 21;
			// 
			// lblSelDistributor
			// 
			this.lblSelDistributor.AutoSize = true;
			this.lblSelDistributor.Location = new System.Drawing.Point(-3, 0);
			this.lblSelDistributor.Name = "lblSelDistributor";
			this.lblSelDistributor.Size = new System.Drawing.Size(54, 13);
			this.lblSelDistributor.TabIndex = 20;
			this.lblSelDistributor.Text = "Distributor";
			// 
			// dlgOpenFile
			// 
			this.dlgOpenFile.InitialDirectory = "\\\\MULBERRY\\Master\\Orders";
			// 
			// stpMenu
			// 
			this.stpMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.importOrderToolStripMenuItem});
			this.stpMenu.Location = new System.Drawing.Point(0, 0);
			this.stpMenu.Name = "stpMenu";
			this.stpMenu.Size = new System.Drawing.Size(557, 24);
			this.stpMenu.TabIndex = 2;
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openOrderFileToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// openOrderFileToolStripMenuItem
			// 
			this.openOrderFileToolStripMenuItem.Name = "openOrderFileToolStripMenuItem";
			this.openOrderFileToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
			this.openOrderFileToolStripMenuItem.Text = "&Open Order File...";
			this.openOrderFileToolStripMenuItem.Click += new System.EventHandler(this.openOrderFileToolStripMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(163, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// importOrderToolStripMenuItem
			// 
			this.importOrderToolStripMenuItem.Name = "importOrderToolStripMenuItem";
			this.importOrderToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
			this.importOrderToolStripMenuItem.Text = "&Import Order";
			this.importOrderToolStripMenuItem.Click += new System.EventHandler(this.importOrderToolStripMenuItem_Click);
			// 
			// tslServer
			// 
			this.tslServer.Name = "tslServer";
			this.tslServer.Size = new System.Drawing.Size(74, 17);
			this.tslServer.Text = "Server Name";
			// 
			// OrderPickerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(557, 133);
			this.Controls.Add(this.panOrderSelector);
			this.Controls.Add(this.stpStatus);
			this.Controls.Add(this.stpMenu);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.stpMenu;
			this.MaximizeBox = false;
			this.Name = "OrderPickerForm";
			this.Text = "Order Importer";
			this.Load += new System.EventHandler(this.OrderPickerForm_Load);
			this.stpStatus.ResumeLayout(false);
			this.stpStatus.PerformLayout();
			this.panOrderSelector.ResumeLayout(false);
			this.panOrderSelector.PerformLayout();
			this.stpMenu.ResumeLayout(false);
			this.stpMenu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip stpStatus;
		private System.Windows.Forms.Panel panOrderSelector;
		private System.Windows.Forms.ComboBox cmbDistributor;
		private System.Windows.Forms.Label lblSelDistributor;
		private System.Windows.Forms.Label lblExportedOrderFile;
		private System.Windows.Forms.TextBox txtOrderFile;
		private System.Windows.Forms.OpenFileDialog dlgOpenFile;
		private System.Windows.Forms.Button btnBrowseOrder;
		private System.Windows.Forms.MenuStrip stpMenu;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openOrderFileToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem importOrderToolStripMenuItem;
		private System.Windows.Forms.Button btnImportOrder;
		private System.Windows.Forms.ToolStripStatusLabel tslServer;
	}
}