using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarsDal : ICarsDal, IBrandsDal
    {
        List<Cars> _cars;
        public InMemoryCarsDal()
        {
            _cars = new List<Cars> {
            new Cars{CarId=1,BrandId=1,ColorId=1,CarModelYear=2018,CarDailyPrice=1250,CarDescription="BMW X11"},
            new Cars{CarId=2,BrandId=1,ColorId=2,CarModelYear=2020,CarDailyPrice=2200,CarDescription="BMW X32"},
            new Cars{CarId=3,BrandId=1,ColorId=3,CarModelYear=2022,CarDailyPrice=3000,CarDescription="BMW 4 Serisi"},
            new Cars{CarId=4,BrandId=2,ColorId=1,CarModelYear=2020,CarDailyPrice=2400,CarDescription="Land Rover Range 3.5"},
            new Cars{CarId=5,BrandId=2,ColorId=4,CarModelYear=2022,CarDailyPrice=3200,CarDescription="Land Rover Range 3.0"},
            };

        }
        public void Add(Cars cars)
        {
            _cars.Add(cars);          
        }

        public void Delete(Cars cars)
        {
            Cars carsToDelete = _cars.SingleOrDefault(c => c.CarId == cars.CarId);

            _cars.Remove(carsToDelete);

        }

        public List<Cars> GetAll()
        {
            return _cars;
        }

        public List<Cars> GetById(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
            
        }

        public void Update(Cars cars)
        {
            Cars carsToUpdate = _cars.SingleOrDefault(c => c.CarId == cars.CarId);
            carsToUpdate.CarDailyPrice = cars.CarDailyPrice;
            
        }
    }
}
