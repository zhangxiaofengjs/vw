namespace VW
{
	partial class FormTGHSTebis
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTGHSTebis));
			this.comboBoxBenchMark = new System.Windows.Forms.ComboBox();
			this.labelCADPath = new System.Windows.Forms.Label();
			this.groupBoxChooseFile = new System.Windows.Forms.GroupBox();
			this.buttonChoosePicturePath = new System.Windows.Forms.Button();
			this.buttonChooseCADPath = new System.Windows.Forms.Button();
			this.textBoxPicturePath = new System.Windows.Forms.TextBox();
			this.textBoxCADPath = new System.Windows.Forms.TextBox();
			this.labelPicturePath = new System.Windows.Forms.Label();
			this.groupBoxWorkInformation = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.labelProjectName = new System.Windows.Forms.Label();
			this.comboBoxSingleName = new System.Windows.Forms.ComboBox();
			this.labelBenchMark = new System.Windows.Forms.Label();
			this.comboBoxModuleName = new System.Windows.Forms.ComboBox();
			this.textBoxProjectName = new System.Windows.Forms.TextBox();
			this.comboBoxProcedure = new System.Windows.Forms.ComboBox();
			this.comboBoxPartName = new System.Windows.Forms.ComboBox();
			this.labelLeftRight = new System.Windows.Forms.Label();
			this.labelZhengFan = new System.Windows.Forms.Label();
			this.comboBoxLeftRight = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBoxSide = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.buttonExit = new System.Windows.Forms.Button();
			this.buttonExec = new System.Windows.Forms.Button();
			this.buttonClearInformation = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.textBoxMemo = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.textBoxTime = new System.Windows.Forms.TextBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.工具TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.CIMCOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.关于HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemabout = new System.Windows.Forms.ToolStripMenuItem();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabelTime = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
			this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabelVer = new System.Windows.Forms.ToolStripStatusLabel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBoxChooseFile.SuspendLayout();
			this.groupBoxWorkInformation.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// comboBoxBenchMark
			// 
			this.comboBoxBenchMark.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comboBoxBenchMark.FormattingEnabled = true;
			this.comboBoxBenchMark.Location = new System.Drawing.Point(76, 39);
			this.comboBoxBenchMark.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.comboBoxBenchMark.Name = "comboBoxBenchMark";
			this.comboBoxBenchMark.Size = new System.Drawing.Size(234, 25);
			this.comboBoxBenchMark.TabIndex = 0;
			// 
			// labelCADPath
			// 
			this.labelCADPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.labelCADPath.AutoSize = true;
			this.labelCADPath.Location = new System.Drawing.Point(7, 34);
			this.labelCADPath.Name = "labelCADPath";
			this.labelCADPath.Size = new System.Drawing.Size(57, 17);
			this.labelCADPath.TabIndex = 1;
			this.labelCADPath.Text = "CAD路径";
			// 
			// groupBoxChooseFile
			// 
			this.groupBoxChooseFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBoxChooseFile.Controls.Add(this.buttonChoosePicturePath);
			this.groupBoxChooseFile.Controls.Add(this.buttonChooseCADPath);
			this.groupBoxChooseFile.Controls.Add(this.textBoxPicturePath);
			this.groupBoxChooseFile.Controls.Add(this.textBoxCADPath);
			this.groupBoxChooseFile.Controls.Add(this.labelPicturePath);
			this.groupBoxChooseFile.Controls.Add(this.labelCADPath);
			this.groupBoxChooseFile.Location = new System.Drawing.Point(16, 74);
			this.groupBoxChooseFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.groupBoxChooseFile.Name = "groupBoxChooseFile";
			this.groupBoxChooseFile.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.groupBoxChooseFile.Size = new System.Drawing.Size(787, 103);
			this.groupBoxChooseFile.TabIndex = 3;
			this.groupBoxChooseFile.TabStop = false;
			this.groupBoxChooseFile.Text = "选取文件";
			// 
			// buttonChoosePicturePath
			// 
			this.buttonChoosePicturePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonChoosePicturePath.Location = new System.Drawing.Point(731, 63);
			this.buttonChoosePicturePath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.buttonChoosePicturePath.Name = "buttonChoosePicturePath";
			this.buttonChoosePicturePath.Size = new System.Drawing.Size(35, 27);
			this.buttonChoosePicturePath.TabIndex = 9;
			this.buttonChoosePicturePath.Text = "...";
			this.buttonChoosePicturePath.UseVisualStyleBackColor = true;
			this.buttonChoosePicturePath.Click += new System.EventHandler(this.buttonChoosePicturePath_Click);
			// 
			// buttonChooseCADPath
			// 
			this.buttonChooseCADPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonChooseCADPath.Location = new System.Drawing.Point(731, 29);
			this.buttonChooseCADPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.buttonChooseCADPath.Name = "buttonChooseCADPath";
			this.buttonChooseCADPath.Size = new System.Drawing.Size(35, 27);
			this.buttonChooseCADPath.TabIndex = 8;
			this.buttonChooseCADPath.Text = "...";
			this.buttonChooseCADPath.UseVisualStyleBackColor = true;
			this.buttonChooseCADPath.Click += new System.EventHandler(this.buttonChooseCADPath_Click);
			// 
			// textBoxPicturePath
			// 
			this.textBoxPicturePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxPicturePath.Location = new System.Drawing.Point(79, 65);
			this.textBoxPicturePath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.textBoxPicturePath.Name = "textBoxPicturePath";
			this.textBoxPicturePath.Size = new System.Drawing.Size(646, 23);
			this.textBoxPicturePath.TabIndex = 6;
			// 
			// textBoxCADPath
			// 
			this.textBoxCADPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxCADPath.Location = new System.Drawing.Point(79, 30);
			this.textBoxCADPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.textBoxCADPath.Name = "textBoxCADPath";
			this.textBoxCADPath.Size = new System.Drawing.Size(646, 23);
			this.textBoxCADPath.TabIndex = 4;
			// 
			// labelPicturePath
			// 
			this.labelPicturePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.labelPicturePath.AutoSize = true;
			this.labelPicturePath.Location = new System.Drawing.Point(7, 69);
			this.labelPicturePath.Name = "labelPicturePath";
			this.labelPicturePath.Size = new System.Drawing.Size(56, 17);
			this.labelPicturePath.TabIndex = 5;
			this.labelPicturePath.Text = "图片路径";
			// 
			// groupBoxWorkInformation
			// 
			this.groupBoxWorkInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBoxWorkInformation.Controls.Add(this.tableLayoutPanel1);
			this.groupBoxWorkInformation.Location = new System.Drawing.Point(16, 181);
			this.groupBoxWorkInformation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.groupBoxWorkInformation.Name = "groupBoxWorkInformation";
			this.groupBoxWorkInformation.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.groupBoxWorkInformation.Size = new System.Drawing.Size(632, 174);
			this.groupBoxWorkInformation.TabIndex = 4;
			this.groupBoxWorkInformation.TabStop = false;
			this.groupBoxWorkInformation.Text = "加工信息";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.labelProjectName, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.comboBoxSingleName, 3, 3);
			this.tableLayoutPanel1.Controls.Add(this.labelBenchMark, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.comboBoxModuleName, 3, 2);
			this.tableLayoutPanel1.Controls.Add(this.textBoxProjectName, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.comboBoxProcedure, 3, 1);
			this.tableLayoutPanel1.Controls.Add(this.comboBoxBenchMark, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.comboBoxPartName, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.labelLeftRight, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.labelZhengFan, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.comboBoxLeftRight, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.label2, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.comboBoxSide, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.label4, 2, 2);
			this.tableLayoutPanel1.Controls.Add(this.label5, 2, 3);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 20);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(626, 150);
			this.tableLayoutPanel1.TabIndex = 17;
			// 
			// labelProjectName
			// 
			this.labelProjectName.AutoSize = true;
			this.labelProjectName.Dock = System.Windows.Forms.DockStyle.Left;
			this.labelProjectName.Location = new System.Drawing.Point(3, 0);
			this.labelProjectName.Name = "labelProjectName";
			this.labelProjectName.Size = new System.Drawing.Size(56, 35);
			this.labelProjectName.TabIndex = 1;
			this.labelProjectName.Text = "项目名称";
			// 
			// comboBoxSingleName
			// 
			this.comboBoxSingleName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comboBoxSingleName.FormattingEnabled = true;
			this.comboBoxSingleName.Location = new System.Drawing.Point(388, 117);
			this.comboBoxSingleName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.comboBoxSingleName.Name = "comboBoxSingleName";
			this.comboBoxSingleName.Size = new System.Drawing.Size(235, 25);
			this.comboBoxSingleName.TabIndex = 16;
			// 
			// labelBenchMark
			// 
			this.labelBenchMark.AutoSize = true;
			this.labelBenchMark.Dock = System.Windows.Forms.DockStyle.Left;
			this.labelBenchMark.Location = new System.Drawing.Point(3, 35);
			this.labelBenchMark.Name = "labelBenchMark";
			this.labelBenchMark.Size = new System.Drawing.Size(32, 35);
			this.labelBenchMark.TabIndex = 2;
			this.labelBenchMark.Text = "基准";
			// 
			// comboBoxModuleName
			// 
			this.comboBoxModuleName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comboBoxModuleName.FormattingEnabled = true;
			this.comboBoxModuleName.Location = new System.Drawing.Point(388, 74);
			this.comboBoxModuleName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.comboBoxModuleName.Name = "comboBoxModuleName";
			this.comboBoxModuleName.Size = new System.Drawing.Size(235, 25);
			this.comboBoxModuleName.TabIndex = 15;
			// 
			// textBoxProjectName
			// 
			this.textBoxProjectName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxProjectName.Location = new System.Drawing.Point(76, 4);
			this.textBoxProjectName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.textBoxProjectName.Name = "textBoxProjectName";
			this.textBoxProjectName.Size = new System.Drawing.Size(234, 23);
			this.textBoxProjectName.TabIndex = 5;
			// 
			// comboBoxProcedure
			// 
			this.comboBoxProcedure.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comboBoxProcedure.FormattingEnabled = true;
			this.comboBoxProcedure.Location = new System.Drawing.Point(388, 39);
			this.comboBoxProcedure.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.comboBoxProcedure.Name = "comboBoxProcedure";
			this.comboBoxProcedure.Size = new System.Drawing.Size(235, 25);
			this.comboBoxProcedure.TabIndex = 14;
			// 
			// comboBoxPartName
			// 
			this.comboBoxPartName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comboBoxPartName.FormattingEnabled = true;
			this.comboBoxPartName.Location = new System.Drawing.Point(388, 4);
			this.comboBoxPartName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.comboBoxPartName.Name = "comboBoxPartName";
			this.comboBoxPartName.Size = new System.Drawing.Size(235, 25);
			this.comboBoxPartName.TabIndex = 13;
			// 
			// labelLeftRight
			// 
			this.labelLeftRight.AutoSize = true;
			this.labelLeftRight.Dock = System.Windows.Forms.DockStyle.Left;
			this.labelLeftRight.Location = new System.Drawing.Point(3, 70);
			this.labelLeftRight.Name = "labelLeftRight";
			this.labelLeftRight.Size = new System.Drawing.Size(44, 43);
			this.labelLeftRight.TabIndex = 3;
			this.labelLeftRight.Text = "左右件";
			// 
			// labelZhengFan
			// 
			this.labelZhengFan.AutoSize = true;
			this.labelZhengFan.Dock = System.Windows.Forms.DockStyle.Left;
			this.labelZhengFan.Location = new System.Drawing.Point(3, 113);
			this.labelZhengFan.Name = "labelZhengFan";
			this.labelZhengFan.Size = new System.Drawing.Size(44, 37);
			this.labelZhengFan.TabIndex = 4;
			this.labelZhengFan.Text = "正反面";
			// 
			// comboBoxLeftRight
			// 
			this.comboBoxLeftRight.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comboBoxLeftRight.FormattingEnabled = true;
			this.comboBoxLeftRight.Location = new System.Drawing.Point(76, 74);
			this.comboBoxLeftRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.comboBoxLeftRight.Name = "comboBoxLeftRight";
			this.comboBoxLeftRight.Size = new System.Drawing.Size(234, 25);
			this.comboBoxLeftRight.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Left;
			this.label2.Location = new System.Drawing.Point(316, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 35);
			this.label2.TabIndex = 10;
			this.label2.Text = "工序";
			// 
			// comboBoxSide
			// 
			this.comboBoxSide.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comboBoxSide.FormattingEnabled = true;
			this.comboBoxSide.Location = new System.Drawing.Point(76, 117);
			this.comboBoxSide.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.comboBoxSide.Name = "comboBoxSide";
			this.comboBoxSide.Size = new System.Drawing.Size(234, 25);
			this.comboBoxSide.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Left;
			this.label1.Location = new System.Drawing.Point(316, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 35);
			this.label1.TabIndex = 9;
			this.label1.Text = "零件名称";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Dock = System.Windows.Forms.DockStyle.Left;
			this.label4.Location = new System.Drawing.Point(316, 70);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(44, 43);
			this.label4.TabIndex = 11;
			this.label4.Text = "模具名";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Dock = System.Windows.Forms.DockStyle.Left;
			this.label5.Location = new System.Drawing.Point(316, 113);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(44, 37);
			this.label5.TabIndex = 12;
			this.label5.Text = "单件名";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label3.Location = new System.Drawing.Point(16, 29);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(787, 50);
			this.label3.TabIndex = 8;
			this.label3.Text = "TFHS   Tebis 程序单";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.buttonExit);
			this.groupBox1.Controls.Add(this.buttonExec);
			this.groupBox1.Controls.Add(this.buttonClearInformation);
			this.groupBox1.Location = new System.Drawing.Point(681, 181);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.groupBox1.Size = new System.Drawing.Size(120, 251);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "控制";
			// 
			// buttonExit
			// 
			this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonExit.Location = new System.Drawing.Point(14, 189);
			this.buttonExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(87, 44);
			this.buttonExit.TabIndex = 3;
			this.buttonExit.Text = "退出";
			this.buttonExit.UseVisualStyleBackColor = true;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// buttonExec
			// 
			this.buttonExec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonExec.Location = new System.Drawing.Point(14, 109);
			this.buttonExec.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.buttonExec.Name = "buttonExec";
			this.buttonExec.Size = new System.Drawing.Size(87, 46);
			this.buttonExec.TabIndex = 2;
			this.buttonExec.Text = "生成程序单";
			this.buttonExec.UseVisualStyleBackColor = true;
			this.buttonExec.Click += new System.EventHandler(this.buttonShengCheng_Click);
			// 
			// buttonClearInformation
			// 
			this.buttonClearInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonClearInformation.Location = new System.Drawing.Point(14, 32);
			this.buttonClearInformation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.buttonClearInformation.Name = "buttonClearInformation";
			this.buttonClearInformation.Size = new System.Drawing.Size(87, 47);
			this.buttonClearInformation.TabIndex = 1;
			this.buttonClearInformation.Text = "清空信息";
			this.buttonClearInformation.UseVisualStyleBackColor = true;
			this.buttonClearInformation.Click += new System.EventHandler(this.buttonClearInformation_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.tableLayoutPanel2);
			this.groupBox2.Location = new System.Drawing.Point(16, 360);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.groupBox2.Size = new System.Drawing.Size(632, 72);
			this.groupBox2.TabIndex = 10;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "时间管理";
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 4;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Controls.Add(this.textBoxMemo, 3, 0);
			this.tableLayoutPanel2.Controls.Add(this.label6, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.label8, 2, 0);
			this.tableLayoutPanel2.Controls.Add(this.textBoxTime, 1, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 20);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(626, 48);
			this.tableLayoutPanel2.TabIndex = 20;
			// 
			// textBoxMemo
			// 
			this.textBoxMemo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxMemo.Location = new System.Drawing.Point(389, 4);
			this.textBoxMemo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.textBoxMemo.Name = "textBoxMemo";
			this.textBoxMemo.Size = new System.Drawing.Size(234, 23);
			this.textBoxMemo.TabIndex = 19;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Dock = System.Windows.Forms.DockStyle.Left;
			this.label6.Location = new System.Drawing.Point(3, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(56, 48);
			this.label6.TabIndex = 0;
			this.label6.Text = "编程时长";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Dock = System.Windows.Forms.DockStyle.Left;
			this.label8.Location = new System.Drawing.Point(316, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(32, 48);
			this.label8.TabIndex = 18;
			this.label8.Text = "备注";
			// 
			// textBoxTime
			// 
			this.textBoxTime.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxTime.Location = new System.Drawing.Point(76, 4);
			this.textBoxTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.textBoxTime.Name = "textBoxTime";
			this.textBoxTime.Size = new System.Drawing.Size(234, 23);
			this.textBoxTime.TabIndex = 17;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.配置ToolStripMenuItem,
            this.工具TToolStripMenuItem,
            this.关于HToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(817, 26);
			this.menuStrip1.TabIndex = 12;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 配置ToolStripMenuItem
			// 
			this.配置ToolStripMenuItem.Name = "配置ToolStripMenuItem";
			this.配置ToolStripMenuItem.Size = new System.Drawing.Size(62, 22);
			this.配置ToolStripMenuItem.Text = "配置(&A)";
			this.配置ToolStripMenuItem.Click += new System.EventHandler(this.frmPeiZhiToolStripMenuItem_Click);
			// 
			// 工具TToolStripMenuItem
			// 
			this.工具TToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CIMCOToolStripMenuItem});
			this.工具TToolStripMenuItem.Name = "工具TToolStripMenuItem";
			this.工具TToolStripMenuItem.Size = new System.Drawing.Size(62, 22);
			this.工具TToolStripMenuItem.Text = "工具(&T)";
			// 
			// CIMCOToolStripMenuItem
			// 
			this.CIMCOToolStripMenuItem.Name = "CIMCOToolStripMenuItem";
			this.CIMCOToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
			this.CIMCOToolStripMenuItem.Text = "刀路模拟";
			this.CIMCOToolStripMenuItem.Click += new System.EventHandler(this.CIMCOToolStripMenuItem_Click);
			// 
			// 关于HToolStripMenuItem
			// 
			this.关于HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemabout});
			this.关于HToolStripMenuItem.Name = "关于HToolStripMenuItem";
			this.关于HToolStripMenuItem.Size = new System.Drawing.Size(63, 22);
			this.关于HToolStripMenuItem.Text = "关于(&H)";
			// 
			// toolStripMenuItemabout
			// 
			this.toolStripMenuItemabout.Name = "toolStripMenuItemabout";
			this.toolStripMenuItemabout.Size = new System.Drawing.Size(100, 22);
			this.toolStripMenuItemabout.Text = "关于";
			this.toolStripMenuItemabout.Click += new System.EventHandler(this.toolStripMenuItemabout_Click);
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelTime,
            this.toolStripProgressBar1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabelVer});
			this.statusStrip1.Location = new System.Drawing.Point(0, 438);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(817, 23);
			this.statusStrip1.TabIndex = 16;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabelTime
			// 
			this.toolStripStatusLabelTime.Name = "toolStripStatusLabelTime";
			this.toolStripStatusLabelTime.Size = new System.Drawing.Size(234, 18);
			this.toolStripStatusLabelTime.Text = "2016年11月17日15时20分6秒 周四 第3周";
			// 
			// toolStripProgressBar1
			// 
			this.toolStripProgressBar1.Name = "toolStripProgressBar1";
			this.toolStripProgressBar1.Size = new System.Drawing.Size(300, 17);
			this.toolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
			this.toolStripProgressBar1.Visible = false;
			// 
			// toolStripStatusLabel2
			// 
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new System.Drawing.Size(519, 18);
			this.toolStripStatusLabel2.Spring = true;
			// 
			// toolStripStatusLabelVer
			// 
			this.toolStripStatusLabelVer.IsLink = true;
			this.toolStripStatusLabelVer.Name = "toolStripStatusLabelVer";
			this.toolStripStatusLabelVer.Size = new System.Drawing.Size(49, 18);
			this.toolStripStatusLabelVer.Text = "ver 1.1";
			this.toolStripStatusLabelVer.Click += new System.EventHandler(this.toolStripMenuItemabout_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.White;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pictureBox1.Image = global::VW.Properties.Resources.logo;
			this.pictureBox1.Location = new System.Drawing.Point(681, 29);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(116, 50);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 15;
			this.pictureBox1.TabStop = false;
			// 
			// FormTGHSTebis
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(817, 461);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBoxWorkInformation);
			this.Controls.Add(this.groupBoxChooseFile);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label3);
			this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "FormTGHSTebis";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TFHS Tebis 程序单";
			this.groupBoxChooseFile.ResumeLayout(false);
			this.groupBoxChooseFile.PerformLayout();
			this.groupBoxWorkInformation.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxBenchMark;
        private System.Windows.Forms.Label labelCADPath;
        private System.Windows.Forms.GroupBox groupBoxChooseFile;
        private System.Windows.Forms.TextBox textBoxCADPath;
        private System.Windows.Forms.Label labelPicturePath;
        private System.Windows.Forms.TextBox textBoxPicturePath;
        private System.Windows.Forms.GroupBox groupBoxWorkInformation;
        private System.Windows.Forms.TextBox textBoxProjectName;
        private System.Windows.Forms.Label labelZhengFan;
        private System.Windows.Forms.Label labelLeftRight;
        private System.Windows.Forms.Label labelBenchMark;
        private System.Windows.Forms.Label labelProjectName;
        private System.Windows.Forms.ComboBox comboBoxSide;
        private System.Windows.Forms.ComboBox comboBoxLeftRight;
        private System.Windows.Forms.Button buttonChoosePicturePath;
        private System.Windows.Forms.Button buttonChooseCADPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSingleName;
        private System.Windows.Forms.ComboBox comboBoxModuleName;
        private System.Windows.Forms.ComboBox comboBoxProcedure;
        private System.Windows.Forms.ComboBox comboBoxPartName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonExec;
        private System.Windows.Forms.Button buttonClearInformation;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBoxMemo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 配置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具TToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ToolStripMenuItem CIMCOToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.ToolStripMenuItem 关于HToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemabout;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTime;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelVer;
		private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;

    }
}

