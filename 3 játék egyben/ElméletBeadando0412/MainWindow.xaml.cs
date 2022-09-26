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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ElméletBeadando0412
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void kilep(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void lotto(object sender, RoutedEventArgs e)
        {
            Elsooldal eo = new Elsooldal();
            eo.Show();
            this.Close();
        }

        private void masik(object sender, RoutedEventArgs e)
        {
            Masodikoldal mo = new Masodikoldal();
            mo.Show();
            this.Close();
        }

        private void beolvasos(object sender, RoutedEventArgs e)
        {
            Openfile of = new Openfile();
            of.Show();
            this.Close();
        }
    }
}
