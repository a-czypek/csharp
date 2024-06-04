
using System.Linq.Expressions;
using z8.zad4;

RachunekOszczędnosciowy[] r = new RachunekOszczędnosciowy[]
{
    new RachunekOszczędnosciowy(19.0, 0.5, "bolek", 26.0),
    new RachunekOszczędnosciowy(10.0, 0.5, "lolek", 19.0),
    new RachunekOszczędnosciowy(50.0, 0.5, "tosia", 12.0)

};

foreach(RachunekOszczędnosciowy n in r)
{
    Console.WriteLine(n.ToString());
}