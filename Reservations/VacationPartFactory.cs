using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservations
{
    public class VacationPartFactory : IVacationPartFactory
    {
        private IHotelSelector hotelSelector;
        private IHotelService hotelService;
        private IAirplaneService airplanService;

        public VacationPartFactory(IHotelSelector hotelSelector, IHotelService hotelService, IAirplaneService airplanService)
        {
            this.hotelSelector = hotelSelector;
            this.hotelService = hotelService;
            this.airplanService = airplanService;
        }

        public IVacationPart CreateHotelReservation(string town, string hotelName, DateTime arrivalDate, DateTime leaveDate)
        {
            HotelInfo hotelInfo = this.hotelSelector.SelectHotel(town, hotelName);
            return this.hotelService.MakeBooking(hotelInfo, arrivalDate, leaveDate);
        }

        public IVacationPart CreateFlight(string companyName, string source, string destination, DateTime date)
        {
            return this.airplanService.SelectFlight(companyName, source, destination, date);
        }

        public IVacationPart CreateFerryBooking(string lineName, bool fromMainland, DateTime date)
        {
            throw new NotImplementedException();
        }

        public IVacationPart CreateDailyTrip(string tripName, DateTime date)
        {
            throw new NotImplementedException();
        }

        public IVacationPart CreateMassage(string salon, DateTime date)
        {
            throw new NotImplementedException();
        }
    }
}
