using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointments
{
    class DomainService
    {
        private readonly DataService _dataService;

        public DomainService(DataService dataService)
        {
            _dataService = dataService;
        }

        public IUser RegisterUser(string name, string password)
        {
            IRegistrantUser user = CreateUser(name, password);
            user.Register();
            return user;
        }

        public IUser ChangePassword(string name, string password, string newPassword)
        {
            IRegistrantUser user = CreateUser(name, password);
            user.ChangePassword(newPassword);
            return user;
        }

        private IRegistrantUser CreateUser(string name, string password)
        {
            IUser user = new User(name);
            return new PersistableUser(user, _dataService, password);
        }
    }
}
