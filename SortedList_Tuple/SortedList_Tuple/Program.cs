namespace SortedList_Tuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vali meetod:");
            Console.WriteLine("1. SortedList");
            Console.WriteLine("2. Tuple");
            Console.WriteLine("----------------");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    SortedList();
                    break;
                case "2":
                    Tuple();
                    break;
                default:
                    Console.WriteLine("Vale valik!");
                    break;
            }
            static void SortedList()
            {
                SortedList<int, string> kassid = new SortedList<int, string>();

                kassid.Add(1, "Muri");
                kassid.Add(2, "Kiisu");
                kassid.Add(3, "Nurr");

                Console.WriteLine("Kassid (SortedList):");

                foreach (var kass in kassid)
                {
                    Console.WriteLine($"ID: {kass.Key}, Nimi: {kass.Value}");
                }
            }
            static void Tuple()
            {
                List<Tuple<int, string>> kassid = new List<Tuple<int, string>>();

                kassid.Add(new Tuple<int, string>(1, "Muri"));
                kassid.Add(new Tuple<int, string>(2, "Kiisu"));
                kassid.Add(new Tuple<int, string>(3, "Nurr"));

                Console.WriteLine("Kassid (Tuple):");

                foreach (var kass in kassid)
                {
                    Console.WriteLine($"ID: {kass.Item1}, Nimi: {kass.Item2}");
                }
            }
        }
    }
}
