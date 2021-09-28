namespace ProjectManager {
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
			this.label1 = new System.Windows.Forms.Label();
			this.lstProjects = new System.Windows.Forms.ListBox();
			this.grpProject = new System.Windows.Forms.GroupBox();
			this.btnProjectAdd = new System.Windows.Forms.Button();
			this.btnProjectRemove = new System.Windows.Forms.Button();
			this.btnProjectSave = new System.Windows.Forms.Button();
			this.txtProjectDescription = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtProjectRevision = new System.Windows.Forms.TextBox();
			this.txtProjectName = new System.Windows.Forms.TextBox();
			this.lblProjectID = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.grpComponents = new System.Windows.Forms.GroupBox();
			this.chkComponentPopulate = new System.Windows.Forms.CheckBox();
			this.txtComponentValue = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnRefDesClear = new System.Windows.Forms.Button();
			this.btnSelectComponent = new System.Windows.Forms.Button();
			this.btnRefDesRemove = new System.Windows.Forms.Button();
			this.btnRefDesRename = new System.Windows.Forms.Button();
			this.btnRefDesAdd = new System.Windows.Forms.Button();
			this.btnItemSave = new System.Windows.Forms.Button();
			this.txtRefDes = new System.Windows.Forms.TextBox();
			this.lstRefDes = new System.Windows.Forms.ListBox();
			this.label6 = new System.Windows.Forms.Label();
			this.lblComponentDescription = new System.Windows.Forms.Label();
			this.lblComponentName = new System.Windows.Forms.Label();
			this.btnItemRemove = new System.Windows.Forms.Button();
			this.btnItemAdd = new System.Windows.Forms.Button();
			this.lstBOMItems = new System.Windows.Forms.ListBox();
			this.grpProject.SuspendLayout();
			this.grpComponents.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Projects";
			// 
			// lstProjects
			// 
			this.lstProjects.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)));
			this.lstProjects.FormattingEnabled = true;
			this.lstProjects.Location = new System.Drawing.Point(10, 25);
			this.lstProjects.Name = "lstProjects";
			this.lstProjects.Size = new System.Drawing.Size(231, 225);
			this.lstProjects.TabIndex = 1;
			this.lstProjects.SelectedIndexChanged += new System.EventHandler(this.lstProjects_SelectedIndexChanged);
			// 
			// grpProject
			// 
			this.grpProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.grpProject.Controls.Add(this.btnProjectAdd);
			this.grpProject.Controls.Add(this.btnProjectRemove);
			this.grpProject.Controls.Add(this.btnProjectSave);
			this.grpProject.Controls.Add(this.txtProjectDescription);
			this.grpProject.Controls.Add(this.label4);
			this.grpProject.Controls.Add(this.label3);
			this.grpProject.Controls.Add(this.txtProjectRevision);
			this.grpProject.Controls.Add(this.txtProjectName);
			this.grpProject.Controls.Add(this.lblProjectID);
			this.grpProject.Controls.Add(this.label2);
			this.grpProject.Location = new System.Drawing.Point(10, 260);
			this.grpProject.Name = "grpProject";
			this.grpProject.Size = new System.Drawing.Size(231, 175);
			this.grpProject.TabIndex = 2;
			this.grpProject.TabStop = false;
			this.grpProject.Text = "Project Information";
			// 
			// btnProjectAdd
			// 
			this.btnProjectAdd.Location = new System.Drawing.Point(9, 141);
			this.btnProjectAdd.Name = "btnProjectAdd";
			this.btnProjectAdd.Size = new System.Drawing.Size(212, 23);
			this.btnProjectAdd.TabIndex = 11;
			this.btnProjectAdd.Text = "Add";
			this.btnProjectAdd.UseVisualStyleBackColor = true;
			this.btnProjectAdd.Click += new System.EventHandler(this.btnProjectAdd_Click);
			// 
			// btnProjectRemove
			// 
			this.btnProjectRemove.Location = new System.Drawing.Point(119, 112);
			this.btnProjectRemove.Name = "btnProjectRemove";
			this.btnProjectRemove.Size = new System.Drawing.Size(102, 23);
			this.btnProjectRemove.TabIndex = 10;
			this.btnProjectRemove.Text = "Delete";
			this.btnProjectRemove.UseVisualStyleBackColor = true;
			this.btnProjectRemove.Click += new System.EventHandler(this.btnProjectRemove_Click);
			// 
			// btnProjectSave
			// 
			this.btnProjectSave.Location = new System.Drawing.Point(9, 112);
			this.btnProjectSave.Name = "btnProjectSave";
			this.btnProjectSave.Size = new System.Drawing.Size(102, 23);
			this.btnProjectSave.TabIndex = 9;
			this.btnProjectSave.Text = "Save";
			this.btnProjectSave.UseVisualStyleBackColor = true;
			this.btnProjectSave.Click += new System.EventHandler(this.btnProjectSave_Click);
			// 
			// txtProjectDescription
			// 
			this.txtProjectDescription.Location = new System.Drawing.Point(9, 71);
			this.txtProjectDescription.Multiline = true;
			this.txtProjectDescription.Name = "txtProjectDescription";
			this.txtProjectDescription.Size = new System.Drawing.Size(212, 35);
			this.txtProjectDescription.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 55);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(60, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Description";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(189, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(27, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Rev";
			// 
			// txtProjectRevision
			// 
			this.txtProjectRevision.Location = new System.Drawing.Point(192, 32);
			this.txtProjectRevision.Name = "txtProjectRevision";
			this.txtProjectRevision.Size = new System.Drawing.Size(29, 20);
			this.txtProjectRevision.TabIndex = 5;
			// 
			// txtProjectName
			// 
			this.txtProjectName.Location = new System.Drawing.Point(9, 32);
			this.txtProjectName.Name = "txtProjectName";
			this.txtProjectName.Size = new System.Drawing.Size(177, 20);
			this.txtProjectName.TabIndex = 4;
			// 
			// lblProjectID
			// 
			this.lblProjectID.Location = new System.Drawing.Point(129, 16);
			this.lblProjectID.Name = "lblProjectID";
			this.lblProjectID.Size = new System.Drawing.Size(57, 13);
			this.lblProjectID.TabIndex = 3;
			this.lblProjectID.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Name";
			// 
			// grpComponents
			// 
			this.grpComponents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.grpComponents.Controls.Add(this.chkComponentPopulate);
			this.grpComponents.Controls.Add(this.txtComponentValue);
			this.grpComponents.Controls.Add(this.label5);
			this.grpComponents.Controls.Add(this.btnRefDesClear);
			this.grpComponents.Controls.Add(this.btnSelectComponent);
			this.grpComponents.Controls.Add(this.btnRefDesRemove);
			this.grpComponents.Controls.Add(this.btnRefDesRename);
			this.grpComponents.Controls.Add(this.btnRefDesAdd);
			this.grpComponents.Controls.Add(this.btnItemSave);
			this.grpComponents.Controls.Add(this.txtRefDes);
			this.grpComponents.Controls.Add(this.lstRefDes);
			this.grpComponents.Controls.Add(this.label6);
			this.grpComponents.Controls.Add(this.lblComponentDescription);
			this.grpComponents.Controls.Add(this.lblComponentName);
			this.grpComponents.Controls.Add(this.btnItemRemove);
			this.grpComponents.Controls.Add(this.btnItemAdd);
			this.grpComponents.Controls.Add(this.lstBOMItems);
			this.grpComponents.Location = new System.Drawing.Point(250, 9);
			this.grpComponents.Name = "grpComponents";
			this.grpComponents.Size = new System.Drawing.Size(431, 426);
			this.grpComponents.TabIndex = 3;
			this.grpComponents.TabStop = false;
			this.grpComponents.Text = "Components";
			// 
			// chkComponentPopulate
			// 
			this.chkComponentPopulate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.chkComponentPopulate.AutoSize = true;
			this.chkComponentPopulate.Checked = true;
			this.chkComponentPopulate.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkComponentPopulate.Location = new System.Drawing.Point(343, 369);
			this.chkComponentPopulate.Name = "chkComponentPopulate";
			this.chkComponentPopulate.Size = new System.Drawing.Size(68, 17);
			this.chkComponentPopulate.TabIndex = 28;
			this.chkComponentPopulate.Text = "Populate";
			this.chkComponentPopulate.UseVisualStyleBackColor = true;
			// 
			// txtComponentValue
			// 
			this.txtComponentValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtComponentValue.Location = new System.Drawing.Point(247, 104);
			this.txtComponentValue.Name = "txtComponentValue";
			this.txtComponentValue.Size = new System.Drawing.Size(175, 20);
			this.txtComponentValue.TabIndex = 27;
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(244, 88);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(34, 13);
			this.label5.TabIndex = 26;
			this.label5.Text = "Value";
			// 
			// btnRefDesClear
			// 
			this.btnRefDesClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRefDesClear.Location = new System.Drawing.Point(332, 259);
			this.btnRefDesClear.Name = "btnRefDesClear";
			this.btnRefDesClear.Size = new System.Drawing.Size(90, 23);
			this.btnRefDesClear.TabIndex = 25;
			this.btnRefDesClear.Text = "Clear";
			this.btnRefDesClear.UseVisualStyleBackColor = true;
			this.btnRefDesClear.Click += new System.EventHandler(this.btnRefDesClear_Click);
			// 
			// btnSelectComponent
			// 
			this.btnSelectComponent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSelectComponent.Location = new System.Drawing.Point(247, 62);
			this.btnSelectComponent.Name = "btnSelectComponent";
			this.btnSelectComponent.Size = new System.Drawing.Size(175, 23);
			this.btnSelectComponent.TabIndex = 24;
			this.btnSelectComponent.Text = "Select Component";
			this.btnSelectComponent.UseVisualStyleBackColor = true;
			this.btnSelectComponent.Click += new System.EventHandler(this.btnSelectComponent_Click);
			// 
			// btnRefDesRemove
			// 
			this.btnRefDesRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRefDesRemove.Location = new System.Drawing.Point(332, 230);
			this.btnRefDesRemove.Name = "btnRefDesRemove";
			this.btnRefDesRemove.Size = new System.Drawing.Size(90, 23);
			this.btnRefDesRemove.TabIndex = 23;
			this.btnRefDesRemove.Text = "Delete";
			this.btnRefDesRemove.UseVisualStyleBackColor = true;
			this.btnRefDesRemove.Click += new System.EventHandler(this.btnRefDesRemove_Click);
			// 
			// btnRefDesRename
			// 
			this.btnRefDesRename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRefDesRename.Location = new System.Drawing.Point(332, 201);
			this.btnRefDesRename.Name = "btnRefDesRename";
			this.btnRefDesRename.Size = new System.Drawing.Size(90, 23);
			this.btnRefDesRename.TabIndex = 22;
			this.btnRefDesRename.Text = "Rename";
			this.btnRefDesRename.UseVisualStyleBackColor = true;
			this.btnRefDesRename.Click += new System.EventHandler(this.btnRefDesRename_Click);
			// 
			// btnRefDesAdd
			// 
			this.btnRefDesAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRefDesAdd.Location = new System.Drawing.Point(332, 172);
			this.btnRefDesAdd.Name = "btnRefDesAdd";
			this.btnRefDesAdd.Size = new System.Drawing.Size(90, 23);
			this.btnRefDesAdd.TabIndex = 21;
			this.btnRefDesAdd.Text = "Add";
			this.btnRefDesAdd.UseVisualStyleBackColor = true;
			this.btnRefDesAdd.Click += new System.EventHandler(this.btnRefDesAdd_Click);
			// 
			// btnItemSave
			// 
			this.btnItemSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnItemSave.Location = new System.Drawing.Point(247, 392);
			this.btnItemSave.Name = "btnItemSave";
			this.btnItemSave.Size = new System.Drawing.Size(175, 23);
			this.btnItemSave.TabIndex = 20;
			this.btnItemSave.Text = "Save";
			this.btnItemSave.UseVisualStyleBackColor = true;
			this.btnItemSave.Click += new System.EventHandler(this.btnItemSave_Click);
			// 
			// txtRefDes
			// 
			this.txtRefDes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtRefDes.Location = new System.Drawing.Point(332, 146);
			this.txtRefDes.Name = "txtRefDes";
			this.txtRefDes.Size = new System.Drawing.Size(90, 20);
			this.txtRefDes.TabIndex = 19;
			// 
			// lstRefDes
			// 
			this.lstRefDes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lstRefDes.FormattingEnabled = true;
			this.lstRefDes.Location = new System.Drawing.Point(247, 146);
			this.lstRefDes.Name = "lstRefDes";
			this.lstRefDes.Size = new System.Drawing.Size(79, 238);
			this.lstRefDes.Sorted = true;
			this.lstRefDes.TabIndex = 18;
			this.lstRefDes.SelectedIndexChanged += new System.EventHandler(this.lstRefDes_SelectedIndexChanged);
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(244, 130);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(116, 13);
			this.label6.TabIndex = 16;
			this.label6.Text = "Reference Designators";
			// 
			// lblComponentDescription
			// 
			this.lblComponentDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblComponentDescription.Location = new System.Drawing.Point(244, 31);
			this.lblComponentDescription.Name = "lblComponentDescription";
			this.lblComponentDescription.Size = new System.Drawing.Size(178, 28);
			this.lblComponentDescription.TabIndex = 15;
			this.lblComponentDescription.Text = "Battery Holder Thingy";
			// 
			// lblComponentName
			// 
			this.lblComponentName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblComponentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblComponentName.Location = new System.Drawing.Point(244, 16);
			this.lblComponentName.Name = "lblComponentName";
			this.lblComponentName.Size = new System.Drawing.Size(178, 15);
			this.lblComponentName.TabIndex = 13;
			this.lblComponentName.Text = "Component";
			// 
			// btnItemRemove
			// 
			this.btnItemRemove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.btnItemRemove.Location = new System.Drawing.Point(129, 392);
			this.btnItemRemove.Name = "btnItemRemove";
			this.btnItemRemove.Size = new System.Drawing.Size(112, 23);
			this.btnItemRemove.TabIndex = 12;
			this.btnItemRemove.Text = "Delete";
			this.btnItemRemove.UseVisualStyleBackColor = true;
			this.btnItemRemove.Click += new System.EventHandler(this.btnItemRemove_Click);
			// 
			// btnItemAdd
			// 
			this.btnItemAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.btnItemAdd.Location = new System.Drawing.Point(10, 392);
			this.btnItemAdd.Name = "btnItemAdd";
			this.btnItemAdd.Size = new System.Drawing.Size(112, 23);
			this.btnItemAdd.TabIndex = 11;
			this.btnItemAdd.Text = "Add";
			this.btnItemAdd.UseVisualStyleBackColor = true;
			this.btnItemAdd.Click += new System.EventHandler(this.btnItemAdd_Click);
			// 
			// lstBOMItems
			// 
			this.lstBOMItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.lstBOMItems.FormattingEnabled = true;
			this.lstBOMItems.Location = new System.Drawing.Point(10, 16);
			this.lstBOMItems.Name = "lstBOMItems";
			this.lstBOMItems.Size = new System.Drawing.Size(231, 368);
			this.lstBOMItems.TabIndex = 2;
			this.lstBOMItems.SelectedIndexChanged += new System.EventHandler(this.lstBOMItems_SelectedIndexChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(691, 443);
			this.Controls.Add(this.grpComponents);
			this.Controls.Add(this.grpProject);
			this.Controls.Add(this.lstProjects);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "Project Manager";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.grpProject.ResumeLayout(false);
			this.grpProject.PerformLayout();
			this.grpComponents.ResumeLayout(false);
			this.grpComponents.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox lstProjects;
		private System.Windows.Forms.GroupBox grpProject;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtProjectRevision;
		private System.Windows.Forms.TextBox txtProjectName;
		private System.Windows.Forms.Label lblProjectID;
		private System.Windows.Forms.TextBox txtProjectDescription;
		private System.Windows.Forms.Button btnProjectSave;
		private System.Windows.Forms.Button btnProjectRemove;
		private System.Windows.Forms.Button btnProjectAdd;
		private System.Windows.Forms.GroupBox grpComponents;
		private System.Windows.Forms.Button btnItemRemove;
		private System.Windows.Forms.Button btnItemAdd;
		private System.Windows.Forms.ListBox lstBOMItems;
		private System.Windows.Forms.Label lblComponentName;
		private System.Windows.Forms.Label lblComponentDescription;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ListBox lstRefDes;
		private System.Windows.Forms.Button btnRefDesRename;
		private System.Windows.Forms.Button btnRefDesAdd;
		private System.Windows.Forms.Button btnItemSave;
		private System.Windows.Forms.TextBox txtRefDes;
		private System.Windows.Forms.Button btnRefDesRemove;
		private System.Windows.Forms.Button btnSelectComponent;
		private System.Windows.Forms.Button btnRefDesClear;
		private System.Windows.Forms.TextBox txtComponentValue;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.CheckBox chkComponentPopulate;
	}
}

