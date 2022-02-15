namespace PartsCatalog.Browsers.Views {
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.stpStatus = new System.Windows.Forms.StatusStrip();
			this.tslServer = new System.Windows.Forms.ToolStripStatusLabel();
			this.stpMenu = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ctnMainSplit = new System.Windows.Forms.SplitContainer();
			this.cntParametricSplit = new System.Windows.Forms.SplitContainer();
			this.lstCategories = new System.Windows.Forms.ListBox();
			this.lblCategories = new System.Windows.Forms.Label();
			this.lstSubCategories = new System.Windows.Forms.ListBox();
			this.lblSubCategories = new System.Windows.Forms.Label();
			this.grdResults = new System.Windows.Forms.DataGridView();
			this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.categoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.packagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.projectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.stpStatus.SuspendLayout();
			this.stpMenu.SuspendLayout();
			this.ctnMainSplit.Panel1.SuspendLayout();
			this.ctnMainSplit.Panel2.SuspendLayout();
			this.ctnMainSplit.SuspendLayout();
			this.cntParametricSplit.Panel1.SuspendLayout();
			this.cntParametricSplit.Panel2.SuspendLayout();
			this.cntParametricSplit.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdResults)).BeginInit();
			this.SuspendLayout();
			// 
			// stpStatus
			// 
			this.stpStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslServer});
			this.stpStatus.Location = new System.Drawing.Point(0, 519);
			this.stpStatus.Name = "stpStatus";
			this.stpStatus.Size = new System.Drawing.Size(769, 22);
			this.stpStatus.TabIndex = 1;
			this.stpStatus.Text = "statusStrip1";
			// 
			// tslServer
			// 
			this.tslServer.Name = "tslServer";
			this.tslServer.Size = new System.Drawing.Size(74, 17);
			this.tslServer.Text = "Server Name";
			// 
			// stpMenu
			// 
			this.stpMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.manageToolStripMenuItem,
            this.searchToolStripMenuItem});
			this.stpMenu.Location = new System.Drawing.Point(0, 0);
			this.stpMenu.Name = "stpMenu";
			this.stpMenu.Size = new System.Drawing.Size(769, 24);
			this.stpMenu.TabIndex = 2;
			this.stpMenu.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// refreshToolStripMenuItem
			// 
			this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
			this.refreshToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
			this.refreshToolStripMenuItem.Text = "&Refresh";
			this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(110, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// ctnMainSplit
			// 
			this.ctnMainSplit.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ctnMainSplit.Location = new System.Drawing.Point(0, 24);
			this.ctnMainSplit.Name = "ctnMainSplit";
			// 
			// ctnMainSplit.Panel1
			// 
			this.ctnMainSplit.Panel1.Controls.Add(this.cntParametricSplit);
			this.ctnMainSplit.Panel1MinSize = 200;
			// 
			// ctnMainSplit.Panel2
			// 
			this.ctnMainSplit.Panel2.Controls.Add(this.grdResults);
			this.ctnMainSplit.Panel2MinSize = 100;
			this.ctnMainSplit.Size = new System.Drawing.Size(769, 495);
			this.ctnMainSplit.SplitterDistance = 225;
			this.ctnMainSplit.TabIndex = 3;
			// 
			// cntParametricSplit
			// 
			this.cntParametricSplit.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cntParametricSplit.Location = new System.Drawing.Point(0, 0);
			this.cntParametricSplit.Name = "cntParametricSplit";
			this.cntParametricSplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// cntParametricSplit.Panel1
			// 
			this.cntParametricSplit.Panel1.Controls.Add(this.lstCategories);
			this.cntParametricSplit.Panel1.Controls.Add(this.lblCategories);
			this.cntParametricSplit.Panel1MinSize = 120;
			// 
			// cntParametricSplit.Panel2
			// 
			this.cntParametricSplit.Panel2.Controls.Add(this.lstSubCategories);
			this.cntParametricSplit.Panel2.Controls.Add(this.lblSubCategories);
			this.cntParametricSplit.Panel2MinSize = 120;
			this.cntParametricSplit.Size = new System.Drawing.Size(225, 495);
			this.cntParametricSplit.SplitterDistance = 302;
			this.cntParametricSplit.TabIndex = 0;
			// 
			// lstCategories
			// 
			this.lstCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.lstCategories.FormattingEnabled = true;
			this.lstCategories.Location = new System.Drawing.Point(6, 16);
			this.lstCategories.Name = "lstCategories";
			this.lstCategories.Size = new System.Drawing.Size(216, 277);
			this.lstCategories.TabIndex = 1;
			this.lstCategories.SelectedIndexChanged += new System.EventHandler(this.lstCategories_SelectedIndexChanged);
			// 
			// lblCategories
			// 
			this.lblCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.lblCategories.Location = new System.Drawing.Point(6, 0);
			this.lblCategories.Name = "lblCategories";
			this.lblCategories.Size = new System.Drawing.Size(216, 13);
			this.lblCategories.TabIndex = 0;
			this.lblCategories.Text = "Categories";
			this.lblCategories.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lstSubCategories
			// 
			this.lstSubCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.lstSubCategories.FormattingEnabled = true;
			this.lstSubCategories.Location = new System.Drawing.Point(7, 16);
			this.lstSubCategories.Name = "lstSubCategories";
			this.lstSubCategories.Size = new System.Drawing.Size(216, 160);
			this.lstSubCategories.TabIndex = 3;
			this.lstSubCategories.SelectedIndexChanged += new System.EventHandler(this.lstSubCategories_SelectedIndexChanged);
			// 
			// lblSubCategories
			// 
			this.lblSubCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.lblSubCategories.Location = new System.Drawing.Point(3, 0);
			this.lblSubCategories.Name = "lblSubCategories";
			this.lblSubCategories.Size = new System.Drawing.Size(219, 13);
			this.lblSubCategories.TabIndex = 2;
			this.lblSubCategories.Text = "Sub-Categories";
			this.lblSubCategories.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// grdResults
			// 
			this.grdResults.AllowUserToAddRows = false;
			this.grdResults.AllowUserToDeleteRows = false;
			this.grdResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.grdResults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.grdResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.grdResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.grdResults.DefaultCellStyle = dataGridViewCellStyle2;
			this.grdResults.Location = new System.Drawing.Point(3, 3);
			this.grdResults.Name = "grdResults";
			this.grdResults.ReadOnly = true;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.grdResults.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.grdResults.RowHeadersVisible = false;
			this.grdResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdResults.Size = new System.Drawing.Size(534, 489);
			this.grdResults.TabIndex = 0;
			// 
			// manageToolStripMenuItem
			// 
			this.manageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriesToolStripMenuItem,
            this.packagesToolStripMenuItem,
            this.projectsToolStripMenuItem});
			this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
			this.manageToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
			this.manageToolStripMenuItem.Text = "&Manage";
			// 
			// searchToolStripMenuItem
			// 
			this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
			this.searchToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
			this.searchToolStripMenuItem.Text = "&Search...";
			this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
			// 
			// categoriesToolStripMenuItem
			// 
			this.categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
			this.categoriesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.categoriesToolStripMenuItem.Text = "&Categories...";
			this.categoriesToolStripMenuItem.Click += new System.EventHandler(this.categoriesToolStripMenuItem_Click);
			// 
			// packagesToolStripMenuItem
			// 
			this.packagesToolStripMenuItem.Name = "packagesToolStripMenuItem";
			this.packagesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.packagesToolStripMenuItem.Text = "Pac&kages...";
			this.packagesToolStripMenuItem.Click += new System.EventHandler(this.packagesToolStripMenuItem_Click);
			// 
			// projectsToolStripMenuItem
			// 
			this.projectsToolStripMenuItem.Name = "projectsToolStripMenuItem";
			this.projectsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.projectsToolStripMenuItem.Text = "&Projects...";
			this.projectsToolStripMenuItem.Click += new System.EventHandler(this.projectsToolStripMenuItem_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(769, 541);
			this.Controls.Add(this.ctnMainSplit);
			this.Controls.Add(this.stpStatus);
			this.Controls.Add(this.stpMenu);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "MainForm";
			this.Text = "PartsCatalog Browser";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.stpStatus.ResumeLayout(false);
			this.stpStatus.PerformLayout();
			this.stpMenu.ResumeLayout(false);
			this.stpMenu.PerformLayout();
			this.ctnMainSplit.Panel1.ResumeLayout(false);
			this.ctnMainSplit.Panel2.ResumeLayout(false);
			this.ctnMainSplit.ResumeLayout(false);
			this.cntParametricSplit.Panel1.ResumeLayout(false);
			this.cntParametricSplit.Panel2.ResumeLayout(false);
			this.cntParametricSplit.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grdResults)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip stpStatus;
		private System.Windows.Forms.MenuStrip stpMenu;
		private System.Windows.Forms.SplitContainer ctnMainSplit;
		private System.Windows.Forms.SplitContainer cntParametricSplit;
		private System.Windows.Forms.DataGridView grdResults;
		private System.Windows.Forms.ListBox lstCategories;
		private System.Windows.Forms.Label lblCategories;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ListBox lstSubCategories;
		private System.Windows.Forms.Label lblSubCategories;
		private System.Windows.Forms.ToolStripStatusLabel tslServer;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem categoriesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem packagesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem projectsToolStripMenuItem;

	}
}

