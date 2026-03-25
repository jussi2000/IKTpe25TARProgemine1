namespace Inheritance2
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Inheritance 2");
            //kui siin on Water class e. 'Water water = new Water();'
            //, siis kuvatakse sel olevat DoSomething meetodi sisu
            Water water = new Water();

            //kui panna 'Water water = new River();' , siis kuvatakse River classis olevat DoSomething
            //meetodi sisu.
            Water water2 = new River(); //lisa kood
            water2.Flow = true;
            water2.Length = "123";

            Water water3 = new Lake(); //Lake kood
            water3.Flow = false;
            water3.Length = "987";

            //kuidas saada see korda???
            water.DoSomething();
            water2.DoSomething(); //Lisa kood
            water3.DoSomething(); 
        }
    }
}
