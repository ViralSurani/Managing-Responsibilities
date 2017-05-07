using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointments
{
    interface IRegistrationService
    {
        void Register(string name, string password);
        void ChangePassword(string name, string password, string newPassword);
    }
}
