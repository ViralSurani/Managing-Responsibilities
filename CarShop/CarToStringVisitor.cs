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

        public void VisitEngine(float power, float cylinderVolume, float temperatureC)
        {
            _engineDetails = string.Format("{0} cc {1} KW", cylinderVolume, power);
        }

        public void VisitSeat(string name, int capacity)
        {
            _seatCount = _seatCount + capacity;
        }

        public string GetCarDescription()
        {
            return string.Format("{0} {1} {2} seat(s)", _carDetails, _engineDetails, _seatCount);
        }

    }
}
