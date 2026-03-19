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
            Console.WriteLine("CarServices");
        }
        public void PostData()
        {
            Console.WriteLine("Andmed on edukalt salvestatud!");
        }
        public void PutData()
        {
            Console.WriteLine("Andmed on edukalt uuendatud!");
        }
        public void DeleteData()
        {
            Console.WriteLine("Andmed on edukalt kustutatud!");
        }
    }
}
