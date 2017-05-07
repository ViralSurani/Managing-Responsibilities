using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointments
{
    interface IRegistrant
    {
        void Register();
        void ChangePassword(string newPassword);
    }
}
