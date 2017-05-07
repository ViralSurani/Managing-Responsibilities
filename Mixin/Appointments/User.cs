using System;

namespace Appointments
{
    class User : IUser
    {
        private readonly string _name;
        private readonly string _password;

        public User(string name, string password)
        {
            _name = name;
            _password = password;
        }

        public IAppointment MakeAppointment(DateTime startTime)
        {
            return new Meeting(startTime, TimeSpan.FromHours(1));
        }

        public override string ToString()
        {
            return string.Format("User(name-{0} password-{1})", _name, _password);
        }
    }
}
