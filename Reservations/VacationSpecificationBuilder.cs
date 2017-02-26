using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservations
{
    public class VacationSpecificationBuilder
    {
        private IVacationPartFactory vacationPartFactory;

        private IList<IVacationPart> parts = new List<IVacationPart>();

        private DateTime arrivalDate;
        private int totalNights;

        private string livingTown;
        private string destinationTown;

        public VacationSpecificationBuilder(IVacationPartFactory vacationPartFactory, DateTime arrivalDate, int totalNights, string livingTown, string destinationTown)
        {
            this.vacationPartFactory = vacationPartFactory;

            this.arrivalDate = arrivalDate;
            this.totalNights = totalNights;

            this.livingTown = livingTown;
            this.destinationTown = destinationTown;
        }

        public void SelectHotel(string hotelName)
        {
            IVacationPart part = this.vacationPartFactory.CreateHotelReservation(this.destinationTown, hotelName, this.arrivalDate, this.arrivalDate.AddDays(this.totalNights));
            parts.Add(part);
        }

        public void SelectAirplane(string companyName)
        {
            this.parts.Add(CreateFlightToDestination(companyName));
            this.parts.Add(CreateFlightBack(companyName));
        }

        private IVacationPart CreateFlightToDestination(string companyName)
        {
            return this.vacationPartFactory.CreateFlight(companyName, this.livingTown, this.destinationTown, this.arrivalDate);
        }

        private IVacationPart CreateFlightBack(string comapnyName)
        {
            return this.vacationPartFactory.CreateFlight(comapnyName, this.destinationTown, this.livingTown, this.arrivalDate.AddDays(this.totalNights));
        }

        public VacationSpecification BuildVacation()
        {
            foreach (IVacationPart part in parts)
                part.Reserve();
            return new VacationSpecification(this.parts);
        }
    }
}
