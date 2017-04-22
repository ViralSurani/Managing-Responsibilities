using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop
{
    public interface ICarPartVisitor
    {
        void Visit(Engine engine);
        void Visit(Seat seat);
    }
}
