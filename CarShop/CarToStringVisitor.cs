using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop
{
    class CarToStringVisitor : ICarVisitor
    {
        private string _report;
        private int _seatCount;

        public void Visit(Engine engine)
        {
            _report = string.Format("{0} cc {1} KW", engine.CylinderVolumn, engine.Power);
        }

        public void Visit(Seat seat)
        {
            _seatCount = _seatCount + seat.Capacity;
        }

        public string GetCarDescription()
        {
            return _report + string.Format(" {0} seats", _seatCount);
        }

        public void Visit(Car car)
        {
            //???
            //we are stuck            
        }
    }
}
