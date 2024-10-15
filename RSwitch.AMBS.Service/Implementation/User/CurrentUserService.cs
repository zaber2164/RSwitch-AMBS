using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using RSwitch.AMBS.Service.Interface.User;

namespace RSwitch.AMBS.Service.Implementation.User
{
    public class CurrentUserService : ICurrentUserService
    {
        private readonly IHttpContextAccessor _httpContext;

        public CurrentUserService(IHttpContextAccessor httpContext)
        {
            _httpContext = httpContext;
        }

        public string UserLogin
        {
            get
            {
                return _httpContext.HttpContext.User.FindFirst(x => x.Type == ClaimTypes.Name)?.Value;
            }
        }
    }
}
