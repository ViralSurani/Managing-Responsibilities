using System.Collections.Generic;

namespace Appointments
{
    class UserGroup : IUserGroup
    {
        private IList<IUser> _member = new List<IUser>();

        public void AddMember(IUser user)
        {
            _member.Add(user);
        }

        public void Accept(System.Func<IUserGroupVisitor> visitorFactory)
        {
            IUserVisitor visitor = visitorFactory();
            foreach (IUser user in _member)
            {
                user.Accept(() => visitor);
            }
        }
    }
}
