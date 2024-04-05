namespace z1.zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] st = new Student[3];
            st[0] = new Student("Mickey", "Mouse", "23854", (float)4.8);
            st[1] = new Student("Emma", "Morgan", "36834", (float)3.45);
            st[2] = new Student("Taylor", "Norris", "72919", (float)4.5);

            foreach(Student student in st)
            {
                Console.WriteLine(student.ToString());
            }

            Console.ReadKey();
        }
    }
}
