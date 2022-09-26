using System;
using System.Collections.Generic;
using System.IO;
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
using Microsoft.Win32;
using System.Windows.Threading;

namespace ElméletBeadando0412
{
    /// <summary>
    /// Interaction logic for Openfile.xaml
    /// </summary>
    public partial class Openfile : Window
    {
        pontszampedzs p = new pontszampedzs();
        static int pontszam = 0;
        static List<string> szavak = new List<string>();
        DispatcherTimer dt = new DispatcherTimer();
        public Openfile()
        {
            InitializeComponent();
        }

        private void beolvas(object sender, RoutedEventArgs e)
        {
            szavak.Clear();
            Random r = new Random();
            string fajlnev = "";
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == true)
            {
                fajlnev = op.FileName;
            }

            tb1.Clear();

            StreamReader sr = new StreamReader(fajlnev);
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                szavak.Add(sor);
            }
            sr.Close();

            int listahossza = szavak.Count;

            for (int i = 0; i < 20; i++)
            {
                tb1.Text += i+1 + " " + szavak[r.Next(0, listahossza)] + "\n";
            }

            dt.Interval = TimeSpan.FromSeconds(1);
            dt.Tick += dtTicker;
            dt.Start();

        }

        static int tick = 10;

        private void dtTicker(object sender, EventArgs e)
        {
            tick--;
            if (tick==0)
            {
                dt.Stop();
                tb1.Clear();
            }
            TimerLabel.Content = Convert.ToString(tick);
        }

        private void fomenu(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }

        private void kilep(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ellenorzes_Click(object sender, RoutedEventArgs e)
        {
            string szo = bennevan.Text;
            if (szavak.Contains(szo))
            {
                pontszam++;
                tb1.Text += szo;
                p.tb1.Text = pontszam.ToString();
            }
        }

        private void page(object sender, RoutedEventArgs e)
        {
            p.tb1.Text = pontszam.ToString();
            Main.Content = p;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Elsooldal eo = new Elsooldal();
            eo.Show();
            this.Close();
        }

        private void MenuItem_Click2(object sender, RoutedEventArgs e)
        {
            Masodikoldal mo = new Masodikoldal();
            mo.Show();
            this.Close();
        }
    }
}
