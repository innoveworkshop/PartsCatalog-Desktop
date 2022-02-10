namespace Browser.Views {
	partial class MainForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.MainMenu mnuMain;

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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.mnuMain = new System.Windows.Forms.MainMenu();
			this.cmbCategories = new System.Windows.Forms.ComboBox();
			this.cmbSubCategories = new System.Windows.Forms.ComboBox();
			this.lblCategory = new System.Windows.Forms.Label();
			this.lblSubCategory = new System.Windows.Forms.Label();
			this.grdResults = new System.Windows.Forms.DataGrid();
			this.SuspendLayout();
			// 
			// cmbCategories
			// 
			this.cmbCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.cmbCategories.Location = new System.Drawing.Point(64, 3);
			this.cmbCategories.Name = "cmbCategories";
			this.cmbCategories.Size = new System.Drawing.Size(173, 22);
			this.cmbCategories.TabIndex = 0;
			this.cmbCategories.SelectedValueChanged += new System.EventHandler(this.cmbCategories_SelectedValueChanged);
			// 
			// cmbSubCategories
			// 
			this.cmbSubCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.cmbSubCategories.Location = new System.Drawing.Point(87, 31);
			this.cmbSubCategories.Name = "cmbSubCategories";
			this.cmbSubCategories.Size = new System.Drawing.Size(150, 22);
			this.cmbSubCategories.TabIndex = 1;
			this.cmbSubCategories.SelectedValueChanged += new System.EventHandler(this.cmbSubCategories_SelectedValueChanged);
			// 
			// lblCategory
			// 
			this.lblCategory.Location = new System.Drawing.Point(3, 5);
			this.lblCategory.Name = "lblCategory";
			this.lblCategory.Size = new System.Drawing.Size(55, 20);
			this.lblCategory.Text = "Category";
			// 
			// lblSubCategory
			// 
			this.lblSubCategory.Location = new System.Drawing.Point(3, 33);
			this.lblSubCategory.Name = "lblSubCategory";
			this.lblSubCategory.Size = new System.Drawing.Size(78, 20);
			this.lblSubCategory.Text = "Sub-Category";
			// 
			// grdResults
			// 
			this.grdResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.grdResults.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.grdResults.Location = new System.Drawing.Point(3, 59);
			this.grdResults.Name = "grdResults";
			this.grdResults.Size = new System.Drawing.Size(234, 206);
			this.grdResults.TabIndex = 5;
			this.grdResults.DoubleClick += new System.EventHandler(this.grdResults_DoubleClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(240, 268);
			this.Controls.Add(this.grdResults);
			this.Controls.Add(this.lblSubCategory);
			this.Controls.Add(this.lblCategory);
			this.Controls.Add(this.cmbSubCategories);
			this.Controls.Add(this.cmbCategories);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Menu = this.mnuMain;
			this.Name = "MainForm";
			this.Text = "Parts Catalog";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox cmbCategories;
		private System.Windows.Forms.ComboBox cmbSubCategories;
		private System.Windows.Forms.Label lblCategory;
		private System.Windows.Forms.Label lblSubCategory;
        private System.Windows.Forms.DataGrid grdResults;
	}
}

