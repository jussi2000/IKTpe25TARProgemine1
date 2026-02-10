using System.Reflection.Emit;

namespace EnumProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enum");
            //Kasutame enum'it Weekdays ja et
            //näha oleks Friday'd(Reede peab olema tuvastatud)
            Console.WriteLine(Weekdays.Friday);
            //tahame näha friday numbrilist väärtust
            Console.WriteLine((int)Weekdays.Friday);

            //(int)- castimine e. teisendab andmetüübiks
            //juhul kui info võib kaduma minna ja ei näita soovitud tulemust

            Console.WriteLine("----------");
            Console.WriteLine(Colors.Green);
            Console.WriteLine((int)Colors.Green);

            //tehke uus enum Colors
            //Väärtused on
            //Red = 3,
            //Green = 10,
            //Blue = 13,
            //Yellow = 5,
            //Black = 1,
            //White = 8
            //ühe värvi peab konsoolis ära näitma        
        }
        enum Weekdays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        enum Colors
        {
            Red = 3,
            Green = 10,
            Blue = 13,
            Yellow = 5,
            Black = 1,
            White = 8
        }
    }
}
