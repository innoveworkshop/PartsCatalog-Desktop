namespace PackageManager {
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
			this.lstPackages = new System.Windows.Forms.ListBox();
			this.picImage = new System.Windows.Forms.PictureBox();
			this.ctmImage = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.contextBrowseImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextDeleteImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lblName = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.lblID = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnRemove = new System.Windows.Forms.Button();
			this.btnRename = new System.Windows.Forms.Button();
			this.stpMenu = new System.Windows.Forms.MenuStrip();
			this.packageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addPackageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.renamePackageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.deletePackageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.browseImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.deleteImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dlgOpenImage = new System.Windows.Forms.OpenFileDialog();
			this.stpStatus = new System.Windows.Forms.StatusStrip();
			this.tslServer = new System.Windows.Forms.ToolStripStatusLabel();
			((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
			this.ctmImage.SuspendLayout();
			this.stpMenu.SuspendLayout();
			this.stpStatus.SuspendLayout();
			this.SuspendLayout();
			// 
			// lstPackages
			// 
			this.lstPackages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)));
			this.lstPackages.FormattingEnabled = true;
			this.lstPackages.Location = new System.Drawing.Point(9, 28);
			this.lstPackages.Name = "lstPackages";
			this.lstPackages.Size = new System.Drawing.Size(200, 355);
			this.lstPackages.TabIndex = 2;
			this.lstPackages.SelectedIndexChanged += new System.EventHandler(this.lstPackages_SelectedIndexChanged);
			// 
			// picImage
			// 
			this.picImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.picImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picImage.ContextMenuStrip = this.ctmImage;
			this.picImage.Location = new System.Drawing.Point(221, 183);
			this.picImage.Name = "picImage";
			this.picImage.Size = new System.Drawing.Size(200, 200);
			this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picImage.TabIndex = 3;
			this.picImage.TabStop = false;
			// 
			// ctmImage
			// 
			this.ctmImage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextBrowseImageToolStripMenuItem,
            this.contextDeleteImageToolStripMenuItem});
			this.ctmImage.Name = "ctmImage";
			this.ctmImage.Size = new System.Drawing.Size(122, 48);
			// 
			// contextBrowseImageToolStripMenuItem
			// 
			this.contextBrowseImageToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("contextBrowseImageToolStripMenuItem.Image")));
			this.contextBrowseImageToolStripMenuItem.Name = "contextBrowseImageToolStripMenuItem";
			this.contextBrowseImageToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
			this.contextBrowseImageToolStripMenuItem.Text = "Browse...";
			this.contextBrowseImageToolStripMenuItem.Click += new System.EventHandler(this.contextBrowseImageToolStripMenuItem_Click);
			// 
			// contextDeleteImageToolStripMenuItem
			// 
			this.contextDeleteImageToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("contextDeleteImageToolStripMenuItem.Image")));
			this.contextDeleteImageToolStripMenuItem.Name = "contextDeleteImageToolStripMenuItem";
			this.contextDeleteImageToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
			this.contextDeleteImageToolStripMenuItem.Text = "Delete";
			this.contextDeleteImageToolStripMenuItem.Click += new System.EventHandler(this.contextDeleteImageToolStripMenuItem_Click);
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(218, 28);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(35, 13);
			this.lblName.TabIndex = 4;
			this.lblName.Text = "Name";
			// 
			// txtName
			// 
			this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtName.Location = new System.Drawing.Point(221, 44);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(200, 20);
			this.txtName.TabIndex = 5;
			// 
			// lblID
			// 
			this.lblID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblID.Location = new System.Drawing.Point(364, 28);
			this.lblID.Name = "lblID";
			this.lblID.Size = new System.Drawing.Size(57, 13);
			this.lblID.TabIndex = 6;
			this.lblID.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.btnAdd.Location = new System.Drawing.Point(221, 99);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(200, 23);
			this.btnAdd.TabIndex = 9;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnRemove
			// 
			this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRemove.Location = new System.Drawing.Point(323, 70);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(98, 23);
			this.btnRemove.TabIndex = 8;
			this.btnRemove.Text = "Delete";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// btnRename
			// 
			this.btnRename.Location = new System.Drawing.Point(221, 70);
			this.btnRename.Name = "btnRename";
			this.btnRename.Size = new System.Drawing.Size(98, 23);
			this.btnRename.TabIndex = 7;
			this.btnRename.Text = "Rename";
			this.btnRename.UseVisualStyleBackColor = true;
			this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
			// 
			// stpMenu
			// 
			this.stpMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.packageToolStripMenuItem,
            this.imageToolStripMenuItem});
			this.stpMenu.Location = new System.Drawing.Point(0, 0);
			this.stpMenu.Name = "stpMenu";
			this.stpMenu.Size = new System.Drawing.Size(431, 24);
			this.stpMenu.TabIndex = 10;
			// 
			// packageToolStripMenuItem
			// 
			this.packageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPackageToolStripMenuItem,
            this.renamePackageToolStripMenuItem,
            this.toolStripMenuItem1,
            this.deletePackageToolStripMenuItem});
			this.packageToolStripMenuItem.Name = "packageToolStripMenuItem";
			this.packageToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
			this.packageToolStripMenuItem.Text = "Package";
			// 
			// addPackageToolStripMenuItem
			// 
			this.addPackageToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addPackageToolStripMenuItem.Image")));
			this.addPackageToolStripMenuItem.Name = "addPackageToolStripMenuItem";
			this.addPackageToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
			this.addPackageToolStripMenuItem.Text = "Add";
			// 
			// renamePackageToolStripMenuItem
			// 
			this.renamePackageToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("renamePackageToolStripMenuItem.Image")));
			this.renamePackageToolStripMenuItem.Name = "renamePackageToolStripMenuItem";
			this.renamePackageToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.renamePackageToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
			this.renamePackageToolStripMenuItem.Text = "Rename";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(155, 6);
			// 
			// deletePackageToolStripMenuItem
			// 
			this.deletePackageToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deletePackageToolStripMenuItem.Image")));
			this.deletePackageToolStripMenuItem.Name = "deletePackageToolStripMenuItem";
			this.deletePackageToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
			this.deletePackageToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
			this.deletePackageToolStripMenuItem.Text = "Delete";
			// 
			// imageToolStripMenuItem
			// 
			this.imageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.browseImageToolStripMenuItem,
            this.toolStripMenuItem2,
            this.deleteImageToolStripMenuItem});
			this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
			this.imageToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
			this.imageToolStripMenuItem.Text = "Image";
			// 
			// browseImageToolStripMenuItem
			// 
			this.browseImageToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("browseImageToolStripMenuItem.Image")));
			this.browseImageToolStripMenuItem.Name = "browseImageToolStripMenuItem";
			this.browseImageToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
			this.browseImageToolStripMenuItem.Text = "Browse...";
			this.browseImageToolStripMenuItem.Click += new System.EventHandler(this.browseImageToolStripMenuItem_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(118, 6);
			// 
			// deleteImageToolStripMenuItem
			// 
			this.deleteImageToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteImageToolStripMenuItem.Image")));
			this.deleteImageToolStripMenuItem.Name = "deleteImageToolStripMenuItem";
			this.deleteImageToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
			this.deleteImageToolStripMenuItem.Text = "Delete";
			this.deleteImageToolStripMenuItem.Click += new System.EventHandler(this.deleteImageToolStripMenuItem_Click);
			// 
			// dlgOpenImage
			// 
			this.dlgOpenImage.Filter = resources.GetString("dlgOpenImage.Filter");
			this.dlgOpenImage.Title = "Upload Package Image";
			// 
			// stpStatus
			// 
			this.stpStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslServer});
			this.stpStatus.Location = new System.Drawing.Point(0, 393);
			this.stpStatus.Name = "stpStatus";
			this.stpStatus.Size = new System.Drawing.Size(431, 22);
			this.stpStatus.TabIndex = 11;
			this.stpStatus.Text = "statusStrip1";
			// 
			// tslServer
			// 
			this.tslServer.Name = "tslServer";
			this.tslServer.Size = new System.Drawing.Size(74, 17);
			this.tslServer.Text = "Server Name";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(431, 415);
			this.Controls.Add(this.stpStatus);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.btnRename);
			this.Controls.Add(this.lblID);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.picImage);
			this.Controls.Add(this.lstPackages);
			this.Controls.Add(this.stpMenu);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.stpMenu;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "Component Package Manager";
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
			this.ctmImage.ResumeLayout(false);
			this.stpMenu.ResumeLayout(false);
			this.stpMenu.PerformLayout();
			this.stpStatus.ResumeLayout(false);
			this.stpStatus.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lstPackages;
		private System.Windows.Forms.PictureBox picImage;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label lblID;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnRemove;
		private System.Windows.Forms.Button btnRename;
		private System.Windows.Forms.MenuStrip stpMenu;
		private System.Windows.Forms.ToolStripMenuItem packageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addPackageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem renamePackageToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem deletePackageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem browseImageToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem deleteImageToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip ctmImage;
		private System.Windows.Forms.ToolStripMenuItem contextBrowseImageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem contextDeleteImageToolStripMenuItem;
		private System.Windows.Forms.OpenFileDialog dlgOpenImage;
		private System.Windows.Forms.StatusStrip stpStatus;
		private System.Windows.Forms.ToolStripStatusLabel tslServer;
	}
}

