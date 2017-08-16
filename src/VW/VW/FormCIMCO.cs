using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace VW
{
    public partial class FormCIMCO : Form
    {
		public FormCIMCO()
        {
            InitializeComponent();
			textBoxCADPath.Text = VWConf.Instance.WorkFolder;
        }

		private void textBoxCADPath_TextChanged(object sender, EventArgs e)
		{
			LoadData();
		}

		private void LoadData()
		{
			string path = textBoxCADPath.Text;
			if (Directory.Exists(path))
			{
				listView1.Items.Clear();

				List<string> list = new List<string>();
				if(path.Length != 3)//最上面的磁盘不要加
					list.Add("");
				list.AddRange(Directory.GetDirectories(path, "*.*", SearchOption.TopDirectoryOnly));
				list.AddRange(Directory.GetFiles(path, "*.nc", SearchOption.TopDirectoryOnly));

				foreach (string file in list)
				{
					string name = "";
					string cTime = "";
					string uTime = "";

					int imgIndex = 0;
					if (File.Exists(file))
					{
						imgIndex = 0;
						FileInfo fi = new FileInfo(file);
						name = fi.Name;
						cTime = fi.CreationTime.ToString();
						uTime = fi.LastWriteTime.ToString();
					}
					else if (string.IsNullOrEmpty(file))
					{
						imgIndex = 2;
						name = "上一级目录";
					}
					else
					{
						name = Path.GetFileName(file);
						imgIndex = 1;
					}

					ListViewItem item = new ListViewItem(new string[] {
						name,
						cTime,
						uTime},
						imgIndex);

					item.Tag = file;

					listView1.Items.Add(item);
				}
			}
		}

		private void buttonChoosePath_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog fbd = new FolderBrowserDialog();
			fbd.SelectedPath = VWConf.Instance.WorkFolder;
			if (fbd.ShowDialog(this) == DialogResult.OK)
			{
				textBoxCADPath.Text = fbd.SelectedPath;
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void buttonStartCIMCO_Click(object sender, EventArgs e)
		{
			ListView.SelectedListViewItemCollection col = listView1.SelectedItems;
			if(col == null)
			{
				return;
			}
			if(col.Count!=1)
				return;

			ListViewItem item = col[0];
			string fileNc = item.Tag as string;
			StartCIMOS(fileNc);
		}

		private static void StartCIMOS(string fileNc)
		{
			if (!File.Exists(fileNc))
			{
				MessageBox.Show("NC文件不存在!\n" +
				"路径:" + fileNc, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			string file = VWConf.Instance.CIMCOExe;
			if (!File.Exists(file))
			{
				MessageBox.Show("CIMCO文件不存在!\n" +
				"路径:" + file, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			try
			{
				Process.Start(file, fileNc);
			}
			catch
			{
			}
		}

		private void listView1_DoubleClick(object sender, EventArgs e)
		{
			ListView.SelectedListViewItemCollection col = listView1.SelectedItems;
			if(col == null)
			{
				return;
			}
			if(col.Count!=1)
				return;

			ListViewItem item = col[0];
			string fileNc = item.Tag as string;

			if (File.Exists(fileNc))
			{
				StartCIMOS(fileNc);
			}
			else
			{
				if (string.IsNullOrEmpty(fileNc))
				{
					//如果是往上上一级的文件夹
					fileNc = Path.GetDirectoryName(textBoxCADPath.Text);
				}

				textBoxCADPath.Text = fileNc;
				LoadData();
			}
		}
    }
}
