using RSwitch.AMBS.DAL;
using Microsoft.EntityFrameworkCore;
using RSwitch.AMBS.DAL.Repositories.Interface;
using RSwitch.AMBS.DAL.Repositories.Implementation;
using RSwitch.AMBS.Utility;
using RSwitch.AMBS.Service.Implementation;
using RSwitch.AMBS.Service.Interface.User;
using RSwitch.AMBS.Service.Implementation.User;
using RSwitch.AMBS.DAL.Repositories.Interface.User;
using RSwitch.AMBS.DAL.Repositories.Implementation.User;
using RSwitch.AMBS.DAL.ConfigurationManager;
using RSwitch.AMBS.Model.DTO.Auth;
using RSwitch.AMBS.Validation;
using FluentValidation;
using RSwitch.AMBS.Service.Interface;

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

                .AddScoped<IBranchRepository, BranchRepository>()
                .AddScoped<IAuthRepository, AuthRepository>()
                .AddScoped<IUserRepository, UserRepository>();
        }
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            return services
                .AddScoped<IBranchService, BranchService>()
                .AddScoped<IAuthService, AuthService>()
                .AddScoped<IUserService, UserService>();
        }
        public static IServiceCollection AddFluentValidators(this IServiceCollection services)
        {
            return services
                .AddScoped<IValidator<LoginRequestDTO>, LoginRequestValidator>();
        }
    }
}
