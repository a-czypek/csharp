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

namespace Zestaw17Zadanie2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Customers> CustomersList;
        private int currentIndex;
        private readonly object ContactTextBox;

        public MainWindow()
        {
            zaladujDane();
        }

        private void zaladujDane()
        {
            CustomersList = new List<Customers>();

            CustomersList.Add(new Customers("ALFKI", "Alfreds Futterkiste", "Maria Anders", "Sales Representative", "Obere Str. 57", "Berlin", "", "12209", "Germany", "030-0074321", "030-0076545"));
            CustomersList.Add(new Customers("ANATR", "Ana Trujillo Emparedados y helados", "Ana Trujillo", "Owner", "Avda. de la Constitución 2222", "México D.F.", "", "05021", "Mexico", "(5) 555-4729", "(5) 555-3745"));
            CustomersList.Add(new Customers("ANTON", "Antonio Moreno Taquería", "Antonio Moreno", "Owner", "Mataderos  2312", "México D.F.", "", "05023", "Mexico", "(5) 555-3932", ""));
            CustomersList.Add(new Customers("AROUT", "Around the Horn", "Thomas Hardy", "Sales Representative", "120 Hanover Sq.", "London", "", "WA1 1DP", "UK", "(171) 555-7788", "(171) 555-6750"));
            CustomersList.Add(new Customers("BERGS", "Berglunds snabbköp", "Christina Berglund", "Order Administrator", "Berguvsvägen  8", "Luleå", "", "S-958 22", "Sweden", "0921-12 34 65", "0921-12 34 67"));
            CustomersList.Add(new Customers("BLAUS", "Blauer See Delikatessen", "Hanna Moos", "Sales Representative", "Forsterstr. 57", "Mannheim", "", "68306", "Germany", "0621-08460", "0621-08924"));
            CustomersList.Add(new Customers("BLONP", "Blondesddsl père et fils", "Frédérique Citeaux", "Marketing Manager", "24, place Kléber", "Strasbourg", "", "67000", "France", "88.60.15.31", "88.60.15.32"));
            CustomersList.Add(new Customers("BOLID", "Bólido Comidas preparadas", "Martín Sommer", "Owner", "C/ Araquil, 67", "Madrid", "", "28023", "Spain", "(91) 555 22 82", "(91) 555 91 99"));
            CustomersList.Add(new Customers("BONAP", "Bon app", "Laurence Lebihan", "Owner", "12, rue des Bouchers", "Marseille", "", "13008", "France", "91.24.45.40", "91.24.45.41"));
            CustomersList.Add(new Customers("BOTTM", "Bottom-Dollar Markets", "Maria Lincoln", "Accounting Manager", "23 Tsawassen Blvd.", "Tsawassen", "BC", "T2F 8M4", "Canada", "(604) 555-4729", "(604) 555-3745"));
            CustomersList.Add(new Customers("BSBEV", "Bs Beverages", "Victoria Ashworth", "Sales Representative", "Fauntleroy Circus", "London", "", "EC2 5NT", "UK", "(171) 555-1212", ""));
            CustomersList.Add(new Customers("CACTU", "Cactus Comidas para llevar", "Patricio Simpson", "Sales Agent", "Cerrito 333", "Buenos Aires", "", "1010", "Argentina", "(1) 135-5555", "(1) 135-4892"));
            CustomersList.Add(new Customers("CENTC", "Centro comercial Moctezuma", "Francisco Chang", "Marketing Manager", "Sierras de Granada 9993", "México D.F.", "", "05022", "Mexico", "(5) 555-3392", "(5) 555-7293"));
            CustomersList.Add(new Customers("CHOPS", "Chop-suey Chinese", "Yang Wang", "Owner", "Hauptstr. 29", "Bern", "", "3012", "Switzerland", "0452-076545", ""));
            CustomersList.Add(new Customers("COMMI", "Comércio Mineiro", "Pedro Afonso", "Sales Associate", "Av. dos Lusíadas, 23", "Sao Paulo", "SP", "05432-043", "Brazil", "(11) 555-7647", ""));
            CustomersList.Add(new Customers("CONSH", "Consolidated Holdings", "Elizabeth Brown", "Sales Representative", "Berkeley Gardens 12  Brewery", "London", "", "WX1 6LT", "UK", "(171) 555-2282", "(171) 555-9199"));
            CustomersList.Add(new Customers("DRACD", "Drachenblut Delikatessen", "Sven Ottlieb", "Order Administrator", "Walserweg 21", "Aachen", "", "52066", "Germany", "0241-039123", "0241-059428"));
            CustomersList.Add(new Customers("DUMON", "Du monde entier", "Janine Labrune", "Owner", "67, rue des Cinquante Otages", "Nantes", "", "44000", "France", "40.67.88.88", "40.67.89.89"));
            CustomersList.Add(new Customers("EASTC", "Eastern Connection", "Ann Devon", "Sales Agent", "35 King George", "London", "", "WX3 6FW", "UK", "(171) 555-0297", "(171) 555-3373"));
            CustomersList.Add(new Customers("ERNSH", "Ernst Handel", "Roland Mendel", "Sales Manager", "Kirchgasse 6", "Graz", "", "8010", "Austria", "7675-3425", "7675-3426"));
            CustomersList.Add(new Customers("FAMIA", "Familia Arquibaldo", "Aria Cruz", "Marketing Assistant", "Rua Orós, 92", "Sao Paulo", "SP", "05442-030", "Brazil", "(11) 555-9857", ""));
            CustomersList.Add(new Customers("FISSA", "FISSA Fabrica Inter. Salchichas S.A.", "Diego Roel", "Accounting Manager", "C/ Moralzarzal, 86", "Madrid", "", "28034", "Spain", "(91) 555 94 44", "(91) 555 55 93"));
            CustomersList.Add(new Customers("FOLIG", "Folies gourmandes", "Martine Rancé", "Assistant Sales Agent", "184, chaussée de Tournai", "Lille", "", "59000", "France", "20.16.10.16", "20.16.10.17"));
            CustomersList.Add(new Customers("FOLKO", "Folk och fä HB", "Maria Larsson", "Owner", "Åkergatan 24", "Bräcke", "", "S-844 67", "Sweden", "0695-34 67 21", ""));
            CustomersList.Add(new Customers("FRANK", "Frankenversand", "Peter Franken", "Marketing Manager", "Berliner Platz 43", "München", "", "80805", "Germany", "089-0877310", "089-0877451"));
            CustomersList.Add(new Customers("FRANR", "France restauration", "Maria Schmitt", "Marketing Manager", "54, rue Royale", "Nantes", "", "44000", "France", "40.32.21.21", "40.32.21.20"));
            CustomersList.Add(new Customers("FRANS", "Franchi S.p.A.", "Paolo Accorti", "Sales Representative", "Via Monte Bianco 34", "Torino", "", "10100", "Italy", "011-4988260", "011-4988261"));
            CustomersList.Add(new Customers("FURIB", "Furia Bacalhau e Frutos do Mar", "Lino Rodriguez", "Sales Manager", "Jardim das rosas n. 32", "Lisboa", "", "1675", "Portugal", "(1) 354-2534", "(1) 354-2535"));
            CustomersList.Add(new Customers("GALED", "Galería del gastrónomo", "Eduardo Saavedra", "Marketing Manager", "Rambla de Cataluña, 23", "Barcelona", "", "08022", "Spain", "(93) 203 4560", "(93) 203 4561"));
            CustomersList.Add(new Customers("GODOS", "Godos Cocina Típica", "José Pedro Freyre", "Sales Manager", "C/ Romero, 33", "Sevilla", "", "41101", "Spain", "(95) 555 82 82", ""));
            CustomersList.Add(new Customers("GOURL", "Gourmet Lanchonetes", "André Fonseca", "Sales Associate", "Av. Brasil, 442", "Campinas", "SP", "04876-786", "Brazil", "(11) 555-9482", ""));
            CustomersList.Add(new Customers("GREAL", "Great Lakes Food Market", "Howard Snyder", "Marketing Manager", "2732 Baker Blvd.", "Eugene", "OR", "97403", "USA", "(503) 555-7555", ""));
            CustomersList.Add(new Customers("GROSR", "GROSELLA-Restaurante", "Manuel Pereira", "Owner", "5ª Ave. Los Palos Grandes", "Caracas", "DF", "1081", "Venezuela", "(2) 283-2951", "(2) 283-3397"));
            CustomersList.Add(new Customers("HANAR", "Hanari Carnes", "Mario Pontes", "Accounting Manager", "Rua do Paço, 67", "Rio de Janeiro", "RJ", "05454-876", "Brazil", "(21) 555-0091", "(21) 555-8765"));
            CustomersList.Add(new Customers("HILAA", "HILARION-Abastos", "Carlos Hernández", "Sales Representative", "Carrera 22 con Ave. Carlos Soublette #8-35", "San Cristóbal", "Táchira", "5022", "Venezuela", "(5) 555-1340", "(5) 555-1948"));
            CustomersList.Add(new Customers("HUNGC", "Hungry Coyote Import Store", "Yoshi Latimer", "Sales Representative", "City Center Plaza 516 Main St.", "Elgin", "OR", "97827", "USA", "(503) 555-6874", "(503) 555-2376"));
            CustomersList.Add(new Customers("HUNGO", "Hungry Owl All-Night Grocers", "Patricia McKenna", "Sales Associate", "8 Johnstown Road", "Cork", "Co. Cork", "", "Ireland", "2967 542", "2967 3333"));
            CustomersList.Add(new Customers("ISLAT", "Island Trading", "Helen Bennett", "Marketing Manager", "Garden House Crowther Way", "Cowes", "Isle of Wight", "PO31 7PJ", "UK", "(198) 555-8888", ""));
            CustomersList.Add(new Customers("KOENE", "Königlich Essen", "Philip Cramer", "Sales Associate", "Maubelstr. 90", "Brandenburg", "", "14776", "Germany", "0555-09876", ""));
            CustomersList.Add(new Customers("LACOR", "La corne dabondance", "Daniel Tonini", "Sales Representative", "67, avenue de lEurope", "Versailles", "", "78000", "France", "30.59.84.10", "30.59.85.11"));
            CustomersList.Add(new Customers("LAMAI", "La maison dAsie", "Annette Roulet", "Sales Manager", "1 rue Alsace-Lorraine", "Toulouse", "", "31000", "France", "61.77.61.10", "61.77.61.11"));
            CustomersList.Add(new Customers("LAUGB", "Laughing Bacchus Wine Cellars", "Yoshi Tannamuri", "Marketing Assistant", "1900 Oak St.", "Vancouver", "BC", "V3F 2K1", "Canada", "(604) 555-3392", "(604) 555-7293"));
            CustomersList.Add(new Customers("LAZYK", "Lazy K Kountry Store", "John Steel", "Marketing Manager", "12 Orchestra Terrace", "Walla Walla", "WA", "99362", "USA", "(509) 555-7969", "(509) 555-6221"));
            CustomersList.Add(new Customers("LEHMS", "Lehmanns Marktstand", "Renate Messner", "Sales Representative", "Magazinweg 7", "Frankfurt a.M.", "", "60528", "Germany", "069-0245984", "069-0245874"));
            CustomersList.Add(new Customers("LETSS", "Lets Stop N Shop", "Jaime Yorres", "Owner", "87 Polk St. Suite 5", "San Francisco", "CA", "94117", "USA", "(415) 555-5938", ""));
            CustomersList.Add(new Customers("LILAS", "LILA-Supermercado", "Carlos González", "Accounting Manager", "Carrera 52 con Ave. Bolívar #65-98 Llano Largo", "Barquisimeto", "Lara", "3508", "Venezuela", "(9) 331-6954", "(9) 331-7256"));
            CustomersList.Add(new Customers("LINOD", "LINO-Delicateses", "Felipe Izquierdo", "Owner", "Ave. 5 de Mayo Porlamar", "I. de Margarita", "Nueva Esparta", "4980", "Venezuela", "(8) 34-56-12", "(8) 34-93-93"));
            CustomersList.Add(new Customers("LONEP", "Lonesome Pine Restaurant", "Fran Wilson", "Sales Manager", "89 Chiaroscuro Rd.", "Portland", "OR", "97219", "USA", "(503) 555-9573", "(503) 555-9646"));
            CustomersList.Add(new Customers("MAGAA", "Magazzini Alimentari Riuniti", "Giovanni Rovelli", "Marketing Manager", "Via Ludovico il Moro 22", "Bergamo", "", "24100", "Italy", "035-640230", "035-640231"));
            CustomersList.Add(new Customers("MAISD", "Maison Dewey", "Catherine Dewey", "Sales Agent", "Rue Joseph-Bens 532", "Bruxelles", "", "B-1180", "Belgium", "(02) 201 24 67", "(02) 201 24 68"));
            CustomersList.Add(new Customers("MEREP", "Mère Paillarde", "Jean Fresnière", "Marketing Assistant", "43 rue St. Laurent", "Montréal", "Québec", "H1J 1C3", "Canada", "(514) 555-8054", "(514) 555-8055"));
            CustomersList.Add(new Customers("MORGK", "Morgenstern Gesundkost", "Alexander Feuer", "Marketing Assistant", "Heerstr. 22", "Leipzig", "", "04179", "Germany", "0342-023176", ""));
            CustomersList.Add(new Customers("NORTS", "North/South", "Simon Crowther", "Sales Associate", "South House 300 Queensbridge", "London", "", "SW7 1RZ", "UK", "(171) 555-7733", "(171) 555-2530"));
            CustomersList.Add(new Customers("OCEAN", "Océano Atlántico Ltda.", "Yvonne Moncada", "Sales Agent", "Ing. Gustavo Moncada 8585 Piso 20-A", "Buenos Aires", "", "1010", "Argentina", "(1) 135-5333", "(1) 135-5535"));
            CustomersList.Add(new Customers("OLDWO", "Old World Delicatessen", "Rene Phillips", "Sales Representative", "2743 Bering St.", "Anchorage", "AK", "99508", "USA", "(907) 555-7584", "(907) 555-2880"));
            CustomersList.Add(new Customers("OTTIK", "Ottilies Käseladen", "Henriette Pfalzheim", "Owner", "Mehrheimerstr. 369", "Köln", "", "50739", "Germany", "0221-0644327", "0221-0765721"));
            CustomersList.Add(new Customers("PARIS", "Paris spécialités", "Marie Bertrand", "Owner", "265, boulevard Charonne", "Paris", "", "75012", "France", "(1) 42.34.22.66", "(1) 42.34.22.77"));
            CustomersList.Add(new Customers("PERIC", "Pericles Comidas clásicas", "Guillermo Fernández", "Sales Representative", "Calle Dr. Jorge Cash 321", "México D.F.", "", "05033", "Mexico", "(5) 552-3745", "(5) 545-3745"));
            CustomersList.Add(new Customers("PICCO", "Piccolo und mehr", "Georg Pipps", "Sales Manager", "Geislweg 14", "Salzburg", "", "5020", "Austria", "6562-9722", "6562-9723"));
            CustomersList.Add(new Customers("PRINI", "Princesa Isabel Vinhos", "Isabel de Castro", "Sales Representative", "Estrada da saúde n. 58", "Lisboa", "", "1756", "Portugal", "(1) 356-5634", ""));
            CustomersList.Add(new Customers("QUEDE", "Que Delícia", "Bernardo Batista", "Accounting Manager", "Rua da Panificadora, 12", "Rio de Janeiro", "RJ", "02389-673", "Brazil", "(21) 555-4252", "(21) 555-4545"));
            CustomersList.Add(new Customers("QUEEN", "Queen Cozinha", "Lúcia Carvalho", "Marketing Assistant", "Alameda dos Canàrios, 891", "Sao Paulo", "SP", "05487-020", "Brazil", "(11) 555-1189", ""));
            CustomersList.Add(new Customers("QUICK", "QUICK-Stop", "Horst Kloss", "Accounting Manager", "Taucherstraße 10", "Cunewalde", "", "01307", "Germany", "0372-035188", ""));
            CustomersList.Add(new Customers("RANCH", "Rancho grande", "Sergio Gutiérrez", "Sales Representative", "Av. del Libertador 900", "Buenos Aires", "", "1010", "Argentina", "(1) 123-5555", "(1) 123-5556"));
            CustomersList.Add(new Customers("RATTC", "Rattlesnake Canyon Grocery", "Paula Wilson", "Assistant Sales Representative", "2817 Milton Dr.", "Albuquerque", "NM", "87110", "USA", "(505) 555-5939", "(505) 555-3620"));
            CustomersList.Add(new Customers("REGGC", "Reggiani Caseifici", "Maurizio Moroni", "Sales Associate", "Strada Provinciale 124", "Reggio Emilia", "", "42100", "Italy", "0522-556721", "0522-556722"));
            CustomersList.Add(new Customers("RICAR", "Ricardo Adocicados", "Janete Limeira", "Assistant Sales Agent", "Av. Copacabana, 267", "Rio de Janeiro", "RJ", "02389-890", "Brazil", "(21) 555-3412", ""));
            CustomersList.Add(new Customers("RICSU", "Richter Supermarkt", "Michael Holz", "Sales Manager", "Grenzacherweg 237", "Genève", "", "1203", "Switzerland", "0897-034214", ""));
            CustomersList.Add(new Customers("ROMEY", "Romero y tomillo", "Alejandra Camino", "Accounting Manager", "Gran Vía, 1", "Madrid", "", "28001", "Spain", "(91) 745 6200", "(91) 745 6210"));
            CustomersList.Add(new Customers("SANTG", "Santé Gourmet", "Jonas Bergulfsen", "Owner", "Erling Skakkes gate 78", "Stavern", "", "4110", "Norway", "07-98 92 35", "07-98 92 47"));
            CustomersList.Add(new Customers("SAVEA", "Save-a-lot Markets", "Jose Pavarotti", "Sales Representative", "187 Suffolk Ln.", "Boise", "ID", "83720", "USA", "(208) 555-8097", ""));
            CustomersList.Add(new Customers("SEVES", "Seven Seas Imports", "Hari Kumar", "Sales Manager", "90 Wadhurst Rd.", "London", "", "OX15 4NB", "UK", "(171) 555-1717", "(171) 555-5646"));
            CustomersList.Add(new Customers("SIMOB", "Simons bistro", "Jytte Petersen", "Owner", "Vinbæltet 34", "Kobenhavn", "", "1734", "Denmark", "31 12 34 56", "31 13 35 57"));
            CustomersList.Add(new Customers("SPECD", "Spécialités du monde", "Dominique Perrier", "Marketing Manager", "25, rue Lauriston", "Paris", "", "75016", "France", "(1) 47.55.60.10", "(1) 47.55.60.20"));
            CustomersList.Add(new Customers("SPLIR", "Split Rail Beer & Ale", "Art Braunschweiger", "Sales Manager", "P.O. Box 555", "Lander", "WY", "82520", "USA", "(307) 555-4680", "(307) 555-6525"));
            CustomersList.Add(new Customers("SUPRD", "Suprêmes délices", "Pascale Cartrain", "Accounting Manager", "Boulevard Tirou, 255", "Charleroi", "", "B-6000", "Belgium", "(071) 23 67 22 20", "(071) 23 67 22 21"));
            CustomersList.Add(new Customers("THEBI", "The Big Cheese", "Liz Nixon", "Marketing Manager", "89 Jefferson Way Suite 2", "Portland", "OR", "97201", "USA", "(503) 555-3612", ""));
            CustomersList.Add(new Customers("THECR", "The Cracker Box", "Liu Wong", "Marketing Assistant", "55 Grizzly Peak Rd.", "Butte", "MT", "59801", "USA", "(406) 555-5834", "(406) 555-8083"));
            CustomersList.Add(new Customers("TOMSP", "Toms Spezialitäten", "Karin Josephs", "Marketing Manager", "Luisenstr. 48", "Münster", "", "44087", "Germany", "0251-031259", "0251-035695"));
            CustomersList.Add(new Customers("TORTU", "Tortuga Restaurante", "Miguel Angel Paolino", "Owner", "Avda. Azteca 123", "México D.F.", "", "05033", "Mexico", "(5) 555-2933", ""));
            CustomersList.Add(new Customers("TRADH", "Tradição Hipermercados", "Anabela Domingues", "Sales Representative", "Av. Inês de Castro, 414", "Sao Paulo", "SP", "05634-030", "Brazil", "(11) 555-2167", "(11) 555-2168"));
            CustomersList.Add(new Customers("TRAIH", "Trails Head Gourmet Provisioners", "Helvetius Nagy", "Sales Associate", "722 DaVinci Blvd.", "Kirkland", "WA", "98034", "USA", "(206) 555-8257", "(206) 555-2174"));
            CustomersList.Add(new Customers("VAFFE", "Vaffeljernet", "Palle Ibsen", "Sales Manager", "Smagsloget 45", "Århus", "", "8200", "Denmark", "86 21 32 43", "86 22 33 44"));
            CustomersList.Add(new Customers("VICTE", "Victuailles en stock", "Mary Saveley", "Sales Agent", "2, rue du Commerce", "Lyon", "", "69004", "France", "78.32.54.86", "78.32.54.87"));
            CustomersList.Add(new Customers("VINET", "Vins et alcools Chevalier", "Paul Henriot", "Accounting Manager", "59 rue de lAbbaye", "Reims", "", "51100", "France", "26.47.15.10", "26.47.15.11"));
            CustomersList.Add(new Customers("WANDK", "Die Wandernde Kuh", "Rita Müller", "Sales Representative", "Adenauerallee 900", "Stuttgart", "", "70563", "Germany", "0711-020361", "0711-035428"));
            CustomersList.Add(new Customers("WARTH", "Wartian Herkku", "Pirkko Koskitalo", "Accounting Manager", "Torikatu 38", "Oulu", "", "90110", "Finland", "981-443655", "981-443655"));
            CustomersList.Add(new Customers("WELLI", "Wellington Importadora", "Paula Parente", "Sales Manager", "Rua do Mercado, 12", "Resende", "SP", "08737-363", "Brazil", "(14) 555-8122", ""));
            CustomersList.Add(new Customers("WHITC", "White Clover Markets", "Karl Jablonski", "Owner", "305 - 14th Ave. S. Suite 3B", "Seattle", "WA", "98128", "USA", "(206) 555-4112", "(206) 555-4115"));
            CustomersList.Add(new Customers("WILMK", "Wilman Kala", "Matti Karttunen", "Owner/Marketing Assistant", "Keskuskatu 45", "Helsinki", "", "21240", "Finland", "90-224 8858", "90-224 8858"));
            CustomersList.Add(new Customers("WOLZA", "Wolski  Zajazd", "Zbyszek Piestrzeniewicz", "Owner", "ul. Filtrowa 68", "Warszawa", "", "01-012", "Poland", "(26) 642-7012", "(26) 642-7012"));
        }

        //private void BPierwszy_Click(object sender, RoutedEventArgs e)
        //{
        //    CustomersList[0].Show();
        //}

        //private void ShowCustomer(int index)
        //{
        //    if (index >= 0 && index < CustomersList.Count)
        //    {
        //        currentIndex = index;
        //        var customer = CustomersList[index];
        //        IdTextBox.Text = customer.ID.ToString();
        //        NameTextBox.Text = customer.Name;
        //        ContactTextBox.Text = customer.Contact;
        //    }
        //}

        private void ShowCustomer(int index)
        {
            if (index >= 0 && index < CustomersList.Count)
            {
                currentIndex = index;
                var customer = CustomersList[index];
                IdTextBox.Text = customer.CustomerID.ToString();
                NameTextBox.Text = customer.CompanyName;
                ContactTextBox.TextBox = customer.ContactName;
            }
        }

        private void BPierwszy_Click(object sender, RoutedEventArgs e)
        {
            ShowCustomer(0);
        }

        private void BPoprzedni_Click(object sender, RoutedEventArgs e)
        {
            if (currentIndex > 0)
            {
                ShowCustomer(currentIndex - 1);
            }
        }

        private void BNastepny_Click(object sender, RoutedEventArgs e)
        {
            if (currentIndex < CustomersList.Count - 1)
            {
                ShowCustomer(currentIndex + 1);
            }
        }

        private void BOstatni_Click(object sender, RoutedEventArgs e)
        {
            ShowCustomer(CustomersList.Count - 1);
        }
    }

    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
    }
}
