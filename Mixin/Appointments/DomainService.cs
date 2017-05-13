
namespace Appointments
{
    class DomainService
    {        
        private readonly IUserFactory _userFactory;

        public DomainService(IUserFactory userFactory)
        {            
            _userFactory = userFactory;
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
            IUser user = _userFactory.CreateUser(name);
            return _userFactory.CreateRegistrantUser(user, password);
        }
    }
}
