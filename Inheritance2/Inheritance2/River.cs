
namespace Inheritance2
{
    //River on antud juhul alamklass ja viitab Waterile e. peamised classile
    class River : Water
    {

        //Kui kirjutan ' override ', siis kirjutab Water methodis oleva DoSomething
        //meetodi üle.

        //Kui panen siia public virtual void, siis ei kirjuta Water meetodi DoSomething-t üle

        public override void DoSomething()

            //Water classis on olemas muutujad Flow ja Lenght ja sellepärast ei
            //pea neid uuesti defineerima
        {
            Console.WriteLine("River This river method and it has " + Flow + " is and " + Length + " is in meters");
        }
    }
}
