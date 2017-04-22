using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop
{
    public class Car
    {
        private readonly string _make;
        private readonly string _model;
        private readonly Engine _engine;
        private readonly IEnumerable<Seat> _seats;

        public Car(string make, string model, Engine engine, IEnumerable<Seat> seats)
        {
            this._make = make;
            this._model = model;
            this._engine = engine;
            this._seats = new List<Seat>(seats);
        }

        public CarRegistration Register()
        {
            return new CarRegistration(this._make.ToUpper(), this._model, this._engine.CylinderVolumn, this._seats.Sum(seat => seat.Capacity));
        }

        public void Accept(ICarVisitor visitor)
        {
            visitor.Visit(this);
            this._engine.Accept(visitor);
            foreach (Seat seat in this._seats)
                seat.Accept(visitor);
        }
    }
}
