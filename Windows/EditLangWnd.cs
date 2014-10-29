using System;
using System.Windows;
using System.Windows.Controls;
using UFSJ.Sharp;

namespace UFSJ
{
    /// <summary>
    /// Interaction logic for EditLangWnd.xaml
    /// </summary>
    public partial class EditLangWnd : Window
    {
        internal Language language;
        string SCurItem;

        /// <summary>
        /// Constructor
        /// </summary>
        public EditLangWnd()
        {
            InitializeComponent();
        }

        public EditLangWnd(Language language)
            : this()
        {
            this.language = language;
            InitLang();
        }

        void InitLang()
        {

            tLangName.Text = language.Name;
            tLangLocal.Text = language.Local;
            tLangID.Text = language.LCID.ToString();
            tLangVer.Text = language.LangVersion;

            tLangAuthor.Text = language.Author;
            tLangContact.Text = language.AuthorSite;

            lstString.Items.Clear();
            foreach (var item in language.strings.Keys) {
                lstString.Items.Add(item);
            }
        }

        void lstString_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var a = lstString.SelectedItem.ToString();
            if (!String.IsNullOrEmpty(SCurItem) && SCurItem != a) {
                if (cAutosave.IsChecked == true) {
                    language.strings[SCurItem] = tTrans.Text;
                } else if (language.strings[SCurItem] != tTrans.Text) {
                    switch (Shared.MSGBOX("Save Changes?", "Check the Autosave checkbox to prevent this message comes for everytime you forgot to save changes, when you want to!", MessageBoxButton.YesNoCancel)) {
                        case MessageBoxResult.Yes:
                            language.strings[SCurItem] = tTrans.Text;
                            break;
                        case MessageBoxResult.No:
                            break;
                        case MessageBoxResult.Cancel:
                            return;
                    }
                }
            }
            a = lstString.SelectedItem.ToString();
            tTrans.Text = language.strings[a];
            tSource.Text = Application.Current.FindResource(a).ToString();
            tID.Text = a;
            SCurItem = a;
        }

        void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            language.Local = tLangLocal.Text;
            language.LCID = Convert.ToInt32(tLangID.Text);
            language.LangVersion = tLangVer.Text;

            language.Author = tLangAuthor.Text;
            language.AuthorSite = tLangContact.Text;

            language.Save();
        }
        
        void bNext_Click(object sender, RoutedEventArgs e)
        {
            lstString.SelectedIndex += 1;
        }
        void bPrev_Click(object sender, RoutedEventArgs e)
        {
            lstString.SelectedIndex -= 1;
        }
        void bPaste_Click(object sender, RoutedEventArgs e)
        {
            tTrans.SelectedText = Clipboard.GetText();
        }
        void bClose_Click(object sender, RoutedEventArgs e)
        {

            Close();
        }
        void bSave_Click(object sender, RoutedEventArgs e)
        {
            if (lstString.SelectedItem != null) {
                var a = lstString.SelectedItem.ToString();
                language.strings[a] = tTrans.Text;
            }
        }

        private void pClose_Click(object sender, RoutedEventArgs e)
        {

            Close();
        }

        private void PART_MAXIMIZE_RESTORE_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = this.WindowState == System.Windows.WindowState.Normal ? System.Windows.WindowState.Maximized : System.Windows.WindowState.Normal;
        }

        private void PART_MINIMIZE_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = System.Windows.WindowState.Minimized;
        }

        private void TITLEBAR_Drag(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
