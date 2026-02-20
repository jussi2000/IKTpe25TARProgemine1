using LINQ2.Models;

namespace LINQ2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. ThenByLINQ");
            Console.WriteLine("2. ThenByDescendingLINQ");
            Console.WriteLine("3. SelectLINQ");

            //Tuleb teha class nimega PeopleList
            //Seal on kuus rida andmeid
            //kindlasti peab olema kaks Mari nimega isikut
            //aga erinevate vanustega

            Console.WriteLine("Tee valik numbriga");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ThenByLINQ();
                    break;

                case 2:
                    ThenByDescendingLINQ();
                    break;

                case 3:
                    SelectLINQ();
                    break;

                default:
                    Console.WriteLine("Vale valik");
                    break;
            }
        }
        //kutsuda meetod switchis esile

        public static void ThenByLINQ()
        {
            //thenby sorteerib numbrilises järjestuses
            var thenByResult = PeopleList.peoples
            .OrderBy(x => x.Name)
            .ThenBy(x => x.Age);

            Console.WriteLine("ThenBy järgi sorteerimine");
            foreach (var item in thenByResult)
            {
                Console.WriteLine(item.Name + " " + item.Age);
            }
        }
        //samasugune nagu eelmine, aga kasutage
        //thenbydescending
        public static void ThenByDescendingLINQ()
        {
            //thenby sorteerib numbrilises järjestuses
            var thenByResult = PeopleList.peoples
            .OrderBy(x => x.Name)
            .ThenByDescending(x => x.Age);

            Console.WriteLine("ThenBy järgi sorteerimine");
            foreach (var item in thenByResult)
            {
                Console.WriteLine(item.Name + " " + item.Age);
            }
        }

        //tuleb teha meetod, kus kasutate LINQ se
        //lecti
        public static void SelectLINQ()
        {
            var result = PeopleList.peoples
                .Select(x => new
                {
                    Name = x.Name,
                    Age = x.Age
                });
            foreach (var item in result)
            {
                Console.WriteLine(item.Name + " " + item.Age);
            }
        }
    }
}
