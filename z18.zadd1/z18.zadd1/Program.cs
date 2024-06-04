using z18.zadd1;

BrylyObrotowe[] bryly = new BrylyObrotowe[]
{
    new Kula(3),
    new Walec(4,5),
    new Kula(4),
    new Walec(5,6)
};

Console.WriteLine("Bryły obrotowe");
Console.WriteLine();
foreach(var item in bryly)
{
    Console.WriteLine(item.ToString());
}
