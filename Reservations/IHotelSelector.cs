using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservations
{
    public interface IHotelSelector
    {
        HotelInfo SelectHotel(string town, string hotelName);
    }
}
