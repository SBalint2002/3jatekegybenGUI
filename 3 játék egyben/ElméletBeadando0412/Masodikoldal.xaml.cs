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
using System.Windows.Threading;
using Microsoft.Win32;

namespace ElméletBeadando0412
{
    /// <summary>
    /// Interaction logic for Masodikoldal.xaml
    /// </summary>
    public partial class Masodikoldal : Window
    {
        public string idoertek;
        DispatcherTimer dt = new DispatcherTimer();
        DateTime kezdes = new DateTime();
        public Masodikoldal()
        {
            InitializeComponent();
        }

        private void start(object sender, RoutedEventArgs e)
        {
            DispatcherTimer dt = new DispatcherTimer();
            dt.Interval = TimeSpan.FromSeconds(1);
            dt.Tick += dtTicker;
            dt.Start();
            kezdes = DateTime.Now;
            (sender as Button).Content = "";
            (sender as Button).Width = 0;

        }

        private int increment = 0;

        private void dtTicker(object sender, EventArgs e)
        {
            increment++;
            TimerLabel.Content = increment.ToString();
        }

        private void Menuclick2(object sender, RoutedEventArgs e)
        {
            Openfile of = new Openfile();
            of.Show();
            this.Close();
        }

        private void Grat(object sender, RoutedEventArgs e)
        {
            dt.Stop();
            idoertek = (DateTime.Now - kezdes).ToString().Substring(0, 11);
            this.Close();
        }

        private void Menuclick1(object sender, RoutedEventArgs e)
        {
            Elsooldal eo = new Elsooldal();
            eo.Show();
            this.Close();
        }
        static int szamlalo = 0;

        private void Button_MouseMove(object sender, MouseEventArgs e)
        {
            if (szamlalo<25)
            {
                Random r = new Random();
                int x = r.Next(50, 1000);
                int y = r.Next(50, 600);
                (sender as Button).Margin = new Thickness(x, y, 0, 0);
            }
            szamlalo++;
            if (szamlalo == 5)
            {
                dt.Stop();
                MessageBox.Show("Próbálja meg másképp");
                dt.Start();
                bezaras.Content = "Kapjon el! :P";
                bezaras.FontSize = 15;
            }
            if (szamlalo == 10)
            {
                dt.Stop();
                MessageBox.Show("Ne adja fel!");
                dt.Start();
                bezaras.Content = "Itt vagyok!";
                bezaras.FontSize = 20;
                bezaras.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("red");
                kilep.Content = "Kilépés";
            }
            if (szamlalo == 20)
            {
                dt.Stop();
                MessageBox.Show("Segítek kicsit");
                dt.Start();
                bezaras.FontSize = 15;
                bezaras.Content = "Nincs messze";
                if (szamlalo == 21)
                {
                    bezaras.Content = "Nem jött össze";
                }
                (sender as Button).Margin = new Thickness(800, -45, 130, 520);
            }
            if (szamlalo == 25)
            {
                dt.Stop();
                MessageBox.Show("Lefagyasztottam! \nMost próbálja");
                dt.Start();
                szamlalo++;
            }
            if (szamlalo == 26)
            {
                bezaras.FontSize = 10;
                bezaras.Content = "Nem engem kell\n megnyomni";
            }
        }

        private void fomenu(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }
    }
}
