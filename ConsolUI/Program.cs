using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsolUI
{
    public class Program
    {
        //created for test
        static void Main(string[] args)
        {
            CarManager carManager=new CarManager(new InMemoryCarDaLayer());
            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.CarId+"--"+item.ModelYear+"--"+item.DailyPrice);
            }
            carManager.Add(new Car { BrandId = 7, CarId = 5, ColorId = 6, DailyPrice = 650, ModelYear = "2013", Description = "description" }   );

            Console.WriteLine("-----------------");

            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.CarId + "--" + item.ModelYear + "--" + item.DailyPrice);
            }

            carManager.Remove(new Car { CarId = 5 });

            Console.WriteLine("-----------------");

            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.CarId + "--" + item.ModelYear + "--" + item.DailyPrice);
            }


        }


    }
}