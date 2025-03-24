namespace SourceData
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnSynchronize = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtLastName = new System.Windows.Forms.TextBox();
			this.txtFirstName = new System.Windows.Forms.TextBox();
			this.numId = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.hintLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lstContacts = new System.Windows.Forms.ListView();
			this.clmId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.clmFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.clmLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.clmEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.clmIsSent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numId)).BeginInit();
			this.statusStrip.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnSynchronize);
			this.panel1.Controls.Add(this.btnAdd);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.txtEmail);
			this.panel1.Controls.Add(this.txtLastName);
			this.panel1.Controls.Add(this.txtFirstName);
			this.panel1.Controls.Add(this.numId);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(856, 136);
			this.panel1.TabIndex = 0;
			// 
			// btnSynchronize
			// 
			this.btnSynchronize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSynchronize.Location = new System.Drawing.Point(672, 67);
			this.btnSynchronize.Name = "btnSynchronize";
			this.btnSynchronize.Size = new System.Drawing.Size(172, 46);
			this.btnSynchronize.TabIndex = 9;
			this.btnSynchronize.Text = "Synchronize";
			this.btnSynchronize.UseVisualStyleBackColor = true;
			this.btnSynchronize.Click += new System.EventHandler(this.btnSynchronize_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAdd.Location = new System.Drawing.Point(672, 12);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(172, 46);
			this.btnAdd.TabIndex = 8;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(79, 93);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(32, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Email";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(55, 67);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Last name";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(56, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "First name";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// txtEmail
			// 
			this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtEmail.Location = new System.Drawing.Point(117, 90);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(546, 20);
			this.txtEmail.TabIndex = 4;
			// 
			// txtLastName
			// 
			this.txtLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtLastName.Location = new System.Drawing.Point(117, 64);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.Size = new System.Drawing.Size(546, 20);
			this.txtLastName.TabIndex = 3;
			// 
			// txtFirstName
			// 
			this.txtFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtFirstName.Location = new System.Drawing.Point(117, 38);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.Size = new System.Drawing.Size(546, 20);
			this.txtFirstName.TabIndex = 2;
			// 
			// numId
			// 
			this.numId.Enabled = false;
			this.numId.InterceptArrowKeys = false;
			this.numId.Location = new System.Drawing.Point(117, 12);
			this.numId.Name = "numId";
			this.numId.Size = new System.Drawing.Size(58, 20);
			this.numId.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(95, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(16, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Id";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// timer
			// 
			this.timer.Enabled = true;
			this.timer.Interval = 3600000;
			this.timer.Tick += new System.EventHandler(this.btnSynchronize_Click);
			// 
			// statusStrip
			// 
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hintLabel});
			this.statusStrip.Location = new System.Drawing.Point(0, 526);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
			this.statusStrip.Size = new System.Drawing.Size(856, 22);
			this.statusStrip.TabIndex = 2;
			this.statusStrip.Text = "Synchronization";
			// 
			// hintLabel
			// 
			this.hintLabel.Name = "hintLabel";
			this.hintLabel.Size = new System.Drawing.Size(0, 17);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.lstContacts);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 136);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(856, 390);
			this.panel2.TabIndex = 3;
			// 
			// lstContacts
			// 
			this.lstContacts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmId,
            this.clmFirstName,
            this.clmLastName,
            this.clmEmail,
            this.clmIsSent});
			this.lstContacts.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lstContacts.HideSelection = false;
			this.lstContacts.Location = new System.Drawing.Point(0, 0);
			this.lstContacts.Name = "lstContacts";
			this.lstContacts.Size = new System.Drawing.Size(856, 390);
			this.lstContacts.TabIndex = 0;
			this.lstContacts.UseCompatibleStateImageBehavior = false;
			this.lstContacts.View = System.Windows.Forms.View.Details;
			// 
			// clmId
			// 
			this.clmId.Text = "Id";
			this.clmId.Width = 30;
			// 
			// clmFirstName
			// 
			this.clmFirstName.Text = "First name";
			this.clmFirstName.Width = 200;
			// 
			// clmLastName
			// 
			this.clmLastName.Text = "Last name";
			this.clmLastName.Width = 200;
			// 
			// clmEmail
			// 
			this.clmEmail.Text = "Email";
			this.clmEmail.Width = 200;
			// 
			// clmIsSent
			// 
			this.clmIsSent.Text = "Sent";
			// 
			// Form1
			// 
			this.AcceptButton = this.btnAdd;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(856, 548);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.panel1);
			this.MinimumSize = new System.Drawing.Size(726, 483);
			this.Name = "Form1";
			this.Text = "Address Book";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numId)).EndInit();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.NumericUpDown numId;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtFirstName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtLastName;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnSynchronize;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel hintLabel;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ListView lstContacts;
		private System.Windows.Forms.ColumnHeader clmId;
		private System.Windows.Forms.ColumnHeader clmFirstName;
		private System.Windows.Forms.ColumnHeader clmLastName;
		private System.Windows.Forms.ColumnHeader clmEmail;
		private System.Windows.Forms.ColumnHeader clmIsSent;
	}
}

