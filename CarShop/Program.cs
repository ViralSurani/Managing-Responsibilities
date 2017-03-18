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
            IEnumerable<Car> cars = new CarRepository().GetAll();

            CarsView carsView = new CarsView(cars);
            carsView.Render();

            Console.ReadKey();
        }
    }
}
