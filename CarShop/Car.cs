using System;
using System.Collections.Generic;

namespace CarShop
{
    class Car : ICar
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
            //return new CarRegistration(this._make.ToUpper(), this._model, this._engine.CylinderVolumn, this._seats.Sum(seat => seat.Capacity));
            return null;
        }

        public void Accept(Func<ICarVisitor> visitorFactory)
        {
            ICarVisitor visitor = visitorFactory();
            this._engine.Accept(() => visitor);
            foreach (Seat seat in this._seats)
                seat.Accept(() => visitor);
            visitor.VisitCar(this._make, this._model);
        }

        public T Accept<T>(Func<ICarVisitor<T>> visitorFactory)
        {
            ICarVisitor<T> visitor = visitorFactory();
            Accept(() => (ICarVisitor)visitor);
            return visitor.ProduceResult();
        }
    }
}
