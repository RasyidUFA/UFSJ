using System;
using System.Globalization;
using System.Windows;

namespace UFSJ
{
    /// <summary>
    /// Interaction logic for AddLangWnd.xaml
    /// </summary>
    partial class AddLangWnd : Window
    {
		public string TextResult {
			get;
			set;
		}
        /// <summary>
        /// New Instance of  Name Input Window
        /// </summary>
        public AddLangWnd()
        {
            InitializeComponent();
        }

        void bOk_Click(object sender, RoutedEventArgs e)
        {
            var b = tlangName.Text.Split('(', ')');
            var lcid = 0;
            //try {
            //    var s = CultureInfo.GetCultureInfo(tlangName.Text);
            //    lcid = s.LCID;
            //} catch (Exception) {
            //    lcid = 0;
            //}
            var a = new UFSJ.Sharp.Language(b[0].Trim());
            a.Author = tLangAuthor.Text;
            a.AuthorSite = tLangContact.Text;
            a.LangVersion = "0.9.8";
            a.Local = (b.Length > 1) ? b[1].Trim() : "";
            a.LCID = lcid;

            a.SaveDefault();
            Close();
        }
        void bCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void PART_TB_MLBD(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void bClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
