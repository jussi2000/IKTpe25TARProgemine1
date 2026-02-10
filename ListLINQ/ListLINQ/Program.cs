
using System.Globalization;

namespace ListLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List and LINQ");
            Console.WriteLine("--------------");


            //teeme "andmebaasi"
            //ja selleks on vaja luua class nimega Person
            //mis on muutuja all nimega person
            IList<Person> person = new List<Person>()
            {
                new Person() {Id = 1, Name = "Anu", Age = 13},
                new Person() {Id = 2, Name = "Juhan", Age = 9},
                new Person() {Id = 3, Name = "Jelizaveta", Age = 16 },
                new Person() {Id = 4, Name = "Kanakoib", Age = 32 },
            };

            // nüüd kasutame person muutjuat uue muutuja all
            // mille nimeks on persons
            var persons = from p in person
                          select new
                          {
                              Id = p.Id,
                              Name = p.Name,
                              Age = p.Age,
                          };

            //kasutame muutjuat persons, et näidata konsoolis tulemust
            foreach (var item in persons)
            {
                Console.WriteLine("id on " + item.Id + " ja nimi on " + item.Name);
            }
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Kasutame LINQ select'i e. teine variant");
            //siin koondame kogu info result muutja sisse
            var result = person
                //Where-ga saab teha konkreetse päringu, et vastab mingitele tingimustele
                .Where(p => p.Id == 1 || p.Age == 9)
                .OrderBy(p => p.Id) //järjestab isikut nime järgi
                .Select (x => new
                { 
                    Id = x.Id,
                    Name = x.Name, 
                    Age = x.Age, 
                });
            //kasutame result muutjuat ja teeme ta lahti rea kaupa
            //läbi muutja item'i
                
            foreach (var item in result)
            {
                Console.WriteLine("id on " + item.Id + " ja nimi on " + item.Name);
            }

            Console.WriteLine("Gruppide kaupa sorteerime");
            Console.WriteLine("-------------------------");

            var groupBy = person
                .GroupBy(p => p.Age);
            //kuvab gruppide kaupa ja antud juhul paneb vanused gruppidesse
            // e. tulemuseks on kolm rida andmeid kuna kaks isikut on 9 a.
            foreach (var item in groupBy)
            {
                Console.WriteLine("Vanuse grupp on: {0}", item.Key);
            }
        }                 
    }
}
