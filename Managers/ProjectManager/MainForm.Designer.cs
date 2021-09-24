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
			this.label2 = new System.Windows.Forms.Label();
			this.lblProjectID = new System.Windows.Forms.Label();
			this.txtProjectName = new System.Windows.Forms.TextBox();
			this.txtProjectRevision = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtProjectDescription = new System.Windows.Forms.TextBox();
			this.btnProjectSave = new System.Windows.Forms.Button();
			this.btnProjectRemove = new System.Windows.Forms.Button();
			this.btnProjectAdd = new System.Windows.Forms.Button();
			this.grpComponents = new System.Windows.Forms.GroupBox();
			this.lstBOMItems = new System.Windows.Forms.ListBox();
			this.btnItemRemove = new System.Windows.Forms.Button();
			this.btnItemAdd = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.cmbComponent = new System.Windows.Forms.ComboBox();
			this.lblComponentDescription = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.lblComponentID = new System.Windows.Forms.Label();
			this.lstRefDes = new System.Windows.Forms.ListBox();
			this.txtRefDes = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.btnRefDesAdd = new System.Windows.Forms.Button();
			this.btnRefDesRename = new System.Windows.Forms.Button();
			this.btnRefDesRemove = new System.Windows.Forms.Button();
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
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Name";
			// 
			// lblProjectID
			// 
			this.lblProjectID.Location = new System.Drawing.Point(129, 16);
			this.lblProjectID.Name = "lblProjectID";
			this.lblProjectID.Size = new System.Drawing.Size(57, 13);
			this.lblProjectID.TabIndex = 3;
			this.lblProjectID.Text = "123";
			this.lblProjectID.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// txtProjectName
			// 
			this.txtProjectName.Location = new System.Drawing.Point(9, 32);
			this.txtProjectName.Name = "txtProjectName";
			this.txtProjectName.Size = new System.Drawing.Size(177, 20);
			this.txtProjectName.TabIndex = 4;
			// 
			// txtProjectRevision
			// 
			this.txtProjectRevision.Location = new System.Drawing.Point(192, 32);
			this.txtProjectRevision.Name = "txtProjectRevision";
			this.txtProjectRevision.Size = new System.Drawing.Size(29, 20);
			this.txtProjectRevision.TabIndex = 5;
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
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 55);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(60, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Description";
			// 
			// txtProjectDescription
			// 
			this.txtProjectDescription.Location = new System.Drawing.Point(9, 71);
			this.txtProjectDescription.Multiline = true;
			this.txtProjectDescription.Name = "txtProjectDescription";
			this.txtProjectDescription.Size = new System.Drawing.Size(212, 35);
			this.txtProjectDescription.TabIndex = 8;
			// 
			// btnProjectSave
			// 
			this.btnProjectSave.Location = new System.Drawing.Point(9, 112);
			this.btnProjectSave.Name = "btnProjectSave";
			this.btnProjectSave.Size = new System.Drawing.Size(102, 23);
			this.btnProjectSave.TabIndex = 9;
			this.btnProjectSave.Text = "Save";
			this.btnProjectSave.UseVisualStyleBackColor = true;
			// 
			// btnProjectRemove
			// 
			this.btnProjectRemove.Location = new System.Drawing.Point(119, 112);
			this.btnProjectRemove.Name = "btnProjectRemove";
			this.btnProjectRemove.Size = new System.Drawing.Size(102, 23);
			this.btnProjectRemove.TabIndex = 10;
			this.btnProjectRemove.Text = "Remove";
			this.btnProjectRemove.UseVisualStyleBackColor = true;
			// 
			// btnProjectAdd
			// 
			this.btnProjectAdd.Location = new System.Drawing.Point(9, 141);
			this.btnProjectAdd.Name = "btnProjectAdd";
			this.btnProjectAdd.Size = new System.Drawing.Size(212, 23);
			this.btnProjectAdd.TabIndex = 11;
			this.btnProjectAdd.Text = "Add";
			this.btnProjectAdd.UseVisualStyleBackColor = true;
			// 
			// grpComponents
			// 
			this.grpComponents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.grpComponents.Controls.Add(this.btnRefDesRemove);
			this.grpComponents.Controls.Add(this.btnRefDesRename);
			this.grpComponents.Controls.Add(this.btnRefDesAdd);
			this.grpComponents.Controls.Add(this.button1);
			this.grpComponents.Controls.Add(this.txtRefDes);
			this.grpComponents.Controls.Add(this.lstRefDes);
			this.grpComponents.Controls.Add(this.lblComponentID);
			this.grpComponents.Controls.Add(this.label6);
			this.grpComponents.Controls.Add(this.lblComponentDescription);
			this.grpComponents.Controls.Add(this.cmbComponent);
			this.grpComponents.Controls.Add(this.label5);
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
			// 
			// btnItemRemove
			// 
			this.btnItemRemove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.btnItemRemove.Location = new System.Drawing.Point(129, 392);
			this.btnItemRemove.Name = "btnItemRemove";
			this.btnItemRemove.Size = new System.Drawing.Size(112, 23);
			this.btnItemRemove.TabIndex = 12;
			this.btnItemRemove.Text = "Remove";
			this.btnItemRemove.UseVisualStyleBackColor = true;
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
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(244, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(61, 13);
			this.label5.TabIndex = 13;
			this.label5.Text = "Component";
			// 
			// cmbComponent
			// 
			this.cmbComponent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmbComponent.FormattingEnabled = true;
			this.cmbComponent.Location = new System.Drawing.Point(247, 32);
			this.cmbComponent.Name = "cmbComponent";
			this.cmbComponent.Size = new System.Drawing.Size(175, 21);
			this.cmbComponent.TabIndex = 14;
			// 
			// lblComponentDescription
			// 
			this.lblComponentDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblComponentDescription.Location = new System.Drawing.Point(244, 56);
			this.lblComponentDescription.Name = "lblComponentDescription";
			this.lblComponentDescription.Size = new System.Drawing.Size(178, 28);
			this.lblComponentDescription.TabIndex = 15;
			this.lblComponentDescription.Text = "Battery Holder thing";
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(244, 91);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(116, 13);
			this.label6.TabIndex = 16;
			this.label6.Text = "Reference Designators";
			// 
			// lblComponentID
			// 
			this.lblComponentID.Location = new System.Drawing.Point(368, 16);
			this.lblComponentID.Name = "lblComponentID";
			this.lblComponentID.Size = new System.Drawing.Size(57, 13);
			this.lblComponentID.TabIndex = 17;
			this.lblComponentID.Text = "123";
			this.lblComponentID.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lstRefDes
			// 
			this.lstRefDes.FormattingEnabled = true;
			this.lstRefDes.Location = new System.Drawing.Point(247, 107);
			this.lstRefDes.Name = "lstRefDes";
			this.lstRefDes.Size = new System.Drawing.Size(79, 277);
			this.lstRefDes.TabIndex = 18;
			// 
			// txtRefDes
			// 
			this.txtRefDes.Location = new System.Drawing.Point(332, 107);
			this.txtRefDes.Name = "txtRefDes";
			this.txtRefDes.Size = new System.Drawing.Size(90, 20);
			this.txtRefDes.TabIndex = 19;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Location = new System.Drawing.Point(247, 392);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(175, 23);
			this.button1.TabIndex = 20;
			this.button1.Text = "Remove";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// btnRefDesAdd
			// 
			this.btnRefDesAdd.Location = new System.Drawing.Point(332, 133);
			this.btnRefDesAdd.Name = "btnRefDesAdd";
			this.btnRefDesAdd.Size = new System.Drawing.Size(90, 23);
			this.btnRefDesAdd.TabIndex = 21;
			this.btnRefDesAdd.Text = "Add";
			this.btnRefDesAdd.UseVisualStyleBackColor = true;
			// 
			// btnRefDesRename
			// 
			this.btnRefDesRename.Location = new System.Drawing.Point(332, 162);
			this.btnRefDesRename.Name = "btnRefDesRename";
			this.btnRefDesRename.Size = new System.Drawing.Size(90, 23);
			this.btnRefDesRename.TabIndex = 22;
			this.btnRefDesRename.Text = "Rename";
			this.btnRefDesRename.UseVisualStyleBackColor = true;
			// 
			// btnRefDesRemove
			// 
			this.btnRefDesRemove.Location = new System.Drawing.Point(332, 191);
			this.btnRefDesRemove.Name = "btnRefDesRemove";
			this.btnRefDesRemove.Size = new System.Drawing.Size(90, 23);
			this.btnRefDesRemove.TabIndex = 23;
			this.btnRefDesRemove.Text = "Remove";
			this.btnRefDesRemove.UseVisualStyleBackColor = true;
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
		private System.Windows.Forms.ComboBox cmbComponent;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblComponentDescription;
		private System.Windows.Forms.Label lblComponentID;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ListBox lstRefDes;
		private System.Windows.Forms.Button btnRefDesRename;
		private System.Windows.Forms.Button btnRefDesAdd;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txtRefDes;
		private System.Windows.Forms.Button btnRefDesRemove;
	}
}

