using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Diagnostics;
namespace VW
{
    class NCDoc
    {
        public string NC_Documentation = string.Empty;
        public string PUTNC_Datei = string.Empty;
        public List<NCJob> Jobs = new List<NCJob>();
        
        public void AddJob(NCJob job)
        {
            Jobs.Add(job);
        }

        public bool Load(string path)
        {
			try
			{
				string[] lines = File.ReadAllLines(path, Encoding.Default);
				for (int i = 0; i < lines.Length; i++)
				{
					string str = lines[i];

					if (string.IsNullOrEmpty(str))
						continue;

					if (i == 0)//第1行直接付给变量NC_Documentation
					{
						this.NC_Documentation = str.Replace("NC-Documentation:","").Trim();
					}
					else if (i == 1)//第2行跳过
					{
					}
					else if (i == 2)//第3行直接付给变量PUTNC_Datei
					{
						this.PUTNC_Datei = str.Replace("PUTNC Datei:","").Trim();
					}
					else if(str.TrimStart().StartsWith("NC-Job:"))//以NC-Job:开头，增加一个job
					{
						NCJob job = new NCJob();
						this.AddJob(job);

						int index = str.IndexOf(":");
						job.NC_Job = str.Substring(index + 1, str.Length - index - 1);

						for (i += 1; i < lines.Length; i++)
						{
							str = lines[i].Trim();

							if (str.StartsWith("Tool  : "))
							{
								job.Tool = str;
							}
							else if (!string.IsNullOrEmpty(str))
							{
								index = str.IndexOf(":");
								string key = str.Substring(0, index).Trim();
								string val = str.Substring(index + 1, str.Length - index - 1).Trim();
								job.dictionary.Add(key, val);
							}
							else
							{
								//空行，结束本Job
								break;
							}
						}
					}
				}
			}
			catch
			{
				return false;
			}

			return true;
        }
    }
}
