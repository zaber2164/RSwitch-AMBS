using RSwitch.AMBS.Web.Middleware;

namespace RSwitch.AMBS.Web.Extensions
{
    public static class GlobalMiddlewareExtension
    {
        public static void UseCorrelationIdLogging(this IApplicationBuilder builder)
        {
            builder.UseMiddleware<HttpHeaderMiddleware>();
        }
        public static void UseGlobalErrorLogging(this IApplicationBuilder builder)
        {
            builder.UseMiddleware<GlobalErrorLoggerMiddleware>();
        }
    }
}
