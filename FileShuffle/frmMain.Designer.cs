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
			this.SuspendLayout();
			// 
			// btnSelDir
			// 
			this.btnSelDir.Location = new System.Drawing.Point(503, 23);
			this.btnSelDir.Name = "btnSelDir";
			this.btnSelDir.Size = new System.Drawing.Size(65, 24);
			this.btnSelDir.TabIndex = 0;
			this.btnSelDir.Text = "...";
			this.btnSelDir.UseVisualStyleBackColor = true;
			this.btnSelDir.Click += new System.EventHandler(this.btnSelDir_Click);
			// 
			// txtPath
			// 
			this.txtPath.Location = new System.Drawing.Point(26, 23);
			this.txtPath.Name = "txtPath";
			this.txtPath.Size = new System.Drawing.Size(460, 22);
			this.txtPath.TabIndex = 1;
			this.txtPath.Text = "D:\\TMPFolder\\";
			// 
			// btnShuffle
			// 
			this.btnShuffle.Location = new System.Drawing.Point(574, 23);
			this.btnShuffle.Name = "btnShuffle";
			this.btnShuffle.Size = new System.Drawing.Size(60, 24);
			this.btnShuffle.TabIndex = 2;
			this.btnShuffle.Text = "Shffule";
			this.btnShuffle.UseVisualStyleBackColor = true;
			this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(658, 118);
			this.Controls.Add(this.btnShuffle);
			this.Controls.Add(this.txtPath);
			this.Controls.Add(this.btnSelDir);
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
	}
}

