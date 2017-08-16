using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
namespace VW
{
	class NCJob
	{
		public string NC_Job = string.Empty;
		public string NC_Job_Code
		{
			get
			{
				string[] tmp = NC_Job.Split('-');

				if (tmp.Length != 0)
					return tmp[0];

				return string.Empty;
			}
		}

		public string Tool = string.Empty;
		public Dictionary<string, string> dictionary = new Dictionary<string, string>();

		public string TotalToolLength
		{
			get
			{
				string str = dictionary["Total Tool Length"];
				int index = str.IndexOf(" ");
				if (index != -1)
					str = str.Substring(0, index);
				return str;
			}
		}
		public string MachineAxis
		{
			get
			{
				string str = dictionary["Machine Axis"];
				return str;
			}
		}
		public string Stockallow
		{
			get
			{
				string str = dictionary["Stock allow"];
				int index = str.IndexOf(" ");
				if (index != -1)
					str = str.Substring(0, index);
				return str;
			}
		}
		public string Wallthick
		{
			get
			{
				string str = dictionary["Wall thick"];
				int index = str.IndexOf(" ");
				if (index != -1)
					str = str.Substring(0, index);
				return str;
			}
		}
		public string Stepover
		{
			get
			{
				string str = dictionary["Stepover"];
				int index = str.IndexOf(" ");
				if (index != -1)
					str = str.Substring(0, index);
				return str;
			}
		}
		public string NCTime
		{
			get
			{
				string str = dictionary["NC Time"];
				int index = str.IndexOf(" ");
				if (index != -1)
					str = str.Substring(0, index);
				return str;
			}
		}
		public string Cuttingdata
		{
			get
			{
				return dictionary["Cutting data"];
			}
		}
		public string F
		{
			get
			{
				string str = dictionary["Cutting data"];
				int index = str.IndexOf("F=");
				if (index == -1)
				{
					return string.Empty;
				}
				else
				{
					int strlength = str.Length;
					str = str.Substring(index + 2, strlength - index - 2);
					index = str.IndexOf(" ");
					if (index != -1)
						str = str.Substring(0, index);
					return str;
				}
			}
		}
		public int Time_Seconds
		{
			get
			{
				string str2 = dictionary["NC Time"].Trim();
				int indx = str2.IndexOf(" ");
				if (indx == -1)
					return 0;

				string str3 = str2.Substring(0, indx);
				string[] tmp = str3.Split(':');
				int h = Convert.ToInt32(tmp[0]);
				int m = Convert.ToInt32(tmp[1]);
				int s = Convert.ToInt32(tmp[2]);

				return h * 3600 + m * 60 + s;
			}
		}
		public string Tool_D
		{
			get
			{
				int index1 = Tool.IndexOf("D=");
				if (index1 != -1)
				{
					int index2 = Tool.IndexOf(".", index1);//去掉小数
					if (index2 == -1)
					{
						index2 = Tool.IndexOf(" ", index1);
					}

					if(index2 != -1)
					{
						return Tool.Substring(index1 + 2, index2 - index1 - 2);
					}
				}

				return Tool;
			}
		}
		public string Tool_R
		{
			get
			{
				int index1 = Tool.IndexOf("R=");
				if (index1 != -1)
				{
					int index2 = Tool.IndexOf(".", index1);//去掉小数
					if (index2 == -1)
					{
						index2 = Tool.IndexOf(" ", index1);
					}
					if (index2 != -1)
					{
						return Tool.Substring(index1 + 2, index2 - index1 - 2);
					}
				}
				
				return string.Empty;
			}
		}

		internal bool IsR
		{
			get
			{
				if (NC_Job_Code.Contains("CRD") || NC_Job_Code.Contains("CWD"))
					return true;
				else
					return false;
			}
		}
	}
}
