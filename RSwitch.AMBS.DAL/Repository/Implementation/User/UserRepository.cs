using RSwitch.AMBS.DAL.Repositories.Interface.User;
using RSwitch.AMBS.Model.User;

namespace RSwitch.AMBS.DAL.Repositories.Implementation.User
{
    public class UserRepository : Repository<LoginUser>, IUserRepository
    {
        public UserRepository(DbFactory dbFactory, IApplicationConfigurationManager configurationManager) : base(dbFactory, configurationManager)
        {
        }
    }
}
