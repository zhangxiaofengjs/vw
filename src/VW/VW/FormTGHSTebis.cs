using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.Office.Interop.Excel;
using System.Diagnostics;
using System.Reflection;
namespace VW
{
    public partial class FormTGHSTebis : Form
    {
		public FormTGHSTebis()
        {
            InitializeComponent();

			Init();
        }

		private void Init()
		{
			VWConf vwConf = VWConf.Instance;

			LoadComboBox(comboBoxPartName, vwConf.PartsNameList);
			LoadComboBox(comboBoxBenchMark, vwConf.StandardList);
			LoadComboBox(comboBoxProcedure, vwConf.ProcedureList);
			LoadComboBox(comboBoxLeftRight, vwConf.LfPartsList);
			LoadComboBox(comboBoxModuleName, vwConf.MoldNameList);
			LoadComboBox(comboBoxSide, vwConf.SideList);
			LoadComboBox(comboBoxSingleName, vwConf.SingleNameList);

			toolStripStatusLabelVer.Text = VWConf.Version;
		}

		private void LoadComboBox(ComboBox cbBox, List<string> list)
		{
			if (list.Count != 0)
			{
				cbBox.Items.AddRange(list.ToArray());
				cbBox.SelectedIndex = 0;
			}
		}

        private void timer1_Tick(object sender, EventArgs e)
        {
			toolStripStatusLabelTime.Text = VWUtil.Now;
        }

		private void buttonChooseCADPath_Click(object sender, EventArgs e)
        {	
            OpenFileDialog openCAD = new OpenFileDialog { Filter = "程序单文件(*.txt)|*.txt" };
			if(File.Exists(textBoxCADPath.Text))
				openCAD.InitialDirectory = Path.GetDirectoryName(textBoxCADPath.Text);
			else
                openCAD.InitialDirectory = VWConf.Instance.WorkFolder;

            if (openCAD.ShowDialog() == DialogResult.OK)
            {
				textBoxCADPath.Text = openCAD.FileName;
            }
        }

        private void buttonChoosePicturePath_Click(object sender, EventArgs e)
        {
			OpenFileDialog openPicture = new OpenFileDialog();
			openPicture.Filter = "图片文件(*.jpg;*.bmp;*.gif;*.png;*.ico;*.gif)|*.jpg;*.bmp;*.gif;*.png;*.ico;*.gif|JPG图片(*.jpg)|*.jpg|PNG图片(*.png)|*.png|GIF图片(*.gif)|*.gif|BMP图片(*.bmp)|*.bmp|ICO图片(*.ico)|*.ico";
            if (openPicture.ShowDialog() == DialogResult.OK)
            {
                textBoxPicturePath.Text = openPicture.FileName;
            }
        }

		private void frmPeiZhiToolStripMenuItem_Click(object sender, EventArgs e)
        {
			FormConf formConf = new FormConf();
			formConf.ShowDialog(this);
        }

		private void buttonShengCheng_Click(object sender, EventArgs e)
		{
			NCListData exceldata = new NCListData();
			exceldata.ProjectName = textBoxProjectName.Text;
			exceldata.ModuleName = comboBoxModuleName.Text;
			exceldata.PartName = comboBoxPartName.Text;
			exceldata.BenchMark = comboBoxBenchMark.Text;
			exceldata.Procedure = comboBoxProcedure.Text;
			exceldata.LeftRight = comboBoxLeftRight.Text;
			exceldata.SingleName = comboBoxSingleName.Text;
			exceldata.Side = comboBoxSide.Text;
			exceldata.CADPath = textBoxCADPath.Text;
			exceldata.PicturePath = textBoxPicturePath.Text;
			exceldata.ProgTime = textBoxTime.Text;
			exceldata.Memo = textBoxMemo.Text;

			if (!exceldata.Valid())
				return;

			NCDoc doc = new NCDoc();
			if (!doc.Load(exceldata.CADPath))
			{
				MessageBox.Show("文件分析失败!\n" +
				"CAD路径:" + exceldata.CADPath, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			exceldata.NcDoc = doc;

			SaveFileDialog saveExcelPath = new SaveFileDialog();
			saveExcelPath.InitialDirectory = Path.GetDirectoryName(exceldata.PicturePath);
			saveExcelPath.Title = "选择程序加工单保存路径";
			saveExcelPath.Filter = "加工程序单(*.xlsx)|*.xlsx";
			saveExcelPath.FileName = "加工程序单.xlsx";
			if (saveExcelPath.ShowDialog() != DialogResult.OK)
				return;

			string pgmListPath = saveExcelPath.FileName;

			string pgmTimeListPath = Path.Combine(VWConf.Instance.TimeFolder, "加工时间统计单.xlsx");
			if (!File.Exists(pgmTimeListPath))
			{
				//不存在则拷贝一份过去
				if (!VWTemplates.CopyPgmTimeList(pgmTimeListPath))
				{
					MessageBox.Show("不能拷贝加工程序统计单模板!\n" +
						"到:" + pgmTimeListPath, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}
			}

			if (!VWTemplates.CopyPgmList(pgmListPath))
			{
				MessageBox.Show("不能拷贝加工程序单模板!\n" +
				"到:" + pgmListPath, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			EnableCtrl(false);

			NCExcelWriter writer = new NCExcelWriter();

			if (!writer.WritePgmList(pgmListPath, exceldata))
			{
				MessageBox.Show("文件生成失败!\n" +
				"加工程序单:" + pgmListPath, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
				EnableCtrl(true);
				return;
			}

			if (!writer.WritePgmTimeList(pgmTimeListPath, exceldata))
			{
				MessageBox.Show("文件生成失败!\n" +
				"加工时间统计单:" + pgmTimeListPath, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
				EnableCtrl(true);
				return;
			}

			EnableCtrl(true);

			if (VWConf.Instance.OpenpgmList || VWConf.Instance.OpenpgmTimeList)
			{
				DialogResult dr = MessageBox.Show("下列文件生成成功!" +
													"\n1) 加工程序单:" + pgmListPath +
													"\n2) 加工时间统计单:" + pgmTimeListPath +
													"\n\n是否打开程序单/统计单文件查看?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

				if (dr == DialogResult.Yes)
				{
					try
					{
						if (VWConf.Instance.OpenpgmList)
							Process.Start(pgmListPath);

						if (VWConf.Instance.OpenpgmTimeList)
							Process.Start(pgmTimeListPath);
						//Process.Start("Explorer.exe", "/select, " + pgmListPath);
					}
					catch
					{
					}
				}
			}
		}

		private void EnableCtrl(bool enable)
		{
			//toolStripProgressBar1.Visible = !enable;//暂时未使用
			buttonExec.Enabled = enable;
		}

		private void CIMCOToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormCIMCO form3 = new FormCIMCO();
			form3.ShowDialog(this);
		}

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void buttonClearInformation_Click(object sender, EventArgs e)
        {
            textBoxProjectName.Text = null;
            comboBoxModuleName.Text = null;
            comboBoxPartName.Text = null;
            comboBoxBenchMark.Text = null;
            comboBoxProcedure.Text = null;
            comboBoxLeftRight.Text = null;
            comboBoxSingleName.Text = null;
            comboBoxSide.Text = null;
            textBoxCADPath.Text = null;
            textBoxPicturePath.Text = null;
            textBoxTime.Text = null;
            textBoxMemo.Text = null;
        }

		private void toolStripMenuItemabout_Click(object sender, EventArgs e)
		{
			new FormAbout().ShowDialog(this);
		}
    }
}
