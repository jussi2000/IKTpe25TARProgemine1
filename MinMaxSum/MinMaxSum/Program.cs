namespace MinMaxSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List numbrites");

            int[] numbers =  new int[10] { 2, 10, 15, 6, 8, 22, 31, 67, 69, 52 };

            Console.WriteLine(numbers.Max());
            //Max

            Console.WriteLine(numbers.Min());
            //Min

            Console.WriteLine(numbers.Sum());
            //Sum

            Console.WriteLine(numbers.Average());
            //Average


            //sorteerib numbrid alates väiksemast suuremani
            Console.WriteLine("---------------------");
            Console.WriteLine("Sorteerib numbrid alates väiksemast suuremani:");
            Console.WriteLine("\n");

            Array.Sort(numbers);
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("---------------------");
            Console.WriteLine("Sorteerib numbrid alates suuremast väiksemani:");
            Console.WriteLine("\n");


            //Peate kasutama Array ja Sort ning foreachi
            Array.Sort(numbers);
            Array.Reverse(numbers);
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            //sorteerib numbrid alates suuremast väiksemani

            //KASUTAGE binarySearch-i
            //kirjuta lühidalt, mis see tähendab
            Console.WriteLine(Array.BinarySearch(numbers, 9));

        }
    }
}