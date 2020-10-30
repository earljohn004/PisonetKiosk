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
    /// Interaction logic for TopUpView.xaml
    /// </summary>
    public partial class TopUpView : Window
    {
        public TopUpView()
        {
            InitializeComponent();
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Application.Current.MainWindow.WindowState = WindowState.Normal;
                Application.Current.MainWindow.Width = 600;
                Application.Current.MainWindow.Height = 300;
                Application.Current.MainWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;

                this.Left = (SystemParameters.PrimaryScreenWidth - this.Width) / 2;
                this.Top = (SystemParameters.PrimaryScreenHeight - this.Height) / 2;
            }else if(e.Key == Key.Tab)
            {
                Application.Current.MainWindow.WindowState = WindowState.Maximized;
            }
        }
    }
}
