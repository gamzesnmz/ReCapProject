using Business.Concrete;
using DataAccess.Concrete.InMemory;

class Program
{
    static void Main(string[] args)
    {
        CarsManager carsManager = new CarsManager(new InMemoryCarsDal());       

        foreach (var cars in carsManager.GetAll())
        {
            Console.WriteLine("Araç Modeli:" + cars.CarDescription + "Araç Yılı:" + cars.CarModelYear+ "Araç Fiyatı;" + cars.CarDailyPrice);

        }
    }

}
