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

namespace z16
{
    /// <summary>
    /// Logika interakcji dla klasy OknoProduktow.xaml
    /// </summary>
    public partial class OknoProduktow : Window
    {
        List<Produkt> listeczek;
        int fenek = 0;
        public OknoProduktow(List<Produkt> lista)
        {
            InitializeComponent();
            this.listeczek = lista;
        }

        List<Produkt> Listeczek
        {
            get { return  listeczek; }
            set { listeczek = value; }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            fenek = 0;
            Wyswietl();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            fenek -= 1;
            Wyswietl();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            fenek += 1;
            Wyswietl();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            fenek = listeczek.Count() - 1;
            Wyswietl();
        }

        public void Wyswietl()
        {
            LBSymbol.Content = listeczek[fenek].Symbol;
            LBNazwa.Content = listeczek[fenek].Nazwa;
            LBJednostka.Content = listeczek[fenek].JednostkaMiary;
        }
    }
}
