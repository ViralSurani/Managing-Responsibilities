using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservations
{
    public interface IAirplaneService
    {
        IVacationPart SelectFlight(string companyName, string origin, string destination, DateTime travelDate);
    }
}
