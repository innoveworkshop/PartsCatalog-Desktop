namespace CategoryManager {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.lblCategories = new System.Windows.Forms.Label();
			this.lstCategories = new System.Windows.Forms.ListBox();
			this.lblSubCategories = new System.Windows.Forms.Label();
			this.lstSubCategories = new System.Windows.Forms.ListBox();
			this.grpCategory = new System.Windows.Forms.GroupBox();
			this.txtCategory = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lblCategoryID = new System.Windows.Forms.Label();
			this.btnCategoryRename = new System.Windows.Forms.Button();
			this.btnCategoryRemove = new System.Windows.Forms.Button();
			this.btnCategoryAdd = new System.Windows.Forms.Button();
			this.grpSubCategory = new System.Windows.Forms.GroupBox();
			this.btnSubCategoryAdd = new System.Windows.Forms.Button();
			this.btnSubCategoryRemove = new System.Windows.Forms.Button();
			this.btnSubCategoryRename = new System.Windows.Forms.Button();
			this.lblSubCategoryID = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtSubCategory = new System.Windows.Forms.TextBox();
			this.grpCategory.SuspendLayout();
			this.grpSubCategory.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblCategories
			// 
			this.lblCategories.AutoSize = true;
			this.lblCategories.Location = new System.Drawing.Point(7, 9);
			this.lblCategories.Name = "lblCategories";
			this.lblCategories.Size = new System.Drawing.Size(49, 13);
			this.lblCategories.TabIndex = 0;
			this.lblCategories.Text = "Category";
			// 
			// lstCategories
			// 
			this.lstCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)));
			this.lstCategories.FormattingEnabled = true;
			this.lstCategories.Location = new System.Drawing.Point(10, 25);
			this.lstCategories.Name = "lstCategories";
			this.lstCategories.Size = new System.Drawing.Size(207, 329);
			this.lstCategories.TabIndex = 1;
			this.lstCategories.SelectedIndexChanged += new System.EventHandler(this.lstCategories_SelectedIndexChanged);
			// 
			// lblSubCategories
			// 
			this.lblSubCategories.AutoSize = true;
			this.lblSubCategories.Location = new System.Drawing.Point(227, 9);
			this.lblSubCategories.Name = "lblSubCategories";
			this.lblSubCategories.Size = new System.Drawing.Size(79, 13);
			this.lblSubCategories.TabIndex = 2;
			this.lblSubCategories.Text = "Sub-Categories";
			// 
			// lstSubCategories
			// 
			this.lstSubCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)));
			this.lstSubCategories.FormattingEnabled = true;
			this.lstSubCategories.Location = new System.Drawing.Point(230, 25);
			this.lstSubCategories.Name = "lstSubCategories";
			this.lstSubCategories.Size = new System.Drawing.Size(207, 329);
			this.lstSubCategories.TabIndex = 3;
			this.lstSubCategories.SelectedIndexChanged += new System.EventHandler(this.lstSubCategories_SelectedIndexChanged);
			// 
			// grpCategory
			// 
			this.grpCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.grpCategory.Controls.Add(this.btnCategoryAdd);
			this.grpCategory.Controls.Add(this.btnCategoryRemove);
			this.grpCategory.Controls.Add(this.btnCategoryRename);
			this.grpCategory.Controls.Add(this.lblCategoryID);
			this.grpCategory.Controls.Add(this.label1);
			this.grpCategory.Controls.Add(this.txtCategory);
			this.grpCategory.Location = new System.Drawing.Point(451, 25);
			this.grpCategory.Name = "grpCategory";
			this.grpCategory.Size = new System.Drawing.Size(220, 122);
			this.grpCategory.TabIndex = 4;
			this.grpCategory.TabStop = false;
			this.grpCategory.Text = "Category";
			// 
			// txtCategory
			// 
			this.txtCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtCategory.Location = new System.Drawing.Point(9, 32);
			this.txtCategory.Name = "txtCategory";
			this.txtCategory.Size = new System.Drawing.Size(202, 20);
			this.txtCategory.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Name";
			// 
			// lblCategoryID
			// 
			this.lblCategoryID.Location = new System.Drawing.Point(157, 16);
			this.lblCategoryID.Name = "lblCategoryID";
			this.lblCategoryID.Size = new System.Drawing.Size(57, 13);
			this.lblCategoryID.TabIndex = 2;
			this.lblCategoryID.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// btnCategoryRename
			// 
			this.btnCategoryRename.Location = new System.Drawing.Point(9, 58);
			this.btnCategoryRename.Name = "btnCategoryRename";
			this.btnCategoryRename.Size = new System.Drawing.Size(98, 23);
			this.btnCategoryRename.TabIndex = 3;
			this.btnCategoryRename.Text = "Rename";
			this.btnCategoryRename.UseVisualStyleBackColor = true;
			this.btnCategoryRename.Click += new System.EventHandler(this.btnCategoryRename_Click);
			// 
			// btnCategoryRemove
			// 
			this.btnCategoryRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCategoryRemove.Location = new System.Drawing.Point(113, 58);
			this.btnCategoryRemove.Name = "btnCategoryRemove";
			this.btnCategoryRemove.Size = new System.Drawing.Size(98, 23);
			this.btnCategoryRemove.TabIndex = 4;
			this.btnCategoryRemove.Text = "Remove";
			this.btnCategoryRemove.UseVisualStyleBackColor = true;
			this.btnCategoryRemove.Click += new System.EventHandler(this.btnCategoryRemove_Click);
			// 
			// btnCategoryAdd
			// 
			this.btnCategoryAdd.Location = new System.Drawing.Point(9, 87);
			this.btnCategoryAdd.Name = "btnCategoryAdd";
			this.btnCategoryAdd.Size = new System.Drawing.Size(202, 23);
			this.btnCategoryAdd.TabIndex = 5;
			this.btnCategoryAdd.Text = "Add";
			this.btnCategoryAdd.UseVisualStyleBackColor = true;
			this.btnCategoryAdd.Click += new System.EventHandler(this.btnCategoryAdd_Click);
			// 
			// grpSubCategory
			// 
			this.grpSubCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.grpSubCategory.Controls.Add(this.btnSubCategoryAdd);
			this.grpSubCategory.Controls.Add(this.btnSubCategoryRemove);
			this.grpSubCategory.Controls.Add(this.btnSubCategoryRename);
			this.grpSubCategory.Controls.Add(this.lblSubCategoryID);
			this.grpSubCategory.Controls.Add(this.label3);
			this.grpSubCategory.Controls.Add(this.txtSubCategory);
			this.grpSubCategory.Location = new System.Drawing.Point(451, 232);
			this.grpSubCategory.Name = "grpSubCategory";
			this.grpSubCategory.Size = new System.Drawing.Size(220, 122);
			this.grpSubCategory.TabIndex = 5;
			this.grpSubCategory.TabStop = false;
			this.grpSubCategory.Text = "Sub-Category";
			// 
			// btnSubCategoryAdd
			// 
			this.btnSubCategoryAdd.Location = new System.Drawing.Point(9, 87);
			this.btnSubCategoryAdd.Name = "btnSubCategoryAdd";
			this.btnSubCategoryAdd.Size = new System.Drawing.Size(202, 23);
			this.btnSubCategoryAdd.TabIndex = 5;
			this.btnSubCategoryAdd.Text = "Add";
			this.btnSubCategoryAdd.UseVisualStyleBackColor = true;
			this.btnSubCategoryAdd.Click += new System.EventHandler(this.btnSubCategoryAdd_Click);
			// 
			// btnSubCategoryRemove
			// 
			this.btnSubCategoryRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSubCategoryRemove.Location = new System.Drawing.Point(113, 58);
			this.btnSubCategoryRemove.Name = "btnSubCategoryRemove";
			this.btnSubCategoryRemove.Size = new System.Drawing.Size(98, 23);
			this.btnSubCategoryRemove.TabIndex = 4;
			this.btnSubCategoryRemove.Text = "Remove";
			this.btnSubCategoryRemove.UseVisualStyleBackColor = true;
			this.btnSubCategoryRemove.Click += new System.EventHandler(this.btnSubCategoryRemove_Click);
			// 
			// btnSubCategoryRename
			// 
			this.btnSubCategoryRename.Location = new System.Drawing.Point(9, 58);
			this.btnSubCategoryRename.Name = "btnSubCategoryRename";
			this.btnSubCategoryRename.Size = new System.Drawing.Size(98, 23);
			this.btnSubCategoryRename.TabIndex = 3;
			this.btnSubCategoryRename.Text = "Rename";
			this.btnSubCategoryRename.UseVisualStyleBackColor = true;
			this.btnSubCategoryRename.Click += new System.EventHandler(this.btnSubCategoryRename_Click);
			// 
			// lblSubCategoryID
			// 
			this.lblSubCategoryID.Location = new System.Drawing.Point(157, 16);
			this.lblSubCategoryID.Name = "lblSubCategoryID";
			this.lblSubCategoryID.Size = new System.Drawing.Size(57, 13);
			this.lblSubCategoryID.TabIndex = 2;
			this.lblSubCategoryID.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "Name";
			// 
			// txtSubCategory
			// 
			this.txtSubCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtSubCategory.Location = new System.Drawing.Point(9, 32);
			this.txtSubCategory.Name = "txtSubCategory";
			this.txtSubCategory.Size = new System.Drawing.Size(202, 20);
			this.txtSubCategory.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(681, 364);
			this.Controls.Add(this.grpSubCategory);
			this.Controls.Add(this.grpCategory);
			this.Controls.Add(this.lstSubCategories);
			this.Controls.Add(this.lblSubCategories);
			this.Controls.Add(this.lstCategories);
			this.Controls.Add(this.lblCategories);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "Category Manager";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.grpCategory.ResumeLayout(false);
			this.grpCategory.PerformLayout();
			this.grpSubCategory.ResumeLayout(false);
			this.grpSubCategory.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblCategories;
		private System.Windows.Forms.ListBox lstCategories;
		private System.Windows.Forms.Label lblSubCategories;
		private System.Windows.Forms.ListBox lstSubCategories;
		private System.Windows.Forms.GroupBox grpCategory;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtCategory;
		private System.Windows.Forms.Label lblCategoryID;
		private System.Windows.Forms.Button btnCategoryAdd;
		private System.Windows.Forms.Button btnCategoryRemove;
		private System.Windows.Forms.Button btnCategoryRename;
		private System.Windows.Forms.GroupBox grpSubCategory;
		private System.Windows.Forms.Button btnSubCategoryAdd;
		private System.Windows.Forms.Button btnSubCategoryRemove;
		private System.Windows.Forms.Button btnSubCategoryRename;
		private System.Windows.Forms.Label lblSubCategoryID;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtSubCategory;
	}
}

