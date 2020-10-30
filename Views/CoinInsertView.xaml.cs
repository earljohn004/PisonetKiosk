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
    /// Interaction logic for CoinInsertView.xaml
    /// </summary>
    public partial class CoinInsertView : Window
    {
        public CoinInsertView()
        {
            InitializeComponent();
            //this.Left = 0;
            //this.Top = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Normal;
            Application.Current.MainWindow.Width = 600;
            Application.Current.MainWindow.Height = 300;
            Application.Current.MainWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;

            this.Left = (SystemParameters.PrimaryScreenWidth - this.Width) / 2;
            this.Top = (SystemParameters.PrimaryScreenHeight - this.Height) / 2;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Normal;
            Application.Current.MainWindow.Width = 600;
            Application.Current.MainWindow.Height = 300;
            Application.Current.MainWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;

            this.Left = (SystemParameters.PrimaryScreenWidth - this.Width) / 2;
            this.Top = (SystemParameters.PrimaryScreenHeight - this.Height) / 2;
        }
    }
}
