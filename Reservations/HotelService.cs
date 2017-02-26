using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservations
{
    public class HotelService : IHotelService
    {
        public IVacationPart MakeBooking(HotelInfo hotelInfo, DateTime checkin, DateTime checkout)
        {
            Console.WriteLine("Waiting for remote hotel booking service to respond...");
            System.Threading.Thread.Sleep(300); //Waiting for remote service
            Console.WriteLine("Booking hotel {0} {1:dd-MMM-yyyy} - {2:dd-MMM-yyyy}\n", hotelInfo, checkin, checkout);
            return new DummyVacationPart("Hotel " + hotelInfo.ToString());
        }
    }
}
