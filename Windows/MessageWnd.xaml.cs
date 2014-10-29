using System.Windows;
using System.Windows.Controls;

namespace UFSJ.Windows
{
    /// <summary>
    /// Interaction logic for MessageWnd.xaml
    /// </summary>
    public partial class MessageWnd : Window
    {
        public MessageWnd()
        {
            InitializeComponent();
        }
        public MessageWnd(string Title, string Description, MessageBoxButton Button)
        {
            InitializeComponent();
            desc.Text = Description;
            title.Content = Title;
            SetButton(Button);
        }

        private void SetButton(MessageBoxButton Button)
        {
            switch (Button) {
                case MessageBoxButton.OK:
                    b3.Visibility = System.Windows.Visibility.Collapsed;
                    b2.Visibility = System.Windows.Visibility.Collapsed;
                    b1.Visibility = System.Windows.Visibility.Visible;
                    b1.Content = "OK";
                    break;
                case MessageBoxButton.OKCancel:
                    b3.Visibility = System.Windows.Visibility.Collapsed;
                    b2.Visibility = System.Windows.Visibility.Visible;
                    b2.Content = "OK";
                    b1.Visibility = System.Windows.Visibility.Visible;
                    b1.Content = "Cancel";
                    break;
                case MessageBoxButton.YesNo:
                    b3.Visibility = System.Windows.Visibility.Collapsed;
                    b2.Visibility = System.Windows.Visibility.Visible;
                    b2.Content = "Yes";
                    b1.Visibility = System.Windows.Visibility.Visible;
                    b1.Content = "No";
                    break;
                case MessageBoxButton.YesNoCancel:
                    b3.Visibility = System.Windows.Visibility.Visible;
                    b3.Content = "Yes";
                    b2.Visibility = System.Windows.Visibility.Visible;
                    b2.Content = "No";
                    b1.Visibility = System.Windows.Visibility.Visible;
                    b1.Content = "Cancel";
                    break;
                default:
                    break;
            }
        }
        
        private void b_Click(object sender, RoutedEventArgs e)
        {
            switch (((Button)sender).Content.ToString()) {
                case "OK":
                    Result = MessageBoxResult.OK;
                    DialogResult = true;
                    break;
                case "Yes":
                    Result = MessageBoxResult.Yes;
                    DialogResult = true;
                    break;
                case "No":
                    Result = MessageBoxResult.No;
                    DialogResult = false;
                    break;
                case "Cancel":
                    Result = MessageBoxResult.Cancel;
                    DialogResult = false;
                    break;
                default:
                    Result = MessageBoxResult.None;
                    DialogResult = false;
                    break;
            }
            this.Close();
        }

        public MessageBoxResult Result { get; set; }

        private void bClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void PART_TB_MLBD(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
