using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Windows.Forms;
using System.Windows;
using System.ComponentModel;
using System.Data;
using System.IO;
namespace VW
{
    class NCExcelWriter
    {
		//程序单输出
		public bool WritePgmList(string fileName, NCListData exceldata)
		{
			Microsoft.Office.Interop.Excel.Application xls = new Microsoft.Office.Interop.Excel.Application();
			_Workbook book = null;
			_Worksheet sheet = null;

			try
			{
				book = xls.Workbooks.Open(fileName, Missing.Value, Missing.Value,
					Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value,
					Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);

				xls.Visible = false;
				xls.DisplayAlerts = true;

				sheet = (_Worksheet)book.Worksheets.get_Item(1);

				Microsoft.Office.Interop.Excel.Range cellRange = sheet.Cells;

				NCDoc doc = exceldata.NcDoc;

				VWConf vwConf = VWConf.Instance;

				int timeTotle = 0;
				//Jobs明细输出
				List<NCJob> jobs = doc.Jobs;
				for (int i = 0; i < jobs.Count; i++)
				{
					NCJob job = jobs[i];

					//程序名
					cellRange[i + 23, 1] = job.NC_Job;
					//加工内容
					cellRange[i + 23, 3] = vwConf.GetProgramDispString(job.NC_Job_Code);
					//刀具-直径
					cellRange[i + 23, 5] = "D" + job.Tool_D;
					//刀具-半径
					cellRange[i + 23, 6] = "R" + job.Tool_R;
					//刀具-悬长
					cellRange[i + 23, 7] = job.TotalToolLength;
					//加工角度
					cellRange[i + 23, 8] = job.MachineAxis;
					//余量
					cellRange[i + 23, 11] = job.Stockallow;
					//料厚
					cellRange[i + 23, 12] = job.Wallthick;
					//步距
					cellRange[i + 23, 13] = job.Stepover;
					//F值
					cellRange[i + 23, 14] = job.F;
					//刀补
					cellRange[i + 23, 15] = job.IsR ? "有" : "";
					//理论用时
					cellRange[i + 23, 16] = job.NCTime;

					timeTotle += job.Time_Seconds;
				}

				//2-19行基本信息
				cellRange[2, 2] = exceldata.ProjectName;
				cellRange[2, 5] = exceldata.ModuleName;
				cellRange[4, 2] = exceldata.PartName;
				cellRange[4, 5] = exceldata.SingleName;
				cellRange[6, 2] = exceldata.Procedure;
				cellRange[6, 5] = exceldata.LeftRight;
				cellRange[8, 2] = DateTime.Now.ToString("yyyy-MM-dd");
				cellRange[8, 5] = exceldata.BenchMark;
				cellRange[11, 2] = VWUtil.FormatHMS(timeTotle);
				cellRange[11, 5] = exceldata.Side;
				cellRange[16, 2] = doc.NC_Documentation;
				cellRange[18, 2] = doc.PUTNC_Datei;

				//图片
				Microsoft.Office.Interop.Excel.Range picRange = null;
				picRange = sheet.get_Range("R2", Missing.Value);
				picRange.Select();
				Microsoft.Office.Interop.Excel.Pictures pics = (Microsoft.Office.Interop.Excel.Pictures)sheet.Pictures(Missing.Value);
				pics.Delete();
				pics.Insert(exceldata.PicturePath, Missing.Value);

				book.Save();
				book.Close(false, Missing.Value, Missing.Value);
				return true;
			}
			catch (Exception ex)
			{
				return false;
			}
			finally
			{
				xls.Quit();
				xls = null;
				sheet = null;
				book = null;
				GC.Collect();
			}
		}

		//统计单输出
		public bool WritePgmTimeList(string fileName, NCListData exceldata)
		{
			Microsoft.Office.Interop.Excel.Application xls = new Microsoft.Office.Interop.Excel.Application();
			_Workbook book = null;
			_Worksheet sheet = null;
			try
			{
				book = xls.Workbooks.Open(fileName, Missing.Value, Missing.Value, Missing.Value, Missing.Value,
					Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value,
					Missing.Value, Missing.Value, Missing.Value);

				xls.Visible = false;
				xls.DisplayAlerts = true;

				Microsoft.Office.Interop.Excel.Range cellRange;

				int shtIdx;
				int rowIdx = 4;
				for (shtIdx = 1; shtIdx <= book.Worksheets.Count; shtIdx++)
				{
					sheet = (_Worksheet)book.Worksheets.get_Item(shtIdx);
					cellRange = sheet.Cells;

					bool flg = false;

					//查找空行
					for (rowIdx = 4; rowIdx < 101; rowIdx++)
					{
						object obj = ((Range)sheet.Cells[rowIdx, 1]).Text;

						if (obj == null || string.IsNullOrEmpty(obj.ToString()))
						{
							flg = true;
							break;
						}
					}

					if (flg)
						break;
				}

				//最后一行，生成sheet
				if (shtIdx == book.Worksheets.Count + 1 && rowIdx == 101)
				{
					sheet.Copy(Type.Missing, sheet);
					sheet = (_Worksheet)book.Worksheets.get_Item(shtIdx);

					//清空数据
					cellRange = sheet.Cells;
					for (int j = 4; j < 101; j++)
					{
						for (int k = 1; k <= 6; k++)
						{
							cellRange[j, k] = null;
						}
					}

					rowIdx = 4;
				}

				cellRange = sheet.Cells;

				cellRange[rowIdx, 1] = exceldata.ProjectName;
				cellRange[rowIdx, 2] = exceldata.PartName;
				cellRange[rowIdx, 3] = exceldata.Procedure;
				cellRange[rowIdx, 4] = exceldata.ProgTime;
				cellRange[rowIdx, 5] = DateTime.Now.ToString("yyyy-MM-dd");
				cellRange[rowIdx, 6] = exceldata.Memo;

				book.Save();//保存
				book.Close(false, Missing.Value, Missing.Value);
				
				return true;
			}
			catch
			{
				return false;
			}
			finally
			{
				xls.Quit();
				xls = null;
				sheet = null;
				book = null;
				GC.Collect();
			}
		}
    }
}
