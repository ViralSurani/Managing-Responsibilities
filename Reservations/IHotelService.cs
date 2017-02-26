using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservations
{
    public interface IHotelService
    {
        IVacationPart MakeBooking(HotelInfo hotelInfo, DateTime checkin, DateTime checkout);
    }
}
