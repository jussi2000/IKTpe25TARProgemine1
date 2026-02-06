namespace ArraySortNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(",----------------------------------------------------,");
            Console.WriteLine("|Kasutame Array ja Sort-i(tähestikulises järjestuses)|");
            Console.WriteLine("'----------------------------------------------------'");

            string[] animals = {"cat", "alligator", "fox",
                "donkey", "bear", "elephant", "goat"};

            //tuleb kasutada foreachi ja näidata kõiki loomi
            //paneb kõik tähestikusse kärjekorda - (Array.Sort("animals")
            //Array.Sort(animals);
            foreach (string animal in animals)
            {
                Console.WriteLine(animal);
            }
            Console.WriteLine(",-------------------------------------------,");
            Console.WriteLine("|(3 Esimest sõna tähestikulises järjestuses)|");
            Console.WriteLine("'-------------------------------------------'");
            //´järjesta kolm esimest sõna tähestikulises järjestuses
            //vaadakake Sort meetodit ja mitu overload sellel on

            Array.Sort(animals, 0, 3);
            foreach (string animal in animals)
            {
                Console.WriteLine(animal);
            }

            Console.WriteLine(",-----------------------------,");
            Console.WriteLine("|Korduste välistamine(Numbrid)|");
            Console.WriteLine("-----------------------------'");
            int[] numbers = { 1, 2, 3, 4, 55, 23, 2 };
            //tuleb välistada korduseid
            //mida teha et numbrid ei korduks

            int[] uniqueNumbers = numbers.Distinct().ToArray();
            Array.Sort(uniqueNumbers);
            foreach (int number in uniqueNumbers)
            {
                Console.WriteLine(number);
            }


        }
    }
}
