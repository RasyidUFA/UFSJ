using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace UFSJ.Sharp
{
    static partial class Shared
    {
        #region Dictionary
        public static Dictionary<string, List<double>> PreDefaultSplit = new Dictionary<string, List<double>>
        {
            {"Blu-ray DL (47 GB)",new List<double>{47732,2}},
            {"Blu-ray(23 GB)",new List<double>{23866,2}},
            {"CD-ROM (650 MB)",new List<double>{650,2}},
            {"CD-ROM 74 Min (650 MB)",new List<double>{600,2}},
            {"CD-ROM 80 Min (700 MB)",new List<double>{700,2}},
            {"CD-ROM 90 Min (800 MB)",new List<double>{800,2}},
            {"CD-ROM 99 Min (880 MB)",new List<double>{880,2}},
            {"CD-ROM+(700 MB)",new List<double>{700,2}},
            {"DVD+R DL (8 GB) ",new List<double>{8152,2}},
            {"DVD+R(4.482 GB)",new List<double>{4482,2}},
            {"DVD-R(4.488 GB)",new List<double>{4488,2}},
            {"DVD-ROM (4.7 GB)",new List<double>{4.7,3}},
            {"DVD-ROM Double Layer (8.5 GB)",new List<double>{8.5,3}},
            {"Floppy disk 3.5\" 1.44 MB (1.39 MB)",new List<double>{1.39,2}},
            {"Pieces (10)",new List<double>{10,4}},
            {"Pieces (100)",new List<double>{100,4}},
            {"Pieces (3)",new List<double>{3,4}},
            {"Pieces (4)",new List<double>{4,4}},
            {"Pieces (50)",new List<double>{50,4}},
            {"USB Flash Drive 1 GB (0.92 GB)",new List<double>{0.92,3}},
            {"USB Flash Drive 128 MB (120 MB)",new List<double>{120,2}},
            {"USB Flash Drive 2 GB (1.92 GB)",new List<double>{1.92,3}},
            {"USB Flash Drive 256 MB (248 MB)",new List<double>{248,2}},
            {"USB Flash Drive 4 GB (3.92 GB)",new List<double>{3.92,3}},
            {"USB Flash Drive 512 MB (504 MB)",new List<double>{504,2}},
            {"USB Flash Drive 64 MB (56 MB)",new List<double>{56,2}},
            {"Volumes (100 MB)",new List<double>{100,2}},
            {"Volumes (5 MB)",new List<double>{5,2}},
            {"Volumes (50 MB)",new List<double>{50,2}},
        };
        public static Dictionary<string, List<object>> PresentSplit = new Dictionary<string, List<object>>();
        //public static Dictionary<string, List<object>> Advanced = new Dictionary<string, List<object>>
        //{
        //    {"UFSJ Defaults",new List<object>{1,1,1,0,1,1,1,0,1}},
        //    {"FFSJ Compatible",new List<object>{0,0,1,0,0,0,1,1,0}},
        //    {"Full",new List<object>{1,1,1,1,1,1,1,1,1}},
        //    {"Compact",new List<object>{1,0,1,1,1,1,0,0,1}},
        //    {"Minimalist",new List<object>{0,0,0,0,0,0,0,0,1}},
        //    {"MasterSplit Compatible",new List<object>{1,0,0,1,1,0,0,0,1}},
        //    {"HJSplit Compatible",new List<object>{0,0,0,0,0,0,0,0,0}}
        //}; 
        #endregion

        internal static void PresentLoad()
        {
            var Doc = new XmlDocument();
            var local = Shared.GetData("UFSJ.D.uscx");
            if (!File.Exists(local)) {
                PresentDefSave();
            }
            Doc.Load(local);
            PresentSplit.Clear();
            var a = Doc.ChildNodes[0];
            var b = a.ChildNodes[0] as XmlElement;
            XmlElement i;
            
            foreach (var y in b.ChildNodes) {

                i = y as XmlElement;
                if (y == null) {
                    break;
                }
                var str = i.Attributes["ID"].Value;
                var d = Double.Parse(i.Attributes["Val"].Value);
                var d2 = Double.Parse(i.Attributes["By"].Value);
                PresentSplit.Add(str, new List<object> { d, d2 });
            }
            return;
        }

        internal static void PresentDefSave()
        {
            var Doc = new XmlDocument();
            var UJ = Doc.CreateElement("UFSJ");
            var UJS = Doc.CreateAttribute("Ver");
            UJS.Value = System.Windows.Forms.Application.ProductVersion.ToString();
            UJ.Attributes.Append(UJS);

            var Defs = Doc.CreateElement("PreDefines");
            foreach (var item in PreDefaultSplit) {
                var b = Doc.CreateElement("item");

                var s = Doc.CreateAttribute("ID");
                s.Value = item.Key;
                b.Attributes.Append(s);

                s = Doc.CreateAttribute("Val"); s.Value = item.Value[0].ToString(); b.Attributes.Append(s);
                s = Doc.CreateAttribute("By"); s.Value = item.Value[1].ToString(); b.Attributes.Append(s);
                s = Doc.CreateAttribute("Show");
                s.Value = "true";
                b.Attributes.Append(s);
                Defs.AppendChild(b);
            }

            var Defs2 = Doc.CreateElement("UserDefined");
            UJ.AppendChild(Defs);
            UJ.AppendChild(Defs2);

            Doc.AppendChild(UJ);
            var local = Shared.GetData("UFSJ.D.uscx");
            Doc.Save(local);
        }

        internal static void PresentSave()
        {
            var Doc = new XmlDocument();
            Doc.CreateXmlDeclaration("1.0", "UTF-8", "no");
            var UJ = Doc.CreateElement("UFSJ");
            var UJS = Doc.CreateAttribute("Ver");
            UJS.Value = System.Windows.Forms.Application.ProductVersion.ToString();
            UJ.Attributes.Append(UJS);

            var Defs = Doc.CreateElement("PreDefines");
            foreach (var item in PresentSplit) {
                var b = Doc.CreateElement("item");

                var s = Doc.CreateAttribute("ID");
                s.Value = item.Key;
                b.Attributes.Append(s);

                s = Doc.CreateAttribute("Val"); s.Value = item.Value[0].ToString(); b.Attributes.Append(s);
                s = Doc.CreateAttribute("By"); s.Value = item.Value[1].ToString(); b.Attributes.Append(s);
                s = Doc.CreateAttribute("Show");
                s.Value = "true";
                b.Attributes.Append(s);
                Defs.AppendChild(b);
            }

            var Defs2 = Doc.CreateElement("UserDefined");
            UJ.AppendChild(Defs);
            UJ.AppendChild(Defs2);

            Doc.AppendChild(UJ);
            var local = GetData("UFSJ.D.uscx");
            Doc.Save(local);
        }

    }
}
