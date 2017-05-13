using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointments
{
    class RegistrantGroup : IRegistrantGroup, IUserGroupVisitor
    {
        private IUserGroup _group;
        private string _groupName;
        private string _password;

        public RegistrantGroup(IUserGroup group, string groupName, string password)
        {
            _group = group;
            _groupName = groupName;
            _password = password;
        }

        public void AddMember(IUser user)
        {
            _group.AddMember(user);
        }

        public void Register()
        {
            Console.WriteLine("Registering group '{0}' with password '{1}'.", _groupName, _password);
            _group.Accept(() => this);
        }

        public void ChangePassword(string newPassword)
        {
            Console.WriteLine("Changing '{0}' group password group from '{1}' to '{2}'.", _groupName, _password, newPassword);
            _password = newPassword;
        }

        public void VisitUser(string name)
        {
            Console.WriteLine("\tAssociating {0} with group '{1}'", name, _groupName);
        }

        public void Accept(Func<IUserGroupVisitor> visitorFactory)
        {
            _group.Accept(visitorFactory);
        }
    }
}
