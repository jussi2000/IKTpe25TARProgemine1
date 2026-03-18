using InheritanceAndServiceClass.Core.ServiceInterface;

namespace InheritanceAndServiceClass.AppServices.Services
{
    //proovige lahendada probleem, et CarServices ei
    //saa kasutada ICarServicesi, kuna see on defineeritud
    //teises projektis
    public class CarServices : ICarServices
    {
        public void GetData()
        {
            Console.WriteLine("Car Services");
        }

    }
}
