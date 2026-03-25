
namespace Inheritance2
{
    class Lake : Water
    {
        //tehke sama asi, mis River'iga ja kutsuge program classi Main meetodis esile 

        public override void DoSomething()
        {
            Console.WriteLine("Lake This river method and it has " + Flow + " is and " + Length + " is in meters");
        }
    }
}
