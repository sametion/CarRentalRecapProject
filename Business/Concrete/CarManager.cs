using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDaLayer _carDaLayer;

        public CarManager(ICarDaLayer carDalayer)
        {
            _carDaLayer = carDalayer;
        }

        public void Add(Car car)
        {
            _carDaLayer.Add(car);
        }

        public List<Car> GetAll()
        {
            return _carDaLayer.GetAll();
        }

        public List<Car> GetById(int id)
        {
            return _carDaLayer.GetById(id);
        }

        public void Remove(Car car)
        {
            _carDaLayer.Remove(car);
        }

        public void Update(Car car)
        {
            _carDaLayer.Update(car);
        }
    }

} 
