
namespace Inheritance2
{
    class Water
    {
        public bool Flow;
        public string Length;

        //siin on DOSomething meetod, mida siis viidatakse River classi all.
        //see võib olla virtual ja ei panema override 'i kuna teda kirjutatakse üle
        public virtual void DoSomething()

        //Water classis on olemas muutujad Flow ja Lenght ja sellepärast ei
        //pea neid uuesti defineerima
        {
            Console.WriteLine("Do Something water");
        }
    }
}
