using System.Text.RegularExpressions;

namespace RegEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teeme Regular, Expression harjutuse");
            Console.WriteLine("-----------------------------------");

            string word = "#CD55C";
            Console.WriteLine("Hex code: " + word);
            Console.WriteLine("Kas on regex: " + RegExTest(word));

            //Tee regex, mis on false tulemusega
            //põhjenda ära, et miks on false
        }

        public static bool RegExTest(string word)
        {
            //RegularExpression kontrollib, kas sisestatav string
            //vastab nõuetele
            return Regex.IsMatch(word, @"[#][0-9A-Fa-f]{6}\b");
        }
    }
}
