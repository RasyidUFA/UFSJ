using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using UFSJ.Sharp;

namespace UFSJ.Windows
{
    /// <summary>
    /// Interaction logic for StartWnd.xaml
    /// </summary>
    public partial class StartWnd : Window
    {
        MainWnd v;
        public StartWnd()
        {
            InitializeComponent();
        }

        void bExit_Click(object sender, RoutedEventArgs e)
        {
            if (v != null)
            {
                v.Shutdown = true;
                v.Close();
            }
            this.Close();
            Application.Current.Shutdown();
        }

        void bSplit_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            v.mainTab.SelectedIndex = 1;
            v.Show();
        }

        void LoadMain()
        {
            lWait.Visibility = System.Windows.Visibility.Visible;
            if (v == null) v = new MainWnd();
            v.Shutdown = false;
            lWait.Visibility = System.Windows.Visibility.Hidden;
        }

        void bJoin_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            v.mainTab.SelectedIndex = 2;
            v.Show();
        }

        void bComp_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            v.mainTab.SelectedIndex = 4;
            v.Show();
        }

        void bCheck_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            v.mainTab.SelectedIndex = 3;
            v.Show();
        }

        void Window_Activated(object sender, EventArgs e)
        {
            try
            {
                var assem = Assembly.GetEntryAssembly();
                var assemName = assem.GetName();
                var ver = assemName.Version;
                AboutVersion.Content = String.Format(Shared.GetRes("#S.22#") + " {0}.{1}.{2} Build {3} ( {4} )", ver.Major, ver.Minor, ver.Build, ver.Revision, App.BuildDate);

            }
            catch (Exception)
            {
                var sw = new Version(System.Windows.Forms.Application.ProductVersion);
                AboutVersion.Content = String.Format(Shared.GetRes("#S.22#") + " {0}.{1}.{2} Build {3} ( {4} )", sw.Major, sw.Minor, sw.Build, sw.Revision, App.BuildDate);
            }
            try
            {
                LoadMain();
            }
            finally
            {
                lWait.Visibility = System.Windows.Visibility.Hidden;
            }
            Shared.Setting.Load();

            Shared.Schemes = new Dictionary<string, ColorScheme>();
            if (System.IO.Directory.Exists("Themes\\"))
            {
                Shared.Schemes = ColorScheme.getSchemes(Shared.LocalData("Themes\\"));

            }
            if (System.IO.Directory.Exists("Themes\\"))
            {
                var a = ColorScheme.getSchemes("Themes\\");
                foreach (var i in a)
                {
                    Shared.Schemes.Add(i.Key, i.Value);
                }
            }

            try
            {
                var t = Shared.Schemes[Shared.Setting.Theme == null ? "" : Shared.Setting.Theme];
                Shared.ApplyThemes(t);

            }
            catch
            {
                return;
            }




        }

        void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

    }
}
