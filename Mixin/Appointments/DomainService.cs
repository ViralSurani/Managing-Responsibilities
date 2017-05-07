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
            _dataService.RegisterUser(name, password);
            return new User(name, password);
        }

        public IUser ChangePassword(string name, string password, string newPassword)
        {
            _dataService.ChangePassword(name, password, newPassword);
            return new User(name, newPassword);
        }
    }
}
