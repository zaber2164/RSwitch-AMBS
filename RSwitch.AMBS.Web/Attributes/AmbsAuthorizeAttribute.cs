using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Ambs.Next.Mobile.App.Web.Attributes
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class AmbsAuthorizeAttribute : AuthorizeAttribute, IAsyncAuthorizationFilter
    {
        public string Permissions { get; set; } = null;
        public string Commands { get; set; } = null;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public async Task OnAuthorizationAsync(AuthorizationFilterContext context)
        {
            if (string.IsNullOrEmpty(Permissions))
            {
                context.Result = new UnauthorizedResult();
                return;
            }

            //if (context.HttpContext.User.Identity != null && context.HttpContext.User.Identity.IsAuthenticated)
            //{
            //    var userLogin = context.HttpContext.User.Identity.Name;
            //    if (string.IsNullOrEmpty(userLogin))
            //    {
            //        context.Result = new UnauthorizedResult();
            //        return;
            //    }

            //    var userFactory = (UserFactory)context.HttpContext.RequestServices.GetService(typeof(IUserFactory));

            //    if (userFactory == null)
            //    {
            //        throw new Exception("Dependency can not be loaded");
            //    }

            //    var userCommands = (await userFactory.GetUserCommands()).ToList();
            //    if (!userCommands.Any())
            //    {
            //        context.Result = new UnauthorizedResult();
            //        return;
            //    }

            //    var requiredPermissions = Permissions.Split(",");
            //    foreach (var requiredPermission in requiredPermissions)
            //    {
            //        if (userCommands.Any(command => command.PropertyName == requiredPermission))
            //        {
            //            if (!string.IsNullOrEmpty(Commands))
            //            {
            //                var requiredCommands = Commands.Split(",");
            //                foreach (var requiredCommand in requiredCommands)
            //                {
            //                    if (userCommands.Any(command => command.PropertyName == requiredPermission && command.CommandName == requiredCommand))
            //                    {
            //                        return;
            //                    }
            //                }
            //            }
            //            else
            //            {
            //                return;
            //            }
            //        }
            //    }
            //}
            //else
            //{
            //    context.Result = new UnauthorizedResult();
            //    return;
            //}

            context.Result = new UnauthorizedResult();
            return;
        }
    }
}
