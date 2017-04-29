using System;
using System.Collections.Generic;

namespace CarShop
{
    class CarsView
    {
        private IEnumerable<Car> _cars;

        public CarsView(IEnumerable<Car> cars)
        {
            this._cars = cars;
        }

        public void Render()
        {
            //foreach (Car car in _cars)
            //{
            //    Console.WriteLine("{0} {1} {2}cc {3}KW {4} seat(s)", car.Make, car.Model, car.Engine.CylinderVolumn, car.Engine.Power, car.Seats.Sum(seat => seat.Capacity));
            //}

            foreach (Car car in _cars)
            {
                //CarToStringVisitor visitor = new CarToStringVisitor();
                string report = car.Accept(() => new CarToStringVisitor());
                //Console.WriteLine(visitor.GetCarDescription());
                Console.WriteLine(report);
            }

        }
    }
}
