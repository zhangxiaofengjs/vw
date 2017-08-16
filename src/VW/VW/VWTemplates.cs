using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace VW
{
	class VWTemplates
	{
		private static string PGM_LIST_TEMPLATE = Application.StartupPath + "\\templates\\list.xlsx";
		private static string PGM_TIME_LIST_TEMPLATE = Application.StartupPath + "\\templates\\timelist.xlsx";

		public static bool CopyPgmList(string to)
		{
			try
			{
				File.Copy(PGM_LIST_TEMPLATE, to, true);
			}
			catch
			{
				return false;
			}

			return true;
		}
		public static bool CopyPgmTimeList(string to)
		{
			try
			{
				string tlFolder = Path.GetDirectoryName(to);
				if (!Directory.Exists(tlFolder))
				{
					Directory.CreateDirectory(tlFolder);
				}

				File.Copy(PGM_TIME_LIST_TEMPLATE, to, true);
			}
			catch
			{
				return false;
			}

			return true;
		}
	}
}
