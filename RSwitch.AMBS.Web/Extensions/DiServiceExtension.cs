using RSwitch.AMBS.DAL;
using Microsoft.EntityFrameworkCore;
using RSwitch.AMBS.DAL.Repositories.Interface;
using RSwitch.AMBS.DAL.Repositories.Implementation;
using RSwitch.AMBS.Utility;
using RSwitch.AMBS.Service.Implementation;

namespace RSwitch.AMBS.Web.Extensions
{
    public static class DiServiceExtension
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            var cs = UIUtility.DecryptConnectionString(configuration.GetConnectionString("DefaultConnection"));
            services.AddDbContext<RswitchDbContext>(options =>
            {
                options.UseSqlServer(cs);
            });

            services.AddScoped<Func<RswitchDbContext>>((provider) => provider.GetService<RswitchDbContext>);
            services.AddScoped<DbFactory>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            return services
                .AddSingleton<IApplicationConfigurationManager, ApplicationConfigurationManager>()
                .AddScoped(typeof(IRepository<>), typeof(Repository<>))

                .AddScoped<IBranchRepository, BranchRepository>();
        }
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            return services
                .AddScoped<BranchService, BranchService>();
        }
    }
}
