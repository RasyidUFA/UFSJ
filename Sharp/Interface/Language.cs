using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace UFSJ.Sharp
{
    public class Language
    {
        internal string FileName;
        internal string AuthorSite { get; set; }
        internal string Name { get; set; }
        internal string Local { get; set; }
        internal string Author { get; set; }

        internal Dictionary<string, string> strings { get; set; }

        public Language(string name)
        {
            strings = new Dictionary<string, string>();
            this.Name = name;
            FindLangPack();
            Load();
        }

        public Language(string name, string local) : this(name)
        {
            this.Local = local;
        }

        public override string ToString()
        {
            return String.Format("{0} {1}", Name, (Local != "" ? "(" + Local + ")" : ""));
        }

        private void FindLangPack()
        {
            var local = Path.Combine(@"Languages", Name + ".ulex");
            var local2 = Shared.GetData(@"Languages\" + Name + ".ulex");
            if (!File.Exists(local) && !File.Exists(local2)) {
                SaveDefault();
            }
            if (File.Exists(local2)) {
                FileName = local2;
            } else if (File.Exists(local))
                FileName = local;
        }

        internal void Load()
        {
            var Doc = new XmlDocument();

            try {
                Doc.Load(FileName);
                strings = new Dictionary<string, string>();
                var a = Doc.ChildNodes[0];
                var b = a.ChildNodes[0] as XmlElement;
                var c = a.ChildNodes[1] as XmlElement;

                if (LCID == 0) LCID = Convert.ToInt32(b.Attributes["LCID"].Value);
                if (String.IsNullOrEmpty(Local)) Local = b.Attributes["Local"].Value;
                if (String.IsNullOrEmpty(LangVersion)) LangVersion = b.Attributes["langVer"].Value;

                b = b.ChildNodes[0] as XmlElement;

                try {
                    if (String.IsNullOrEmpty(Author)) {
                        Author = b.ChildNodes[0].InnerText;
                        AuthorSite = b.ChildNodes[1].InnerText;
                    }
                } finally {


                }

                XmlElement i;
                foreach (var y in c.ChildNodes) {
                    i = y as XmlElement;
                    if (y == null) {
                        break;
                    }
                    var str = i.Attributes["Key"].Value;
                    var str2 = i.InnerText;
                    strings.Add(str, str2);
                }
            } catch {

            }
            return;
        }

        internal void SaveDefault()
        {
            this.Author = "Anonymous";
            this.LCID = 0;
            this.LangVersion = "0.9.8";
            this.Local = "Neutral";
            using (var a = new StreamWriter(Shared.GetData("Languages\\" + Name + ".ulex"))) {
                var str = Encoding.UTF8.GetString(UFSJ.Properties.Resources.Template);
                var stri = UFSJ.Properties.Resources.DefaultStrings;

                str = str.Replace("{Name}", this.Name)
                        .Replace("{AuthorName}", this.Author)
                        .Replace("{AuthorSite}", this.AuthorSite)
                        .Replace("{langID}", this.LCID.ToString())
                        .Replace("{Local}", this.Local)
                        .Replace("{langVer}", this.LangVersion)
                        .Replace("{Strings}", stri);

                a.Write(str);
                a.Flush();
            }
        }

        internal int LCID { get; set; }

        internal string LangVersion { get; set; }

        internal void Save()
        {
            using (var a = new StreamWriter(FileName)) {

                var str = Encoding.UTF8.GetString(UFSJ.Properties.Resources.Template);
                var stri = "";
                if (strings != null) {
                    foreach (var item in strings) {
                        stri += String.Format("<item Key='{0}'>{1}</item>\r\n", item.Key, item.Value);
                    }

                } else {
                    stri = UFSJ.Properties.Resources.DefaultStrings;
                }

                str = str.Replace("{Name}", this.Name)
                        .Replace("{AuthorName}", this.Author)
                        .Replace("{AuthorSite}", this.AuthorSite)
                        .Replace("{langID}", this.LCID.ToString())
                        .Replace("{Local}", this.Local)
                        .Replace("{langVer}", this.LangVersion)
                        .Replace("{Strings}", stri);
                a.Write(str);
                a.Flush();
            }
        }

        internal void Remove()
        {
            if (File.Exists(FileName)) File.Delete(FileName);
        }
    }
}
