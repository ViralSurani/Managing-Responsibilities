using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointments
{
    class PersistableUser : IRegistrantUser, IUserVisitor
    {
        private readonly IUser _user;
        private readonly IRegistrationService _regestrationService;
        private string _password;
        private string _userName;

        public PersistableUser(IUser user, IRegistrationService regestrationService, string password)
        {
            _user = user;
            _regestrationService = regestrationService;
            _password = password;
            _user.Accept(() => this);
        }

        public IAppointment MakeAppointment(DateTime startTime)
        {
            return _user.MakeAppointment(startTime);
        }

        public void Register()
        {
            _regestrationService.Register(_userName, _password);
        }

        public void ChangePassword(string newPassword)
        {
            _regestrationService.ChangePassword(_userName, _password, newPassword);
            _password = newPassword;
        }

        public void Accept(Func<IUserVisitor> visitorFactory)
        {
            _user.Accept(visitorFactory);
        }

        public void VisitUser(string name)
        {
            _userName = name;
        }

        public override string ToString()
        {
            return string.Format("PersistableUser(name={0}, password={1})", _userName, _password);
        }
    }
}
