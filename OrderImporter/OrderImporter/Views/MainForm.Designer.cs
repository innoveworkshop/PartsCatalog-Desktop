namespace OrderImporter.Views {
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.navBinding = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.tsbImport = new System.Windows.Forms.ToolStripButton();
			this.tsbViewComponent = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.tsbDistributorWebsite = new System.Windows.Forms.ToolStripButton();
			this.stpStatus = new System.Windows.Forms.StatusStrip();
			this.panFields = new System.Windows.Forms.Panel();
			this.txtDatasheetURL = new System.Windows.Forms.TextBox();
			this.lblDatasheetURL = new System.Windows.Forms.Label();
			this.cmbSubCategory = new System.Windows.Forms.ComboBox();
			this.lblSubCategory = new System.Windows.Forms.Label();
			this.cmbCategory = new System.Windows.Forms.ComboBox();
			this.lblCategory = new System.Windows.Forms.Label();
			this.cmbPackage = new System.Windows.Forms.ComboBox();
			this.lblPackage = new System.Windows.Forms.Label();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.lblDescription = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.lblName = new System.Windows.Forms.Label();
			this.updQuantity = new System.Windows.Forms.NumericUpDown();
			this.lblQuantity = new System.Windows.Forms.Label();
			this.panProperties = new System.Windows.Forms.Panel();
			this.grdProperties = new System.Windows.Forms.DataGridView();
			this.tsbCheckDatabase = new System.Windows.Forms.ToolStripButton();
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
            this.bindingNavigatorSeparator2,
            this.tsbImport,
            this.tsbViewComponent,
            this.tsbCheckDatabase,
            this.toolStripSeparator1,
            this.tsbDistributorWebsite});
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
			// bindingSource
			// 
			this.bindingSource.CurrentChanged += new System.EventHandler(this.bindingSource_CurrentChanged);
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
			// tsbImport
			// 
			this.tsbImport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbImport.Enabled = false;
			this.tsbImport.Image = ((System.Drawing.Image)(resources.GetObject("tsbImport.Image")));
			this.tsbImport.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbImport.Name = "tsbImport";
			this.tsbImport.Size = new System.Drawing.Size(23, 22);
			this.tsbImport.Text = "Import";
			this.tsbImport.Click += new System.EventHandler(this.tsbImport_Click);
			// 
			// tsbViewComponent
			// 
			this.tsbViewComponent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbViewComponent.Enabled = false;
			this.tsbViewComponent.Image = ((System.Drawing.Image)(resources.GetObject("tsbViewComponent.Image")));
			this.tsbViewComponent.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbViewComponent.Name = "tsbViewComponent";
			this.tsbViewComponent.Size = new System.Drawing.Size(23, 22);
			this.tsbViewComponent.Text = "View Component";
			this.tsbViewComponent.Click += new System.EventHandler(this.tsbViewComponent_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// tsbDistributorWebsite
			// 
			this.tsbDistributorWebsite.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbDistributorWebsite.Image = ((System.Drawing.Image)(resources.GetObject("tsbDistributorWebsite.Image")));
			this.tsbDistributorWebsite.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbDistributorWebsite.Name = "tsbDistributorWebsite";
			this.tsbDistributorWebsite.Size = new System.Drawing.Size(23, 22);
			this.tsbDistributorWebsite.Text = "Distributor\'s Website";
			this.tsbDistributorWebsite.ToolTipText = "Go to the distributor\'s website";
			this.tsbDistributorWebsite.Click += new System.EventHandler(this.tsbDistributorWebsite_Click);
			// 
			// stpStatus
			// 
			this.stpStatus.Location = new System.Drawing.Point(0, 422);
			this.stpStatus.Name = "stpStatus";
			this.stpStatus.Size = new System.Drawing.Size(428, 22);
			this.stpStatus.TabIndex = 1;
			// 
			// panFields
			// 
			this.panFields.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.panFields.Controls.Add(this.txtDatasheetURL);
			this.panFields.Controls.Add(this.lblDatasheetURL);
			this.panFields.Controls.Add(this.cmbSubCategory);
			this.panFields.Controls.Add(this.lblSubCategory);
			this.panFields.Controls.Add(this.cmbCategory);
			this.panFields.Controls.Add(this.lblCategory);
			this.panFields.Controls.Add(this.cmbPackage);
			this.panFields.Controls.Add(this.lblPackage);
			this.panFields.Controls.Add(this.txtDescription);
			this.panFields.Controls.Add(this.lblDescription);
			this.panFields.Controls.Add(this.txtName);
			this.panFields.Controls.Add(this.lblName);
			this.panFields.Controls.Add(this.updQuantity);
			this.panFields.Controls.Add(this.lblQuantity);
			this.panFields.Location = new System.Drawing.Point(9, 28);
			this.panFields.Name = "panFields";
			this.panFields.Size = new System.Drawing.Size(411, 175);
			this.panFields.TabIndex = 2;
			// 
			// txtDatasheetURL
			// 
			this.txtDatasheetURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtDatasheetURL.Location = new System.Drawing.Point(0, 153);
			this.txtDatasheetURL.Name = "txtDatasheetURL";
			this.txtDatasheetURL.Size = new System.Drawing.Size(411, 20);
			this.txtDatasheetURL.TabIndex = 25;
			// 
			// lblDatasheetURL
			// 
			this.lblDatasheetURL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblDatasheetURL.AutoSize = true;
			this.lblDatasheetURL.Location = new System.Drawing.Point(-3, 137);
			this.lblDatasheetURL.Name = "lblDatasheetURL";
			this.lblDatasheetURL.Size = new System.Drawing.Size(81, 13);
			this.lblDatasheetURL.TabIndex = 24;
			this.lblDatasheetURL.Text = "Datasheet URL";
			// 
			// cmbSubCategory
			// 
			this.cmbSubCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.cmbSubCategory.FormattingEnabled = true;
			this.cmbSubCategory.Location = new System.Drawing.Point(211, 55);
			this.cmbSubCategory.Name = "cmbSubCategory";
			this.cmbSubCategory.Size = new System.Drawing.Size(200, 21);
			this.cmbSubCategory.TabIndex = 23;
			// 
			// lblSubCategory
			// 
			this.lblSubCategory.AutoSize = true;
			this.lblSubCategory.Location = new System.Drawing.Point(208, 39);
			this.lblSubCategory.Name = "lblSubCategory";
			this.lblSubCategory.Size = new System.Drawing.Size(71, 13);
			this.lblSubCategory.TabIndex = 22;
			this.lblSubCategory.Text = "Sub-Category";
			// 
			// cmbCategory
			// 
			this.cmbCategory.FormattingEnabled = true;
			this.cmbCategory.Location = new System.Drawing.Point(0, 55);
			this.cmbCategory.Name = "cmbCategory";
			this.cmbCategory.Size = new System.Drawing.Size(202, 21);
			this.cmbCategory.TabIndex = 21;
			// 
			// lblCategory
			// 
			this.lblCategory.AutoSize = true;
			this.lblCategory.Location = new System.Drawing.Point(-3, 39);
			this.lblCategory.Name = "lblCategory";
			this.lblCategory.Size = new System.Drawing.Size(49, 13);
			this.lblCategory.TabIndex = 20;
			this.lblCategory.Text = "Category";
			// 
			// cmbPackage
			// 
			this.cmbPackage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmbPackage.FormattingEnabled = true;
			this.cmbPackage.Location = new System.Drawing.Point(304, 15);
			this.cmbPackage.Name = "cmbPackage";
			this.cmbPackage.Size = new System.Drawing.Size(107, 21);
			this.cmbPackage.TabIndex = 19;
			// 
			// lblPackage
			// 
			this.lblPackage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblPackage.AutoSize = true;
			this.lblPackage.Location = new System.Drawing.Point(301, 0);
			this.lblPackage.Name = "lblPackage";
			this.lblPackage.Size = new System.Drawing.Size(50, 13);
			this.lblPackage.TabIndex = 18;
			this.lblPackage.Text = "Package";
			// 
			// txtDescription
			// 
			this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtDescription.Location = new System.Drawing.Point(0, 95);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(411, 39);
			this.txtDescription.TabIndex = 17;
			// 
			// lblDescription
			// 
			this.lblDescription.AutoSize = true;
			this.lblDescription.Location = new System.Drawing.Point(-3, 79);
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
			this.txtName.Size = new System.Drawing.Size(227, 20);
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
			this.panProperties.Location = new System.Drawing.Point(9, 209);
			this.panProperties.Name = "panProperties";
			this.panProperties.Size = new System.Drawing.Size(411, 206);
			this.panProperties.TabIndex = 3;
			// 
			// grdProperties
			// 
			this.grdProperties.AllowUserToAddRows = false;
			this.grdProperties.AllowUserToDeleteRows = false;
			this.grdProperties.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.grdProperties.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.grdProperties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.grdProperties.DefaultCellStyle = dataGridViewCellStyle5;
			this.grdProperties.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grdProperties.Location = new System.Drawing.Point(0, 0);
			this.grdProperties.Name = "grdProperties";
			this.grdProperties.ReadOnly = true;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.grdProperties.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.grdProperties.RowHeadersVisible = false;
			this.grdProperties.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdProperties.Size = new System.Drawing.Size(411, 206);
			this.grdProperties.TabIndex = 1;
			// 
			// tsbCheckDatabase
			// 
			this.tsbCheckDatabase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbCheckDatabase.Image = ((System.Drawing.Image)(resources.GetObject("tsbCheckDatabase.Image")));
			this.tsbCheckDatabase.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbCheckDatabase.Name = "tsbCheckDatabase";
			this.tsbCheckDatabase.Size = new System.Drawing.Size(23, 22);
			this.tsbCheckDatabase.Text = "Check in Database";
			this.tsbCheckDatabase.ToolTipText = "Check if there\'s an approximate component in the database";
			this.tsbCheckDatabase.Click += new System.EventHandler(this.tsbCheckDatabase_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(428, 444);
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
		private System.Windows.Forms.ToolStripButton tsbImport;
		private System.Windows.Forms.ToolStripButton tsbViewComponent;
		private System.Windows.Forms.Label lblPackage;
		private System.Windows.Forms.ComboBox cmbPackage;
		private System.Windows.Forms.ComboBox cmbSubCategory;
		private System.Windows.Forms.Label lblSubCategory;
		private System.Windows.Forms.ComboBox cmbCategory;
		private System.Windows.Forms.Label lblCategory;
		private System.Windows.Forms.TextBox txtDatasheetURL;
		private System.Windows.Forms.Label lblDatasheetURL;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton tsbDistributorWebsite;
		private System.Windows.Forms.ToolStripButton tsbCheckDatabase;
	}
}

