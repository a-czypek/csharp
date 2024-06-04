using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace z16
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Produkt> prod = new List<Produkt>();
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BZapamietaj_Click(object sender, RoutedEventArgs e)
        {
            Produkt a = new Produkt(TBSymbol.Text, 0, TBNazwa.Text, TBJednostka.Text);
            prod.Add(a);
            MessageBox.Show("Produkt został dodany!");
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            var zmienna = new OknoProduktow(prod);
            zmienna.ShowDialog();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            List<string> st = new List<string>();
            for (int i = 0; i < prod.Count; i++)
            {
                st.Add(prod[i].Serializuj());
            }

            // Połączenie wszystkich łańcuchów z listy w jeden łańcuch
            string allStrings = string.Join(Environment.NewLine, st);

            // Zapisanie wszystkich łańcuchów do pliku
            File.WriteAllText("produkty.json", allStrings);

            MessageBox.Show("Dane zostały zapisane do pliku.");
        }
    }
}