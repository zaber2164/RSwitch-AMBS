using Microsoft.Extensions.Configuration;
using RSwitch.AMBS.Utility;

namespace RSwitch.AMBS.DAL.Repositories.Implementation
{
    public class ApplicationConfigurationManager: IApplicationConfigurationManager
    {
        private readonly IConfiguration _configuration;

        public ApplicationConfigurationManager(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetConnectionString()
        {
            return UIUtility.DecryptConnectionString(this._configuration.GetConnectionString("DefaultConnection"));
        }

        public IConfigurationSection GetConfigurationSection(string key)
        {
            return this._configuration.GetSection(key);
        }
    }
}
