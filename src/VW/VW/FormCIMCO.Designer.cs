namespace VW
{
	partial class FormCIMCO
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCIMCO));
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.buttonChoosePath = new System.Windows.Forms.Button();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeaderFileName = new System.Windows.Forms.ColumnHeader();
			this.columnHeaderCreateTime = new System.Windows.Forms.ColumnHeader();
			this.columnHeaderUpdateTime = new System.Windows.Forms.ColumnHeader();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.textBoxCADPath = new System.Windows.Forms.TextBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.button5 = new System.Windows.Forms.Button();
			this.buttonStartCIMCO = new System.Windows.Forms.Button();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.buttonChoosePath);
			this.groupBox2.Controls.Add(this.listView1);
			this.groupBox2.Controls.Add(this.textBoxCADPath);
			this.groupBox2.Location = new System.Drawing.Point(12, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(733, 474);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "文件信息";
			// 
			// buttonChoosePath
			// 
			this.buttonChoosePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonChoosePath.Location = new System.Drawing.Point(692, 21);
			this.buttonChoosePath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.buttonChoosePath.Name = "buttonChoosePath";
			this.buttonChoosePath.Size = new System.Drawing.Size(35, 27);
			this.buttonChoosePath.TabIndex = 10;
			this.buttonChoosePath.Text = "...";
			this.buttonChoosePath.UseVisualStyleBackColor = true;
			this.buttonChoosePath.Click += new System.EventHandler(this.buttonChoosePath_Click);
			// 
			// listView1
			// 
			this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderFileName,
            this.columnHeaderCreateTime,
            this.columnHeaderUpdateTime});
			this.listView1.LargeImageList = this.imageList1;
			this.listView1.Location = new System.Drawing.Point(6, 53);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(721, 415);
			this.listView1.SmallImageList = this.imageList1;
			this.listView1.TabIndex = 13;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
			// 
			// columnHeaderFileName
			// 
			this.columnHeaderFileName.Text = "文件名";
			this.columnHeaderFileName.Width = 254;
			// 
			// columnHeaderCreateTime
			// 
			this.columnHeaderCreateTime.DisplayIndex = 2;
			this.columnHeaderCreateTime.Text = "创建时间";
			this.columnHeaderCreateTime.Width = 115;
			// 
			// columnHeaderUpdateTime
			// 
			this.columnHeaderUpdateTime.DisplayIndex = 1;
			this.columnHeaderUpdateTime.Text = "修改时间";
			this.columnHeaderUpdateTime.Width = 110;
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "app.ico");
			this.imageList1.Images.SetKeyName(1, "folder.png");
			this.imageList1.Images.SetKeyName(2, "up.png");
			// 
			// textBoxCADPath
			// 
			this.textBoxCADPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxCADPath.Location = new System.Drawing.Point(6, 23);
			this.textBoxCADPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.textBoxCADPath.Name = "textBoxCADPath";
			this.textBoxCADPath.Size = new System.Drawing.Size(680, 23);
			this.textBoxCADPath.TabIndex = 9;
			this.textBoxCADPath.TextChanged += new System.EventHandler(this.textBoxCADPath_TextChanged);
			// 
			// groupBox3
			// 
			this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox3.Controls.Add(this.button5);
			this.groupBox3.Controls.Add(this.buttonStartCIMCO);
			this.groupBox3.Location = new System.Drawing.Point(751, 12);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(91, 474);
			this.groupBox3.TabIndex = 5;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "控制";
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(5, 62);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(85, 33);
			this.button5.TabIndex = 2;
			this.button5.Text = "返回主界面";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// buttonStartCIMCO
			// 
			this.buttonStartCIMCO.Location = new System.Drawing.Point(4, 21);
			this.buttonStartCIMCO.Name = "buttonStartCIMCO";
			this.buttonStartCIMCO.Size = new System.Drawing.Size(85, 35);
			this.buttonStartCIMCO.TabIndex = 0;
			this.buttonStartCIMCO.Text = "启用CIMCO";
			this.buttonStartCIMCO.UseVisualStyleBackColor = true;
			this.buttonStartCIMCO.Click += new System.EventHandler(this.buttonStartCIMCO_Click);
			// 
			// FormCIMCO
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(854, 490);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormCIMCO";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "刀路模拟";
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

		private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button buttonStartCIMCO;
        private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Button buttonChoosePath;
		private System.Windows.Forms.TextBox textBoxCADPath;
		private System.Windows.Forms.ColumnHeader columnHeaderFileName;
		private System.Windows.Forms.ColumnHeader columnHeaderCreateTime;
		private System.Windows.Forms.ColumnHeader columnHeaderUpdateTime;
		private System.Windows.Forms.ImageList imageList1;
    }
}