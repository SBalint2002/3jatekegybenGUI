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

namespace ElméletBeadando0412
{
    public partial class Elsooldal : Window
    {
        static List<int> lista2 = new List<int>();
        static List<int> lista1 = new List<int>();
        public Elsooldal()
        {
            InitializeComponent();
        }

        private void Init(int sor, int oszlop)
        {
            lista1.Clear();
            lista2.Clear();
            int szam = 0;
            int szamlalo = 0;
            Random r = new Random();
            for (int i = 0; i < sor; i++)
            {
                grid3.RowDefinitions.Add(new RowDefinition());
            }
            for (int i = 0; i < oszlop; i++)
            {
                grid3.ColumnDefinitions.Add(new ColumnDefinition());
            }
            for (int i = 0; i < sor; i++)
            {
                for (int j = 0; j < oszlop; j++)
                {
                    if (j == 0)
                    {
                        Label l1 = new Label();
                        l1.Width = 50;
                        l1.Height = 25;
                        Grid.SetRow(l1, i);
                        Grid.SetColumn(l1, j);
                        grid3.Children.Add(l1);
                        l1.FontWeight = FontWeights.Bold;
                        l1.Content = i + 1 + ". hét:";
                    }
                    else if (j == 6)
                    {
                        Label l2 = new Label();
                        l2.Width = 70;
                        l2.Height = 25;
                        Grid.SetRow(l2, i);
                        Grid.SetColumn(l2, j);
                        grid3.Children.Add(l2);
                        l2.FontWeight = FontWeights.Bold;
                        l2.Content = i + 27 + ". hét:";
                    }
                    else
                    {
                        Button b = new Button();
                        b.Width = 25;
                        b.Height = 25;
                        Grid.SetRow(b, i);
                        Grid.SetColumn(b, j);
                        grid3.Children.Add(b);
                        if (szamlalo%5==0)
                        {
                            lista1.Clear();
                        }
                        do
                        {
                            szam = r.Next(1, 91);
                        } while (lista1.Contains(szam));
                        lista1.Add(szam);
                        b.Content = szam;
                        b.Click += Button_Click;
                        b.BorderThickness = new Thickness(0);
                        b.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#8ec641");
                        lista2.Add(szam);
                        szamlalo++;
                    }
                }
            }
            var most = lista2.GroupBy(i => i).OrderByDescending(grp => grp.Count()).Select(grp => grp.Key).First();
            leggyakoribb.Content = most;
            var big = lista2.Max();
            legnagyobb.Content = big;
            var small = lista2.Min();
            legkissebb.Content = small;
            var least = lista2.GroupBy(i => i).OrderByDescending(grp => grp.Count()).Select(grp => grp.Key).Last();
            legritkabb.Content = least;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string szam = (sender as Button).Content.ToString();
            int szamlalo = 0;
            for (int i = 0; i < lista2.Count; i++)
            {
                if (lista2[i]==Convert.ToInt32(szam))
                {
                    szamlalo++;
                }
            }
            MessageBox.Show("A keresett szám ennyiszer volt kihúzva: " + szamlalo);
        }

        private void Menuclick1(object sender, RoutedEventArgs e)
        {
            Masodikoldal mo = new Masodikoldal();
            mo.Show();
            this.Close();
        }

        private void kilep(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ujrasorsolas(object sender, RoutedEventArgs e)
        {
            lista1.Clear();
            lista2.Clear();
            grid3.ColumnDefinitions.Clear();
            grid3.RowDefinitions.Clear();
            Init(26, 12);
            var most = lista2.GroupBy(i => i).OrderByDescending(grp => grp.Count()).Select(grp => grp.Key).First();
            leggyakoribb.Content = most;
            var big = lista2.Max();
            legnagyobb.Content = big;
            var small = lista2.Min();
            legkissebb.Content = small;
            var least = lista2.GroupBy(i => i).OrderByDescending(grp => grp.Count()).Select(grp => grp.Key).Last();
            legritkabb.Content = least;
        }

        private void general(object sender, RoutedEventArgs e)
        {
            (sender as Button).Content = "";
            (sender as Button).Width = 0;
            Init(26, 12);
        }

        private void fomenu(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }

        private void Menuclick2(object sender, RoutedEventArgs e)
        {
            Openfile of = new Openfile();
            of.Show();
            this.Close();
        }
    }
}
