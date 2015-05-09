partial class FrmPersonUpdateSalary
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
			this.label1 = new System.Windows.Forms.Label();
			this.mLblName = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.mTxtSalary = new System.Windows.Forms.TextBox();
			this.mCmdRevert = new System.Windows.Forms.Button();
			this.mCmdUpdate = new System.Windows.Forms.Button();
			this.mCmdCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(21, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Person Name :";
			// 
			// mLblName
			// 
			this.mLblName.AutoSize = true;
			this.mLblName.Location = new System.Drawing.Point(127, 22);
			this.mLblName.Name = "mLblName";
			this.mLblName.Size = new System.Drawing.Size(95, 13);
			this.mLblName.TabIndex = 1;
			this.mLblName.Text = "JOHN DOE HERE";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(25, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Person Salary:";
			// 
			// mTxtSalary
			// 
			this.mTxtSalary.Location = new System.Drawing.Point(132, 44);
			this.mTxtSalary.Name = "mTxtSalary";
			this.mTxtSalary.Size = new System.Drawing.Size(89, 20);
			this.mTxtSalary.TabIndex = 3;
			this.mTxtSalary.Text = "1000.00";
			this.mTxtSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// mCmdRevert
			// 
			this.mCmdRevert.Location = new System.Drawing.Point(38, 85);
			this.mCmdRevert.Name = "mCmdRevert";
			this.mCmdRevert.Size = new System.Drawing.Size(78, 27);
			this.mCmdRevert.TabIndex = 4;
			this.mCmdRevert.Text = "Revert";
			this.mCmdRevert.UseVisualStyleBackColor = true;
			this.mCmdRevert.Click += new System.EventHandler(this.mCmdRevert_Click);
			// 
			// mCmdUpdate
			// 
			this.mCmdUpdate.Location = new System.Drawing.Point(132, 85);
			this.mCmdUpdate.Name = "mCmdUpdate";
			this.mCmdUpdate.Size = new System.Drawing.Size(78, 27);
			this.mCmdUpdate.TabIndex = 5;
			this.mCmdUpdate.Text = "Update";
			this.mCmdUpdate.UseVisualStyleBackColor = true;
			this.mCmdUpdate.Click += new System.EventHandler(this.mCmdUpdate_Click);
			// 
			// mCmdCancel
			// 
			this.mCmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.mCmdCancel.Location = new System.Drawing.Point(228, 85);
			this.mCmdCancel.Name = "mCmdCancel";
			this.mCmdCancel.Size = new System.Drawing.Size(78, 27);
			this.mCmdCancel.TabIndex = 6;
			this.mCmdCancel.Text = "Cancel";
			this.mCmdCancel.UseVisualStyleBackColor = true;
			this.mCmdCancel.Click += new System.EventHandler(this.mCmdCancel_Click);
			// 
			// FrmPersonUpdateSalary
			// 
			this.AcceptButton = this.mCmdUpdate;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.mCmdCancel;
			this.ClientSize = new System.Drawing.Size(329, 134);
			this.Controls.Add(this.mCmdCancel);
			this.Controls.Add(this.mCmdUpdate);
			this.Controls.Add(this.mCmdRevert);
			this.Controls.Add(this.mTxtSalary);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.mLblName);
			this.Controls.Add(this.label1);
			this.Name = "FrmPersonUpdateSalary";
			this.Text = "FrmPersonUpdateSalary";
			this.Load += new System.EventHandler(this.FrmPersonUpdateSalary_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label mLblName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox mTxtSalary;
		private System.Windows.Forms.Button mCmdRevert;
		private System.Windows.Forms.Button mCmdUpdate;
		private System.Windows.Forms.Button mCmdCancel;
	}