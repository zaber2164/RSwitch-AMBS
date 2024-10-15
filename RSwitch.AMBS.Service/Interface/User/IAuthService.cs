using RSwitch.AMBS.Model.DTO.Auth;
using RSwitch.AMBS.Model.User;

namespace RSwitch.AMBS.Service.Interface.User
{
    public interface IAuthService
    {
        Task<LoginUser> Authenticate(string userName, string password);
        Task UpdateUserRefreshToken(string userLogin, string refreshToken, DateTime refreshTokenExpiryDate);
        Task<LoginPostResponseDTO> Login(LoginRequestDTO request);
        Task<RefreshTokenPostResponseDTO> RenewJwtToken(string refreshToken, string oldAccessToken);
    }
}
