using System;

namespace Appointments
{
    class User : IUser
    {
        private readonly string _name;

        public User(string name)
        {
            _name = name;
        }

        public IAppointment MakeAppointment(DateTime startTime)
        {
            return new Meeting(startTime, TimeSpan.FromHours(1));
        }

        public override string ToString()
        {
            return string.Format("User(name-{0})", _name);
        }

        public void Accept(Func<IUserVisitor> visitorFactory)
        {
            visitorFactory().VisitUser(_name);
        }
    }
}
