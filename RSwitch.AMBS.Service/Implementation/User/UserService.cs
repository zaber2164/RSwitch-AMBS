using RSwitch.AMBS.DAL.Repositories.Interface.User;
using RSwitch.AMBS.Model.User;
using RSwitch.AMBS.Service.Interface.User;

namespace RSwitch.AMBS.Service.Implementation.User
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<LoginUser> GetUserDetails(string userLogin)
        {
            return await _userRepository.SingleAsync(x => x.Login == userLogin);
        }
    }
}
