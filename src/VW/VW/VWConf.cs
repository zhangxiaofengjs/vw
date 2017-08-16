using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Windows.Forms;
using System.IO;

namespace VW
{
	class VWConf
	{
		private static string VW_CONF_FILE = Application.StartupPath + "\\vw.xml";
		private static string VW_VER_FILE = Application.StartupPath + "\\version.txt";

		private static VWConf _instance = null;
		public static VWConf Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new VWConf();
					_instance.Load();
				}
				return _instance;
			}
		}

		public static string Version
		{
			get
			{
				if (File.Exists(VW_VER_FILE))
				{
					string[] lines = File.ReadAllLines(VW_VER_FILE);
					if (lines.Length != 0)
						return lines[0];
				}
				return "ver 1.0 2017/02/14";
			}
		}

		private XmlDocument _xmlDoc;

		public List<string> PartsNameList = new List<string>();//零件名称
		public List<string> StandardList = new List<string>();//基准
		public List<string> ProcedureList = new List<string>();//工序
		public List<string> LfPartsList = new List<string>();//左右件
		public List<string> MoldNameList = new List<string>();//模具名
		public List<string> SideList = new List<string>();//正反面
		public List<string> SingleNameList = new List<string>();//单件名
		public List<NCProgramProp> ProgramPropList = new List<NCProgramProp>();//程序名，加工内容
		public string WorkFolder
		{
			set
			{
				SetConfFolder("WorkFolder", value);
			}
			get
			{
				return GetConfFolder("WorkFolder");
			}
		}
		public string ListFolder
		{
			set
			{
				SetConfFolder("ListFolder", value);
			}
			get
			{
				return GetConfFolder("ListFolder");
			}
		}
		public string TimeFolder
		{
			set
			{
				SetConfFolder("TimeFolder", value);
			}
			get
			{
				return GetConfFolder("TimeFolder");
			}
		}
		public string CIMCOExe
		{
			set
			{
				SetConfFolder("CIMCOExe", value);
			}
			get
			{
				return GetConfFolder("CIMCOExe");
			}
		}
		public bool OpenpgmList
		{
			set
			{
				SetConfFolder("OpenpgmList", value?"True":"False");
			}
			get
			{
				return GetConfFolder("OpenpgmList") == "True";
			}
		}
		public bool OpenpgmTimeList
		{
			set
			{
				SetConfFolder("OpenpgmTimeList", value ? "True" : "False");
			}
			get
			{
				return GetConfFolder("OpenpgmTimeList") == "True";
			}
		}
		private XmlNode RootNode
		{
			get
			{
				XmlNode confNode = _xmlDoc.SelectSingleNode(@"VWCFG");
				if (confNode == null)
				{
					confNode = _xmlDoc.CreateElement("VWCFG");
					_xmlDoc.AppendChild(confNode);
				}

				return confNode;
			}
		}
		private void SetConfFolder(string key, string value)
		{
			XmlNode confNode = this.RootNode;
			XmlNode confChildNode = confNode.SelectSingleNode(key);
			if (confChildNode == null)
			{
				confChildNode = _xmlDoc.CreateElement(key);
				confNode.AppendChild(confChildNode);
			}

			confChildNode.InnerText = value;
		}

		private string GetConfFolder(string key)
		{
			XmlNode confNode = this.RootNode;
			XmlNode confChildNode = confNode.SelectSingleNode(key);
			if (confChildNode == null)
				return string.Empty;

			return confChildNode.InnerText;
		}

		private bool Load()
		{
			try
			{
				_xmlDoc = new XmlDocument();

				XmlReaderSettings settings = new XmlReaderSettings();
				settings.IgnoreComments = true;
				string strPath = VW_CONF_FILE;
				XmlReader reader;

				reader = XmlReader.Create(VW_CONF_FILE, settings);
				_xmlDoc.Load(reader);

				XmlNode confNode = RootNode;
				XmlNodeList categoryList = confNode.ChildNodes;
				if (categoryList == null)
				{
					return false;
				}

				foreach (XmlNode categoryNode in categoryList)
				{
					string category = categoryNode.Name;
					if (category == "ProgramCategory")
					{
						LoadProgramCategory(categoryNode);
					}
					else if (category == "PropCategory")
					{
						LoadPropCategory(categoryNode);
					}
				}

				reader.Close();
				return true;
			}
			catch
			{
				return false;
			}
		}

		private void LoadPropCategory(XmlNode categoryNode)
		{
			XmlNodeList propCategoryList = categoryNode.ChildNodes;
			if (propCategoryList != null)
			{
				string propCategory = categoryNode.Attributes["name"].Value;
				if (propCategory == "零件名称")
				{
					foreach (XmlNode propCategoryNode in propCategoryList)
					{
						string partsName = propCategoryNode.InnerText;
						PartsNameList.Add(partsName);
					}
				}
				else if (propCategory == "基准")
				{
					foreach (XmlNode propCategoryNode in propCategoryList)
					{
						string standard = propCategoryNode.InnerText;
						StandardList.Add(standard);
					}
				}
				else if (propCategory == "工序")
				{
					foreach (XmlNode propCategoryNode in propCategoryList)
					{
						string procedure = propCategoryNode.InnerText;
						ProcedureList.Add(procedure);
					}
				}
				else if (propCategory == "左右件")
				{
					foreach (XmlNode propCategoryNode in propCategoryList)
					{
						string lfParts = propCategoryNode.InnerText;
						LfPartsList.Add(lfParts);
					}
				}
				else if (propCategory == "模具名")
				{
					foreach (XmlNode propCategoryNode in propCategoryList)
					{
						string moldName = propCategoryNode.InnerText;
						MoldNameList.Add(moldName);
					}
				}
				else if (propCategory == "正反面")
				{
					foreach (XmlNode propCategoryNode in propCategoryList)
					{
						string side = propCategoryNode.InnerText;
						SideList.Add(side);
					}
				}
				else if (propCategory == "单件名")
				{
					foreach (XmlNode propCategoryNode in propCategoryList)
					{
						string singleName = propCategoryNode.InnerText;
						SingleNameList.Add(singleName);
					}
				}
				else
				{
				}
			}
		}

		private void LoadProgramCategory(XmlNode categoryNode)
		{
			XmlNodeList programList = categoryNode.ChildNodes;
			if (programList != null)
			{
				foreach (XmlNode programNode in programList)
				{
					NCProgramProp programProp = new NCProgramProp();
					programProp.Name = programNode.Attributes["name"].Value;
					programProp.Value = programNode.Attributes["value"].Value;
					ProgramPropList.Add(programProp);
				}
			}
		}

		internal void Save()
		{
			_xmlDoc.Save(VW_CONF_FILE);
		}

		internal string GetProgramDispString(string pgmId)
		{
			foreach (NCProgramProp programProp in ProgramPropList)
			{
				string name = programProp.Name;
				if (pgmId == name)
				{
					return programProp.Value;
				}
			}
			return string.Empty;
		}
	}
}
