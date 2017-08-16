//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.IO;

//namespace Cadv.Schema.Tool
//{
//    class PartCsvWriter
//    {
//        protected string m_partClass = null;
//        private PhysicalPartCollection _partCol = null;

//        public PartCsvWriter(PhysicalPartCollection partCol)
//        {
//            _partCol = partCol;
//        }

//        public bool Write(string path)
//        {
//            try
//            {
//                StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8);

//                foreach (PhysicalPartBase part in _partCol.Values)
//                {
//                    if (!string.IsNullOrEmpty(m_partClass))
//                    {
//                        if (m_partClass != part.PartClass)
//                        {
//                            continue;
//                        }
//                    }

//                    sw.Write(part.Name);
//                    sw.Write(",");
//                    sw.Write(part.GetLibraryName());
//                    sw.Write(",");
//                    sw.Write(part.PartClass);
//                    sw.WriteLine();
//                }

//                sw.Close();
//            }
//            catch
//            {
//                return false;
//            }

//            return true;
//        }
//    }
//    class ElectricPartCsvWriter : PartCsvWriter
//    {
//        public ElectricPartCsvWriter(PhysicalPartCollection partCol, string partClass)
//            : base(partCol)
//        {
//            m_partClass = partClass;
//        }
//    }

//    class JumperPartCsvWriter : PartCsvWriter
//    {
//        public JumperPartCsvWriter(PhysicalPartCollection partCol, string partClass)
//            : base(partCol)
//        {
//            m_partClass = partClass;
//        }
//    }

//    class MechaPartCsvWriter : PartCsvWriter
//    {
//        public MechaPartCsvWriter(PhysicalPartCollection partCol, string partClass)
//            : base(partCol)
//        {
//            m_partClass = partClass;
//        }
//    }

//    class OtherPartCsvWriter : PartCsvWriter
//    {
//        public OtherPartCsvWriter(PhysicalPartCollection partCol, string partClass)
//            : base(partCol)
//        {
//            m_partClass = partClass;
//        }
//    }
//    class BlockPartCsvWriter : PartCsvWriter
//    {
//        public BlockPartCsvWriter(PhysicalPartCollection partCol, string partClass)
//            : base(partCol)
//        {
//            m_partClass = partClass;
//        }
//    }
//}
