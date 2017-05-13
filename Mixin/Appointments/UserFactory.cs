
namespace Appointments
{
    class UserFactory : IUserFactory
    {
        private readonly DataService _dataService;

        public UserFactory(DataService dataService)
        {
            _dataService = dataService;
        }

        public IUser CreateUser(string name)
        {
            return new User(name);
        }

        public IRegistrantUser CreateRegistrantUser(IUser user, string password)
        {
            return new PersistableUser(user,_dataService,password);
        }
    }
}
