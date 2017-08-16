//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using Cadv.Tool;
//using Cadv.Schema.Documents;
//using Cadv.Schema.DB.Circuit;
//using Cadv.Schema.Tool.Dialog;
//using System.Windows.Forms;
//using System.Collections;
//using System.Data;


//namespace Cadv.Schema.Tool
//{
//    /// <summary>
//    /// （トレーニング用）ツールクラス
//    /// </summary>
//    public class ToolLesson : ToolBase
//    {
//        /// <summary>
//        /// コンストラクタ
//        /// </summary>
//        public ToolLesson()
//            : base(new Identifer("{CA17E1BD-15C3-4F42-B840-9AABEC1818EB}"))
//        {
//        }

//        /// <summary>
//        /// 機能の実行
//        /// </summary>
//        /// <param name="document"></param>
//        /// <param name="view"></param>
//        public override void OnPerform(Cadv.Documents.IDocument document, Cadv.UI.Views.IView view)
//        {
//            SchematicDocument doc = document as SchematicDocument;
//            if(doc == null)
//                return;

//            CirFolder folder = doc.CirFolder;

//            //課題１：回路図で使用している部品のパーツIDを一覧する画面を作成・表示する
//            //表示画面はtextBoxをマルチラインモードでパーツIDを１つ出力したら改行する
//            //（ヒント：部品の情報はCirFolderのPhysicalPartsで取得できる）
//            PhysicalPartCollection PhyPartCol = folder.PhysicalParts;
			
//            StringBuilder sbPartId = new StringBuilder();
			
//            foreach( PhysicalPartBase part in PhyPartCol.Values )
//            {
//                //part.GetLibraryName()
//                //part.PartClass
//                sbPartId.Append(System.Environment.NewLine + part.Name);
//            }
//            if (sbPartId.Length != 0)
//            {
//                //先頭の「,」を削除
//                sbPartId.Remove(0, 1);
//            }

//            ToolLessonDialog dlg = new ToolLessonDialog(sbPartId.ToString());

//            if(dlg.ShowDialog() != DialogResult.OK)
//            {
//                return;
//            }

//            /*else
//            {
//                //課題２：回路図で使用している部品をCSVファイルに出力する機能のクラスを作成・呼び出す
//                //フォーマットは以下とします。
//                //パーツID,ライブラリ名,PartClass
//                CsvFile csvFile = new CsvFile();
//                String filePath = @"C:\TFS\partinfo.csv";
//                csvFile.SaveCsvFile(partInfoTab, filePath);
//            }*/
//            PartCsvWriter csvWriter = new PartCsvWriter(PhyPartCol);
//            String filePath = @"C:\TFS\partinfo.csv";
//            csvWriter.Write(filePath);

//            //課題３：２のcsv作成クラスを元に次の機能を持つクラスを作成・呼び出す 課題２のクラスを継承して機能を実現してください）
//            //1.PartClassがElectricの部品のみCSV出力
//            //2.PartClassがJumperの部品のみCSV出力
//            //3.PartClassがMechaの部品のみCSV出力
//            //4.PartClassがOtherの部品のみCSV出力
//            //5.PartClassがBlockの部品のみCSV出力
//            {
//                String filePath = @"C:\TFS\partinfo.csv";
//                PartCsvWriter csvWriter = new ElectricPartCsvWriter(PhyPartCol, "Electric");
//                csvWriter.Write(filePath);
//            }
//        }

//        /// <summary>
//        /// 機能実行可否チェック
//        /// </summary>
//        /// <param name="document"></param>
//        /// <param name="view"></param>
//        /// <param name="e"></param>
//        public override void OnUpdateCommandUI(Cadv.Documents.IDocument document, Cadv.UI.Views.IView view, UpdateCommandUIArgs e)
//        {
//            e.Enable = false;
//            e.Visible = true;

//            if (document is SchematicDocument)
//            {
//                e.Enable = true;
//                return;
//            }
//        }

//        public override string DefaultMenuTitle
//        {
//            get
//            {
//                return "Lesson";
//            }
//        }
//    }
//}
