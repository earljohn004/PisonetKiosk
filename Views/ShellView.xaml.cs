using System;
using System.Collections.Generic;
using System.Linq;
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

namespace PisonetKiosk.Views
{
    /// <summary>
    /// Interaction logic for ShellView.xaml
    /// </summary>
    public partial class ShellView : Window
    {
        private bool toggle_;
        public ShellView()
        {
            InitializeComponent();
            this.Left = SystemParameters.PrimaryScreenWidth - ( this.Width);
            this.Top = 0;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (toggle_ == false)
            {
                Application.Current.MainWindow.WindowState = WindowState.Maximized;
                toggle_ = true;
            }
            else
            {
                Application.Current.MainWindow.WindowState = WindowState.Normal;
                toggle_ = false;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }
    }
}
