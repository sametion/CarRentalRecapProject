using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICarDaLayer
    {
        List<Car> GetAll();    // display whole list with car type
        List<Car> GetById(int CarId);
        void Add(Car car);
        void Remove(Car car);
        void Update(Car car);
    }
}
