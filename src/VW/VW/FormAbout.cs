using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VW
{
	public partial class FormAbout : Form
	{
		public FormAbout()
		{
			InitializeComponent();
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void FormAbout_Load(object sender, EventArgs e)
		{
			labelVer.Text = VWConf.Version;
		}
	}
}
