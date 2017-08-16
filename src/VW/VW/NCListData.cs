using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace VW
{
	class NCListData
	{
		public string ProjectName { get; internal set; }
		public string ModuleName { get; internal set; }
		public string PartName { get; internal set; }
		public string BenchMark { get; internal set; }
		public string Procedure { get; internal set; }
		public string LeftRight { get; internal set; }
		public string SingleName { get; internal set; }
		public string Side { get; internal set; }
		public string CADPath { get; internal set; }
		public string PicturePath { get; internal set; }
		public string ProgTime { get; internal set; }
		public string Memo { get; internal set; }
		public NCDoc NcDoc { get; internal set; }

		internal bool Valid()
		{
			if (!File.Exists(CADPath))
			{
				MessageBox.Show("请输入CAD路径!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			if (!File.Exists(PicturePath))
			{
				MessageBox.Show("请输入图片路径!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			return true;
		}
	}
}
