namespace OrderImporter {
	partial class MainForm {
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.navBinding = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.stpStatus = new System.Windows.Forms.StatusStrip();
			this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.panFields = new System.Windows.Forms.Panel();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.lblDescription = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.lblName = new System.Windows.Forms.Label();
			this.updQuantity = new System.Windows.Forms.NumericUpDown();
			this.lblQuantity = new System.Windows.Forms.Label();
			this.panProperties = new System.Windows.Forms.Panel();
			this.grdProperties = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.navBinding)).BeginInit();
			this.navBinding.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
			this.panFields.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.updQuantity)).BeginInit();
			this.panProperties.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdProperties)).BeginInit();
			this.SuspendLayout();
			// 
			// navBinding
			// 
			this.navBinding.AddNewItem = null;
			this.navBinding.BindingSource = this.bindingSource;
			this.navBinding.CountItem = this.bindingNavigatorCountItem;
			this.navBinding.DeleteItem = null;
			this.navBinding.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
			this.navBinding.Location = new System.Drawing.Point(0, 0);
			this.navBinding.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.navBinding.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.navBinding.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.navBinding.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.navBinding.Name = "navBinding";
			this.navBinding.PositionItem = this.bindingNavigatorPositionItem;
			this.navBinding.Size = new System.Drawing.Size(428, 25);
			this.navBinding.TabIndex = 0;
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
			this.bindingNavigatorCountItem.Text = "of {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveFirstItem.Text = "Move first";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMovePreviousItem.Text = "Move previous";
			// 
			// bindingNavigatorSeparator
			// 
			this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorPositionItem
			// 
			this.bindingNavigatorPositionItem.AccessibleName = "Position";
			this.bindingNavigatorPositionItem.AutoSize = false;
			this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "Current position";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveNextItem.Text = "Move next";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveLastItem.Text = "Move last";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// stpStatus
			// 
			this.stpStatus.Location = new System.Drawing.Point(0, 331);
			this.stpStatus.Name = "stpStatus";
			this.stpStatus.Size = new System.Drawing.Size(428, 22);
			this.stpStatus.TabIndex = 1;
			// 
			// bindingSource
			// 
			this.bindingSource.CurrentChanged += new System.EventHandler(this.bindingSource_CurrentChanged);
			// 
			// panFields
			// 
			this.panFields.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.panFields.Controls.Add(this.txtDescription);
			this.panFields.Controls.Add(this.lblDescription);
			this.panFields.Controls.Add(this.txtName);
			this.panFields.Controls.Add(this.lblName);
			this.panFields.Controls.Add(this.updQuantity);
			this.panFields.Controls.Add(this.lblQuantity);
			this.panFields.Location = new System.Drawing.Point(9, 28);
			this.panFields.Name = "panFields";
			this.panFields.Size = new System.Drawing.Size(411, 93);
			this.panFields.TabIndex = 2;
			// 
			// txtDescription
			// 
			this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtDescription.Location = new System.Drawing.Point(0, 55);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(411, 32);
			this.txtDescription.TabIndex = 17;
			// 
			// lblDescription
			// 
			this.lblDescription.AutoSize = true;
			this.lblDescription.Location = new System.Drawing.Point(-3, 39);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(60, 13);
			this.lblDescription.TabIndex = 16;
			this.lblDescription.Text = "Description";
			// 
			// txtName
			// 
			this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtName.Location = new System.Drawing.Point(68, 16);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(343, 20);
			this.txtName.TabIndex = 15;
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(65, 0);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(35, 13);
			this.lblName.TabIndex = 14;
			this.lblName.Text = "Name";
			// 
			// updQuantity
			// 
			this.updQuantity.Location = new System.Drawing.Point(0, 16);
			this.updQuantity.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
			this.updQuantity.Name = "updQuantity";
			this.updQuantity.Size = new System.Drawing.Size(59, 20);
			this.updQuantity.TabIndex = 13;
			// 
			// lblQuantity
			// 
			this.lblQuantity.AutoSize = true;
			this.lblQuantity.Location = new System.Drawing.Point(-3, 0);
			this.lblQuantity.Name = "lblQuantity";
			this.lblQuantity.Size = new System.Drawing.Size(46, 13);
			this.lblQuantity.TabIndex = 12;
			this.lblQuantity.Text = "Quantity";
			// 
			// panProperties
			// 
			this.panProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.panProperties.Controls.Add(this.grdProperties);
			this.panProperties.Location = new System.Drawing.Point(9, 127);
			this.panProperties.Name = "panProperties";
			this.panProperties.Size = new System.Drawing.Size(411, 197);
			this.panProperties.TabIndex = 3;
			// 
			// grdProperties
			// 
			this.grdProperties.AllowUserToAddRows = false;
			this.grdProperties.AllowUserToDeleteRows = false;
			this.grdProperties.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.grdProperties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdProperties.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grdProperties.Location = new System.Drawing.Point(0, 0);
			this.grdProperties.Name = "grdProperties";
			this.grdProperties.ReadOnly = true;
			this.grdProperties.RowHeadersVisible = false;
			this.grdProperties.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdProperties.Size = new System.Drawing.Size(411, 197);
			this.grdProperties.TabIndex = 1;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(428, 353);
			this.Controls.Add(this.panProperties);
			this.Controls.Add(this.panFields);
			this.Controls.Add(this.stpStatus);
			this.Controls.Add(this.navBinding);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "Order Importer";
			((System.ComponentModel.ISupportInitialize)(this.navBinding)).EndInit();
			this.navBinding.ResumeLayout(false);
			this.navBinding.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
			this.panFields.ResumeLayout(false);
			this.panFields.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.updQuantity)).EndInit();
			this.panProperties.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grdProperties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.BindingNavigator navBinding;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private System.Windows.Forms.StatusStrip stpStatus;
		private System.Windows.Forms.BindingSource bindingSource;
		private System.Windows.Forms.Panel panFields;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.Label lblDescription;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.NumericUpDown updQuantity;
		private System.Windows.Forms.Label lblQuantity;
		private System.Windows.Forms.Panel panProperties;
		private System.Windows.Forms.DataGridView grdProperties;
	}
}

