using System.Drawing;
using System.Runtime.InteropServices;
using StructProject;

namespace StructProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Struct!");

            //sulgude sisse saad lisada väärtusi
            Coordinate point = new Coordinate(3,5);
            Console.WriteLine(point.X);
            Console.WriteLine(point.Y);

            Console.WriteLine("--------------");
            IntAndString intAndString = new IntAndString();
            Console.WriteLine(intAndString.Age);
            Console.WriteLine(intAndString.Name);

            Console.WriteLine("--------------");
            InsertedIntAndString InsertedIntAndString = new InsertedIntAndString();
            Console.WriteLine(InsertedIntAndString.City);
            Console.WriteLine(InsertedIntAndString.PostalCode);
        }
    }
    //Mis on struct?
    // struct - Väärtustüüp(value type), mis sarnaneb klassile
    struct Coordinate
    {

        public int X;
        public int Y;

        //teha konstruktor

        public Coordinate(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    //teha struct nimega IntAndString
    //string: Name ja int: Age
    //kutsuda see struct Main'is välja
    struct IntAndString
    {
        public string Name;
        public int Age;

        public IntAndString(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    //teha struct nimega InsertedIntAndString
    //String: City ja Int:  PostalCode
    //Kutsuda see struct Main'is välja
    //structi sees tuleb sellele anda juba väärtuse
    struct InsertedIntAndString
    {
        public string City;
        public int PostalCode;

        public InsertedIntAndString(string city, int postalCode)
        {
            City = city;
            PostalCode = postalCode;
        }
    }
}
