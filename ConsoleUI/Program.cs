using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

class Program
{
    static void Main(string[] args)
    {
        CarTest();
        //BrandTest();
    }

    private static void BrandTest()
    {
        BrandManager brandManager = new BrandManager(new EfBrandDal());
        var result = brandManager.GetAll();
        if (result.Success==true)
        {
            foreach (var brand in result.Data)
            {
                Console.WriteLine(brand.BrandName);
            }
        }
    }

    private static void CarTest()
    {
        CarManager carManager = new CarManager(new EfCarDal());
        var result = carManager.GetCarDetails();

        if (result.Success==true)
        {
            foreach (var cars in result.Data)
            {
                Console.WriteLine(cars.CarName + "/" + cars.BrandName);

            }
        }
        else
        {
            Console.WriteLine(result.Message);
        }
    }
}