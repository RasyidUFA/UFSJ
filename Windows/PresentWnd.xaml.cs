using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using UFSJ.Sharp;

namespace UFSJ
{
    /// <summary>
    /// Interaction logic for PresentWindow.xaml
    /// </summary>
    public partial class PresentWindow : Window
    {
        /// <summary>
        /// WEID
        /// </summary>
        public PresentWindow()
        {
            InitializeComponent();
            InitializePreDef();

        }

        void InitializePreDef()
        {
            var temp = Shared.PresentSplit;
            foreach (var item in temp.Keys)
            {
                var a = new ListBoxItem();
                a.Content = item;
                a.Tag = temp[item];
				if (Math.Abs((double)temp[item][1] - 4) == 0) {
					a.Background = cSplitParts.Background;
					a.BorderThickness = new Thickness(0);
				}
                lstPreDef.Items.Add(a);
            }
        }
        void PresentWindow_Loaded(object sender, RoutedEventArgs e)
        {

        }

        void lstPreDef_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var a = (ListBoxItem)lstPreDef.SelectedItem;
            var b = a.Tag;
            var list = b as List<object>;
            if (list != null)
            {
                var c = list;
                DefSizeT.Text = c[0].ToString();
                DefSizeC.SelectedIndex = (int)Convert.ToUInt32(c[1]);
                DefName.Text = a.Content.ToString();

            }
        }

        void bSave_Click(object sender, RoutedEventArgs e)
        {
            var a = (ListBoxItem)lstPreDef.SelectedItem;
            var b = a.Tag;
            var list = b as List<object>;
            if (list != null)
            {
                var c = list;
                c[0] = DefSizeT.Text;
                c[1] = DefSizeC.SelectedIndex;
                a.Content = DefName.Text;
            }
            a.Tag = b;
        }

        private void bClose_Click(object sender, RoutedEventArgs e)
        {
            Shared.PresentSave();
            this.Close();
        }

        private void bClose_Unloaded(object sender, RoutedEventArgs e)
        {
            SavePreDef();
        }
        void SavePreDef()
        {
            var temp = Shared.PresentSplit;
            temp.Clear();
            foreach (ListBoxItem item in lstPreDef.Items)
            {
                var a = item.Tag as List<object>;
                temp.Add(item.Content.ToString(), a);
            }
        }

        private void bUp_Click(object sender, RoutedEventArgs e)
        {
            lstPreDef.Items.MoveCurrentToPrevious();
            lstPreDef.Items.Refresh();
        }

        private void bDown_Click(object sender, RoutedEventArgs e)
        {
            lstPreDef.Items.MoveCurrentToNext();
            lstPreDef.Items.Refresh();
        }

        private void PART_TB_MLBD(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
