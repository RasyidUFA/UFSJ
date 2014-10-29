using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using UFSJ.Sharp;

namespace UFSJ
{
    /// <summary>
    /// Interaction logic for LangMgrWnd.xaml
    /// </summary>
    public partial class LangMgrWnd : Window
    {
        public LangMgrWnd()
        {
            InitializeComponent();
            InitLangs();
        }

        private void InitLangs()
        {
            bEdit.IsEnabled = (lb.SelectedItem != null);
            lb.Items.Clear();

            var a = System.IO.Directory.GetFiles("Languages", "*.ulex");
            var LstA = new List<string>();
            foreach (var i in a) {
                var u = new System.IO.FileInfo(i).Name;
                u = u.Remove(u.LastIndexOf('.'));
                LstA.Add(u);
            }
            if (System.IO.Directory.GetFiles(Shared.LocalData("Languages")).Length > 0) {
                a = System.IO.Directory.GetFiles(Shared.LocalData("Languages\\"), "*.ulex");
                foreach (var i in a) {
                    var u = new System.IO.FileInfo(i).Name;
                    u = u.Remove(u.LastIndexOf('.'));
                    if (LstA.Contains(u)) LstA.Remove(u);
                    LstA.Add(u);
                }
            }
            foreach (var u in LstA) {
                lb.Items.Add(new Language(u));
            }

        }

        private void bClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void bEdit_Click(object sender, RoutedEventArgs e)
        {
            var w = new EditLangWnd((Language)lb.SelectedItem);
            w.Owner = this;
            w.ShowDialog();
            InitLangs();
        }

        private void bAdd_Click(object sender, RoutedEventArgs e)
        {
            var ne = new AddLangWnd();
            ne.Topmost = true; ne.Owner = this;
            ne.ShowDialog();
            InitLangs();
        }

        private void lb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            bEdit.IsEnabled = (lb.SelectedItem != null);
            bRemove.IsEnabled = (lb.SelectedItem != null);
        }

        private void bRemove_Click(object sender, RoutedEventArgs e)
        {
            var a = (Language)lb.SelectedItem;
            if (a == null) return;
            a.Remove();
            InitLangs();
        }

        private void PART_TB_MLBD(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            DragMove();
        }

    }
}
