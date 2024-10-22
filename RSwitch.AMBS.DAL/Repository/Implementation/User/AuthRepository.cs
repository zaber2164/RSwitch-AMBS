using Microsoft.EntityFrameworkCore;
using RSwitch.AMBS.Model.User;
using RSwitch.AMBS.DAL.Repositories.Interface.User;
using RSwitch.AMBS.Utility;
using RSwitch.AMBS.DAL.Repositories.Interface;
using RSwitch.AMBS.Model.DTO.Auth;

namespace RSwitch.AMBS.DAL.Repositories.Implementation.User
{
    public class AuthRepository : Repository<LoginUser>, IAuthRepository
    {
        public AuthRepository(DbFactory dbFactory, IApplicationConfigurationManager configurationManager, IUnitOfWork unitOfWork) : base(dbFactory, configurationManager)
        {
        }
        public async Task<LoginUser> Authenticate(string userId, string password)
        {
            try
            {
                var loginDetails = await DbSet.FirstOrDefaultAsync(x => x.Login.ToLower().Trim() == userId.ToLower().Trim());
                //var loginDetails = await GetAsync("SELECT * FROM [User]", false);
                if (loginDetails != null)
                {
                    //var isValidUser = await ValidateUser(loginDetails, password);
                    //return isValidUser ? loginDetails : null;
                    //return loginDetails.FirstOrDefault();
                    return loginDetails;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private async Task<bool> ValidateUser(LoginUser user, string password)
        {
            bool status = false;
            string encryptedPassword = Cryptography.EncryptMD5(password);
            if (user.Password != encryptedPassword)
            {
                user.UnsuccessfulLoginAttempts++;
                user.LoginStatus = LoginUser.LoginStatuses.LoggedOut;
                if (user.UnsuccessfulLoginAttempts >= 5)
                {
                    user.IsActive = false;
                }

                await this.UpdateAsync(user);

                //TODO: Insert User Login History

                status = false;
            }
            else
            {
                user.SuccessfulLogin++;
                user.LoginStatus = LoginUser.LoginStatuses.LoggedIn;
                user.LastLoginDate = DateTime.Now;
                if (user.UnsuccessfulLoginAttempts > 0)
                {
                    user.UnsuccessfulLoginAttempts = 0;
                }

                await this.UpdateAsync(user);

                //TODO: Insert User Login History

                status = true;
            }

            return status;
        }
    }
}
