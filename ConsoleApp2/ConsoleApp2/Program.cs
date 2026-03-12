using System.Runtime.InteropServices.Marshalling;
using Encapsulation.Service;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Encapsulation ehk kapseldamine");

            //ligipääs classile Student ei ole piiratud kuna
            //asub samas projecris
            Student student = new Student();

            /* Miks on error?            
            Student2 ei tohi teha public classics

            koodi ei tohi parandada, aga pead aru saama, miks on viga

            miks internal classe ei saa viidata teisest projectist
            aga samas projektis olevat saab? */

            //V: Kui on tegemist internal clasiga, siis
            //ei saa teisest projektist neid esile kutsuda
            //Student2 student2 = new Student2();

            student.Id = 101;
            student.Name = "test";
            student.Email = "Test@test.com";

            Console.WriteLine("Id = " + student.Id);
            Console.WriteLine("Name = " + student.Name);
            Console.WriteLine("Email = " + student.Email);

            //kasutame ProtectedStudent classi
            ProtectedStudent protectedStudent = new ProtectedStudent();
            //protectedStudent.DoSomething();

            //ei saa kasutada kuna asub teises classis, aga
            //samas projektis

            //teha Program.cs classi meetod nimega DoSomethingInProgramClass
            //ja kutsuda see esile Program meetodis
            Console.WriteLine("-----------------------------");
            Program program = new Program();
            program.DoSomethingInProgramClass();

            //kutsuda PrivateProdectedInProgramClass esile
            Console.WriteLine("---PrivateProdectedInProgramClass---");
            Program pp = new Program();
            Console.WriteLine(pp.PrivateProdectedInProgramClass =
                "DoSomethingInProgramClass");
            //soovime kasutada privateProtectedStudent classis olevat
            //mettodi ja kutsuda see esile Main meetodis.
            var privateProtectedStudent = new PrivateProtectedStudent();
            //kui asub samas classis, siis saab kasutada,
            //aga teises classis olevat ei saa
            //privateProtectedStudent.PrivateProtectedStudent1 = "asdasd";

            //sealed classi kasutamine
            Console.WriteLine("-----Sealed Class-----");
            //
            var sc = new SealedStudent();
            sc.Id = 123;
            sc.Name = "Test";
            sc.Email = "SealedTest@sealed.com";

            //$ - string format e. saan kasutatda stringväliseid muutujaid
            Console.WriteLine($"Id on {sc.Id}, Name on {sc.Name} ja + " +
                $"Email on {sc.Email}");
        }
        protected void DoSomethingInProgramClass()
        {
            Console.WriteLine("DoSomethingInProgramClass");
        }

        private protected string PrivateProdectedInProgramClass =
            "PrivateProdectedInProgramClass";

    }
}