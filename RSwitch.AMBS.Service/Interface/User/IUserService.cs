using RSwitch.AMBS.Model.User;

namespace RSwitch.AMBS.Service.Interface.User
{
    public interface IUserService
    {
        Task<LoginUser> GetUserDetails(string userLogin);
    }
}
