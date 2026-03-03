
using System.Security.Cryptography.X509Certificates;

namespace LinqAllAny
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, LINQ!");
            Console.WriteLine("\n");
            Console.WriteLine("1. All");
            Console.WriteLine("2. AnyLinq");
            Console.WriteLine("3. JoinLinq");
            Console.WriteLine("------------");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AllLinq();
                    break;

                case 2:
                    AnyLinq();
                    break;

                case 3:
                    JoinLinq();
                    break;

                default:
                    Console.WriteLine("ERROR");
                    break;
            }
        }
        public static void AllLinq()
        {
            //Kasutate All
            //Kontrollite, kas on vanemaid, kui 12 ja nooremaid, kui 20

            bool result = StudentData.students.All(x => x.Age > 12 && x.Age < 20);

            Console.WriteLine(result);
        }
        //teeme uue meetodi nimge AnyLinq
        //kasutada Any't
        //vastus on true
        //kasutada muutujat Age

        public static void AnyLinq()
        {
            bool result = StudentData.students.Any(x => x.Age > 12 && x.Age < 20);

            Console.WriteLine(result);

            //teha meetodi nimega JoinLinq
            //kasutada Join-i ja foreachi

        }
        public static void JoinLinq()
        {
            var innerJoin = StudentData.students
          .Join
          (

               StandartData.standarts,
               students => students.studentId,
               standartId => standartId.StandartId,
              (students, standartId) => new
              {
                  Name = students.Name,
                  StandartId = standartId.StandartId,
              }
         );

            foreach (var item in innerJoin)
            {
                Console.WriteLine("{0} - {1}", item.Name, item.StandartId);
            }
        }
    }
}
