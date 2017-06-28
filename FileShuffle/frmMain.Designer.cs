namespace FileShuffle
{
	partial class frmMain
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
			this.btnSelDir = new System.Windows.Forms.Button();
			this.txtPath = new System.Windows.Forms.TextBox();
			this.folderSel = new System.Windows.Forms.FolderBrowserDialog();
			this.btnShuffle = new System.Windows.Forms.Button();
			this.lblCount = new System.Windows.Forms.Label();
			this.txtPrefix = new System.Windows.Forms.TextBox();
			this.lblPrefix = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnSelDir
			// 
			this.btnSelDir.Location = new System.Drawing.Point(377, 19);
			this.btnSelDir.Margin = new System.Windows.Forms.Padding(2);
			this.btnSelDir.Name = "btnSelDir";
			this.btnSelDir.Size = new System.Drawing.Size(49, 20);
			this.btnSelDir.TabIndex = 0;
			this.btnSelDir.Text = "...";
			this.btnSelDir.UseVisualStyleBackColor = true;
			this.btnSelDir.Click += new System.EventHandler(this.btnSelDir_Click);
			// 
			// txtPath
			// 
			this.txtPath.Location = new System.Drawing.Point(20, 19);
			this.txtPath.Margin = new System.Windows.Forms.Padding(2);
			this.txtPath.Name = "txtPath";
			this.txtPath.Size = new System.Drawing.Size(346, 20);
			this.txtPath.TabIndex = 1;
			this.txtPath.Text = "G:\\Training\\mp3\\songs\\";
			// 
			// btnShuffle
			// 
			this.btnShuffle.Location = new System.Drawing.Point(430, 19);
			this.btnShuffle.Margin = new System.Windows.Forms.Padding(2);
			this.btnShuffle.Name = "btnShuffle";
			this.btnShuffle.Size = new System.Drawing.Size(45, 20);
			this.btnShuffle.TabIndex = 2;
			this.btnShuffle.Text = "Shffule";
			this.btnShuffle.UseVisualStyleBackColor = true;
			this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
			// 
			// lblCount
			// 
			this.lblCount.AutoSize = true;
			this.lblCount.Location = new System.Drawing.Point(17, 51);
			this.lblCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblCount.Name = "lblCount";
			this.lblCount.Size = new System.Drawing.Size(0, 13);
			this.lblCount.TabIndex = 3;
			// 
			// txtPrefix
			// 
			this.txtPrefix.Location = new System.Drawing.Point(377, 48);
			this.txtPrefix.Margin = new System.Windows.Forms.Padding(2);
			this.txtPrefix.Name = "txtPrefix";
			this.txtPrefix.Size = new System.Drawing.Size(43, 20);
			this.txtPrefix.TabIndex = 4;
			// 
			// lblPrefix
			// 
			this.lblPrefix.AutoSize = true;
			this.lblPrefix.Location = new System.Drawing.Point(337, 51);
			this.lblPrefix.Name = "lblPrefix";
			this.lblPrefix.Size = new System.Drawing.Size(36, 13);
			this.lblPrefix.TabIndex = 5;
			this.lblPrefix.Text = "Prefix:";
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(494, 96);
			this.Controls.Add(this.lblPrefix);
			this.Controls.Add(this.txtPrefix);
			this.Controls.Add(this.lblCount);
			this.Controls.Add(this.btnShuffle);
			this.Controls.Add(this.txtPath);
			this.Controls.Add(this.btnSelDir);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MaximizeBox = false;
			this.Name = "frmMain";
			this.Text = "FileShuffle";
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSelDir;
		private System.Windows.Forms.TextBox txtPath;
		private System.Windows.Forms.FolderBrowserDialog folderSel;
		private System.Windows.Forms.Button btnShuffle;
		private System.Windows.Forms.Label lblCount;
		private System.Windows.Forms.TextBox txtPrefix;
		private System.Windows.Forms.Label lblPrefix;
	}
}

