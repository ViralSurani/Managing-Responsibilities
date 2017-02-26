using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservations
{
    public class Application
    {
        private IVacationPartFactory vacationPartFactory;

        public Application(IVacationPartFactory vactionPartFactory)
        {
            this.vacationPartFactory = vactionPartFactory;
        }

        public void Run()
        {
            VacationSpecificationBuilder builder = new VacationSpecificationBuilder(this.vacationPartFactory, new DateTime(2015, 7, 11), 14, "Crouded City", "Seatown");

            builder.SelectHotel("Small one");
            builder.SelectAirplane("Noisy one");

            VacationSpecification spec = builder.BuildVacation();
        }
    }
}
