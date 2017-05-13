using System;

namespace Appointments
{
    class Program
    {
        static void Main(string[] args)
        {
            DomainService domainService = new DomainService(new UserFactory(new DataService()));

            IUser user = domainService.RegisterUser("viral", "hello");
            Console.WriteLine("{0}\n", user);

            IAppointment appointment = user.MakeAppointment(DateTime.Now.Date.AddHours(40));
            Console.WriteLine("{0}\n", appointment);

            user = domainService.ChangePassword("viral", "hello", "world");
            Console.WriteLine("{0}\n", user);

            Console.ReadKey();
        }
    }
}
