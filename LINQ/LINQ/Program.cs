namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kutsume esile LINQ läbi switchi");
            Console.WriteLine("Vali vastav link numbriga");
            Console.WriteLine("1. Where");
            Console.WriteLine("2. Where ja otsib nime järgi");
            int choice  = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    WhereLINQ();
                    break;

                case 2:
                    WhereByNameLINQ();
                    break;

                default:
                    break;
            }

            WhereLINQ();
        }

         //teeme uue meetodi
        public static void WhereLINQ()
        {
            var peopleAge = PeopleData.peoples
                .Where(x => x.Age > 20 && x.Age < 23);

            //kasuta muutja peopleAge ja kuvada andmed esile
            //kasua foreachi
            foreach (var person in peopleAge)
            {
                Console.WriteLine(person.Name);
            }
        }

        public static void WhereByNameLINQ()
        {
            Console.WriteLine("Kirjuta inimese nimi: ");
            string name = Console.ReadLine();

            //kautaja where inimese otsimiseks
            //otsimine toimub nime alusel
            var peopleData = PeopleData.peoples
            .Where(x => x.Name == name);

            foreach (var people in peopleData)
            {
                Console.WriteLine(people.Name + " " + people.Age);
            }
        }
    }
}
