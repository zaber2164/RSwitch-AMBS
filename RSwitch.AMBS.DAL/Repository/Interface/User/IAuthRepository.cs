using RSwitch.AMBS.Model.User;

namespace RSwitch.AMBS.DAL.Repositories.Interface.User
{
    public interface IAuthRepository: IRepository<LoginUser>
    {
        Task<LoginUser> Authenticate(string userId, string password);
    }
}
