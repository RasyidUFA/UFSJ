using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Media;
using System.Xml;

namespace UFSJ.Sharp
{
    class ColorScheme
    {

        public string Name { get; set; }
        public Dictionary<string, Color> Colors { get; set; }

        public ColorScheme(string p)
        {
            getSchema(p);
        }

        public ColorScheme()
        {
        }

        public static Dictionary<string, ColorScheme> getSchemes(string path)
        {
            var rea = new Dictionary<String, ColorScheme>();
            var o = Directory.EnumerateFiles(path, "*.ufsxtheme");
            foreach (var item in o) {
                var a = new ColorScheme(item);
                rea.Add(a.Name, a);
            }
            return rea;
        }
        public void getSchema(string path)
        {
            var rea = new Dictionary<String, Color>();
            var Doc = new XmlDocument();
            var local = FindSchemes(path);
			try {
				Doc.Load(local);
				var a = Doc.ChildNodes[1];
				this.Name = a.Attributes["Name"].Value;
				XmlElement i;
				foreach (XmlNode y in a.ChildNodes) {
					i = y as XmlElement;
					if (i == null)
						continue;
					var str = i.Attributes["Key"].Value;
					var str2 = i.Attributes["Color"].Value;
					rea.Add(str, StringToColor(str2));
				}
			} catch (Exception e) {
                throw new Exception("error getting schema", e);
			}
            Colors = rea;
        }

        static string FindSchemes(string path)
		{
			var local = path;
			var local2 = Shared.LocalData(path);
			if (!File.Exists(local) && !File.Exists(local2)) {

			}
			return File.Exists(local2) ? local2 : File.Exists(local) ? local : path;
		}

        static Color StringToColor(string str)
        {
            byte a = 0;
            byte r = 0;
            byte g = 0;
            byte b = 0;

			try {
				var st = str.Substring(1);
				if (st.Length == 8) {

					a = byte.Parse(st.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
					st = st.Substring(2);
					r = byte.Parse(st.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
					g = byte.Parse(st.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
					b = byte.Parse(st.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);

					return Color.FromArgb(a, r, g, b);
				}
				r = byte.Parse(st.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
				g = byte.Parse(st.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
				b = byte.Parse(st.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);

			} catch {
                r = 0; 
                g=0;
                b=0;
			}
            return Color.FromRgb(r, g, b);
        }

        internal static ColorScheme DefaultTheme()
        {
            if (!Directory.Exists(Shared.LocalData("Themes\\"))) {
                Directory.CreateDirectory(Shared.LocalData("Themes\\"));
            }
            if (!File.Exists(Shared.LocalData("Themes\\Dark.ufsxtheme"))) {
                using (var sr = new StreamWriter(Shared.LocalData("Themes\\Dark.ufsxtheme"))) {
                    var str = Encoding.UTF8.GetString(UFSJ.Properties.Resources.BlackTheme);
                    sr.Write(str);
                    sr.Flush();
                    sr.Close();
                }

            }

            return new ColorScheme();
        }
    }
}
