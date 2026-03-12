namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert to numbers: ");
            Console.WriteLine("First number: ");
            int firstNr = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Second number: ");
            int SecondNr = Convert.ToInt32(Console.ReadLine());

            Rectangle rectangle = new Rectangle();
            rectangle.setWidth(firstNr);
            rectangle.setHeight(SecondNr);

            Console.WriteLine("Total area: {0}", rectangle.GetArea());
        }
    }

    class Shape
    {
        public void setWidth(int w)
        {
            Width = w;
        }

        public void setHeight(int h)
        {
            Height = h;
        }
        protected int Width;
        protected int Height;
    }
    //koolon tähendab pärimist
    //läbi pärimise saame kasutada muutujaid width ja height,
    //mis asuvad Shape classis sing neid ei pea siis defineerima
    //Rectangle classis
    class Rectangle : Shape
    {
        public int GetArea()
        {
            //return edastab info selles meetodis toimunud loogika kohta
            return (Width * Height);
        }
    }
}
