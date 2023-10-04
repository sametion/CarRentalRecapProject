using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDaLayer : ICarDaLayer
    {
        List<Car> _cars;                     // an environment will be simulated as if we have data
        public InMemoryCarDaLayer()              //constructor created with data we will use
        {
            _cars = new List<Car>()
            {
                new Car {CarId=1, BrandId=7, ColorId=5, DailyPrice=500, ModelYear="2000", Description="description"},
                new Car {CarId=2, BrandId=7, ColorId=4, DailyPrice=600, ModelYear="2010", Description="description"},
                new Car {CarId=3, BrandId=8, ColorId=5, DailyPrice=700, ModelYear="2010", Description="description"},
                new Car {CarId=4, BrandId=8, ColorId=4, DailyPrice=800, ModelYear="2000", Description="description"},
            };

        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int CarId)
        {
            return _cars.Where(p=> p.CarId==CarId).ToList();
        }

        public void Remove(Car car)
        {
            /*Car carToDelete=null;
                foreach(var item in _cars)
                {
                    if (car.CarId == item.CarId)
                    { 
                        carToDelete = item;
                    }
                }
                _cars.Remove(carToDelete);*/
            
            Car carToDelete = _cars.SingleOrDefault(p=> p.CarId==car.CarId); //cleaner code with using linq(language integrated query)
            _cars.Remove(carToDelete);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            carToUpdate.BrandId=car.BrandId;
            carToUpdate.ColorId=car.ColorId;
            carToUpdate.DailyPrice=car.DailyPrice;
            carToUpdate.Description=car.Description;
            carToUpdate.ModelYear=car.ModelYear;
        }
    }
}
