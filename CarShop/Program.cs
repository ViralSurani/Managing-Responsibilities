using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //IEnumerable<Car> cars = new CarRepository().GetAll();
            //CarsView carsView = new CarsView(cars);
            //carsView.Render();

            Car car = new Car("Renault","Megane",new Engine(66,1598),Seat.FourSeatConfiguration );
            CarRegistration registration = car.Register();
            Console.WriteLine(registration);

            //CarRegistration registration1 = new CarRegistration(car.Make,car.Model,car.Engine.CylinderVolumn,car.Seats.Sum(seat=>seat.Capacity));
            //Console.WriteLine(registration1);

            Console.ReadKey();
        }
    }
}
