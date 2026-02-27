

namespace LINQTakeSkip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kutsume esile LINQ meetodit");
            Console.WriteLine("1. Skip");
            Console.WriteLine("2. skipWhile");
            Console.WriteLine("3. TakeWhile");
            Console.WriteLine("4. FirstOrDefault");
            Console.WriteLine("5. AverageAge");
            Console.WriteLine("6. CountLINQ");
            Console.WriteLine("7. Sum");
            Console.WriteLine("8. MaxLinq");
            Console.WriteLine("9. MinLinq");
            Console.WriteLine("----------------------------");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Skip();
                    break;

                case 2:
                    skipWhile();
                    break;

                case 3:
                    TakeWhile();
                    break;

                case 4:
                    FirstOrDefault();
                    break;

                case 5:
                    AverageAge();
                    break;

                case 6:
                    CountLINQ();
                    break;

                case 7:
                    Sum();
                    break;

                case 8:
                    MaxLinq();
                    break;

                case 9:
                    MinLinq();
                    break;


                default:
                    Console.WriteLine("Vale valik");
                    break;
            }
        }
        public static void Skip()
        {
            Console.WriteLine("----------[ Skip ]----------");
            //kasuta skip'i ja jäta kolm tükki vahele
            var skip = PeopleList.people.Skip(3);

            foreach (var item in skip)
            {
                Console.WriteLine(item.Name);
            }
        }
        public static void skipWhile()
        {
            //teete uue meetodi, aga kasutate skipWhile ja vanemad,
            //kui 18 peab olema tingimus
            Console.WriteLine("-------[ skipWhile ]--------");
            //mis tähendab: => . see tähendab lambda märki ja selle
            //abli saab kasutada pikema classi nimetuse asemel lühendit
            //koos sees oleva muutujaga, mis antud juhul on x.
            var skipWhile = PeopleList.people.SkipWhile(x => x.Age <= 18);

            foreach (var item in skipWhile)
            {
                Console.WriteLine(item.Id + " " + item.Name + " " + item.Age);
            }
            //SkipWhile jätab loendis nii kaua ridu vahele´kuni vastab tingimusele
            //e. antud juhul jätab read vahele kuni leiab 18 a. isiku ja
            //peale seda hakkab infot jälle kuvama olemata vanuse tingimustest
        }

        //kasutada TakeWhile'i ja kasutada see esile switchis
        //tingimus on Age > 18

        //vooskeem teha TakeWhile meetodist
        public static void TakeWhile()
        {
            Console.WriteLine("-------[ TakeWhile ]--------");

            var takeWhileResult = PeopleList.people.TakeWhile(x => x.Age > 18);

            foreach (var item in takeWhileResult)
            {
                Console.WriteLine(item.Id + " " + item.Name + " " + item.Age);
            }
            // TakeWhile näitab isiukuid kuni vastab tingimusele
            //e antud juhul näitab andmeid kuni leiab, 18 a. isiku ja
            //peale seda enam ei näita andmeid

        }
        public static void FirstOrDefault()
        {
            //Õpetaja vajrant:

            //peate kasutama Name'i ja Lenght'i. Nimi peab olema vähemalt 5
            //tähemärki pikk

            //kuvab esimese elemedni, mis järjestuses vastab tingimusetele
            string firstLongName = PeopleList.people
            .FirstOrDefault(x => x.Name.Length >= 5).Name;

            Console.WriteLine("The first long name is: '{0}'.", firstLongName);

            //Minu varjant:

            //string firstLongName = PeopleList.people.First().Name;

            //Console.WriteLine("The first long name is: " + "'" + firstLongName + "'");
        }
        //kasutame avarage linq
        //muutjaks on Age(Mis on Avarage age)
        public static void AverageAge()
        {
            Console.WriteLine("--------[ Average ]---------");

            double averageAge = PeopleList.people
                .Average(x => x.Age);

            Console.WriteLine("Kõikide vanuste keskmine vanus on: " + averageAge);
        }
        public static void CountLINQ()
        {
            var totalPersons = PeopleList.people.Count();

            Console.WriteLine("Inimesi on kokku " + totalPersons);
            Console.WriteLine("---------------------------------");

            var adultPerson = PeopleList.people.Count(x => x.Age >= 18);
            Console.WriteLine("Inimesi on kokku " + adultPerson);
        }
        public static void Sum()
        {
            //kasutame summat e. Sum
            var sumAge = PeopleList.people.Sum(x => x.Age);
            Console.WriteLine("Koondvanus on " + sumAge);

            Console.WriteLine("--------------------------");

            var sumAdults = 0;
            var numAdults = PeopleList.people.Sum(x =>
            {
                if (x.Age >= 18)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            });

            Console.WriteLine("Täisealiste isikute koondarv on " + numAdults);
        }
        public static void MaxLinq()
        {
            var oldestPerson = PeopleList.people
                .Max(x => x.Age);

            Console.WriteLine("Kõige vanem isik on " + oldestPerson + ". aastane.");
        }
        public static void MinLinq()
        {
            var YoungestPerson = PeopleList.people
                .Min(x => x.Age);

            Console.WriteLine("Kõige noorem isik on " + YoungestPerson + ". aastane.");
        }
    }
}