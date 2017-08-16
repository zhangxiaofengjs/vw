using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows;
using System.Xml;
using System.IO;

namespace VW
{
	public partial class FormConf : Form
    {
		public FormConf()
        {
            InitializeComponent();

			VWConf vwConf = VWConf.Instance;
			textBoxWorkFolder.Text = vwConf.WorkFolder;
			textBoxChengXuDanFolder.Text = vwConf.ListFolder;
			textBoxCIMCOFolder.Text = vwConf.CIMCOExe;
			textBoxJiaGongTimeFolder.Text = vwConf.TimeFolder;
			checkBoxOpenpgmList.Checked = vwConf.OpenpgmList;
			checkBoxOpenpgmTimeList.Checked = vwConf.OpenpgmTimeList;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
			VWConf vwConf = VWConf.Instance;
			vwConf.WorkFolder = textBoxWorkFolder.Text;
			vwConf.ListFolder = textBoxChengXuDanFolder.Text;
			vwConf.CIMCOExe = textBoxCIMCOFolder.Text;
			vwConf.TimeFolder = textBoxJiaGongTimeFolder.Text;
			vwConf.OpenpgmList = checkBoxOpenpgmList.Checked;
			vwConf.OpenpgmTimeList = checkBoxOpenpgmTimeList.Checked;
			
			vwConf.Save();

            this.Close(); 
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            textBoxWorkFolder.Text = null;
            textBoxChengXuDanFolder.Text = null;
            textBoxCIMCOFolder.Text = null;
            textBoxJiaGongTimeFolder.Text = null;
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WorkFolderBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openWorkFolder = new FolderBrowserDialog();
			openWorkFolder.SelectedPath = textBoxWorkFolder.Text;
			if (openWorkFolder.ShowDialog() == DialogResult.OK)
            {
                textBoxWorkFolder.Text = openWorkFolder.SelectedPath;
            }
        }

        private void ListFolderBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openWorkFolder = new FolderBrowserDialog();
            if (openWorkFolder.ShowDialog() == DialogResult.OK)
            {
                textBoxChengXuDanFolder.Text = openWorkFolder.SelectedPath;
            }
        }

        private void CIMCOFolderBtn_Click(object sender, EventArgs e)
        {
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.FileName = "CIMCOEdit.exe";
			if (ofd.ShowDialog() == DialogResult.OK)
            {
				textBoxCIMCOFolder.Text = ofd.FileName;
            }
        }

        private void TimeFolderBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openWorkFolder = new FolderBrowserDialog();
			openWorkFolder.SelectedPath = textBoxJiaGongTimeFolder.Text;
            if (openWorkFolder.ShowDialog() == DialogResult.OK)
            {
                textBoxJiaGongTimeFolder.Text = openWorkFolder.SelectedPath;
            }
        }
    }
}
