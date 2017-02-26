using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservations
{
    public class DummyVacationPart: IVacationPart
    {
        private string name;

        public DummyVacationPart(string name)
        {
            this.name = name;
        }

        public void Reserve()
        {
            Console.WriteLine("Making reservation - {0}", this.name);
        }

        public void Purchase()
        {
            Console.WriteLine("Purchasing {0}", this.name);
        }

        public void Cancel()
        {
            throw new NotImplementedException();
        }
    }
}
