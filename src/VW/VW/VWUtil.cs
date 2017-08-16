using System;
using System.Collections.Generic;
using System.Text;

namespace VW
{
    class VWUtil
    {
	   public static string Now
	   {
		   get
		   {
			   string week = DateTime.Now.DayOfWeek.ToString("d");
			   switch (week)
			   {
				   case "0":
					   week = "周日"; break;
				   case "1":
					   week = "周一"; break;
				   case "2":
					   week = "周二"; break;
				   case "3":
					   week = "周三"; break;
				   case "4":
					   week = "周四"; break;
				   case "5":
					   week = "周五"; break;
				   case "6":
					   week = "周六"; break;
			   }
			   System.Globalization.GregorianCalendar gc = new System.Globalization.GregorianCalendar();
			   int weekOfYear = gc.GetWeekOfYear(DateTime.Now, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday);

			   string str = DateTime.Now.ToString("yyyy年MM月dd日") + week + " " + "(第" + weekOfYear + "周)" + DateTime.Now.ToLongTimeString();
			   return str;
		   }
	   }

	   internal static string FormatHMS(int timeTotle)
	   {
		   int h = timeTotle / 3600;
		   int m = (timeTotle % 3600) / 60;
		   int s = (timeTotle % 3600) % 60;

		   string finalstr = string.Format("{0}:{1}：{2}", h, m, s);
		   return finalstr;
	   }
	}
}
