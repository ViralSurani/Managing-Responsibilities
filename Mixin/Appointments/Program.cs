using System;
using System.Collections;
using System.Collections.Generic;

namespace Appointments
{
    class Program
    {
        private static void MassRegister(IEnumerable<IRegistrant> registrants)
        {
            foreach (IRegistrant registrant in registrants)
            {
                registrant.Register();
            }
        }

        private static void ScramblePasswords(IEnumerable<IRegistrant> registrants)
        {
            foreach (IRegistrant registrant in registrants)
            {
                registrant.ChangePassword(Guid.NewGuid().ToString().Substring(0, 6));
            }
        }

        static void Main(string[] args)
        {
            DomainService domainService = new DomainService(new UserFactory(new DataService()));

            //IUser user = domainService.RegisterUser("viral", "hello");
            //IUser jil = domainService.RegisterUser("jil", "pwd");
            //IUser joe = domainService.RegisterUser("joe", "pwd");
            //IUser jack = domainService.RegisterUser("jack", "pwd");

            IUser user = new User("viral");
            IUser jil = new User("jil");
            IUser joe = new User("joe");
            IUser jack = new User("jack");

            IUserGroup group = new UserGroup();
            group.AddMember(user);
            group.AddMember(jil);
            group.AddMember(joe);
            group.AddMember(jack);

            DataService dataService = new DataService();
            IEnumerable<IRegistrant> registrants = new IRegistrant[]
            {
                new PersistableUser(user,dataService,"pwd"),
                new PersistableUser(user,dataService,"pwd"),
                new PersistableUser(user,dataService,"pwd"),
                new PersistableUser(user,dataService,"pwd"),
                new RegistrantGroup(group,"friends","secret")
            };

            MassRegister(registrants);

            ScramblePasswords(registrants);

            //IRegistrantGroup reGroup = new RegistrantGroup(group,"friends","secret");
            //reGroup.Register();

            //Console.WriteLine("{0}\n", user);

            //IAppointment appointment = user.MakeAppointment(DateTime.Now.Date.AddHours(40));
            //Console.WriteLine("{0}\n", appointment);

            //user = domainService.ChangePassword("viral", "hello", "world");
            //Console.WriteLine("{0}\n", user);

            Console.ReadKey();
        }
    }
}
