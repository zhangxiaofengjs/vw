namespace VW
{
	partial class FormAbout
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.buttonOK = new System.Windows.Forms.Button();
			this.labelVer = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Image = global::VW.Properties.Resources.logo;
			this.pictureBox1.Location = new System.Drawing.Point(14, 17);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(226, 105);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 16;
			this.pictureBox1.TabStop = false;
			// 
			// buttonOK
			// 
			this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonOK.Location = new System.Drawing.Point(333, 102);
			this.buttonOK.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 26);
			this.buttonOK.TabIndex = 18;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// labelVer
			// 
			this.labelVer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.labelVer.AutoSize = true;
			this.labelVer.ForeColor = System.Drawing.Color.Blue;
			this.labelVer.Location = new System.Drawing.Point(246, 17);
			this.labelVer.Name = "labelVer";
			this.labelVer.Size = new System.Drawing.Size(117, 17);
			this.labelVer.TabIndex = 17;
			this.labelVer.Text = "ver 1.0 2017/02/14";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.DarkMagenta;
			this.label2.Location = new System.Drawing.Point(246, 38);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(163, 34);
			this.label2.TabIndex = 17;
			this.label2.Text = "zhangxiaofengjs@163.com\r\nzhangtl_nt@sina.com";
			// 
			// FormAbout
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(412, 135);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.labelVer);
			this.Controls.Add(this.pictureBox1);
			this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormAbout";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "FormAbout";
			this.Load += new System.EventHandler(this.FormAbout_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Label labelVer;
		private System.Windows.Forms.Label label2;
	}
}