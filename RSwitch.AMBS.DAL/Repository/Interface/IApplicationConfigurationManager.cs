using Microsoft.Extensions.Configuration;

namespace RSwitch.AMBS.DAL.Repositories.Interface
{
    public interface IApplicationConfigurationManager
    {
        string GetConnectionString();

        IConfigurationSection GetConfigurationSection(string key);
    }
}