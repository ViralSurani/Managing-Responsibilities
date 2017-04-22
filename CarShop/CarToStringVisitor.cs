using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop
{
    class CarToStringVisitor : ICarVisitor
    {
        private string _carDetails;
        private string _engineDetails;
        private int _seatCount;

        public void VisitCar(string make, string model)
        {
            _carDetails = string.Format("{0} {1}", make, model);
        }

        public void Visit(Engine engine)
        {
            _engineDetails = string.Format("{0} cc {1} KW", engine.CylinderVolumn, engine.Power);
        }

        public void Visit(Seat seat)
        {
            _seatCount = _seatCount + seat.Capacity;
        }

        public string GetCarDescription()
        {
            return string.Format("{0} {1} {2} seat(s)", _carDetails, _engineDetails, _seatCount);
        }

    }
}
