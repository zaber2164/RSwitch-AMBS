using Ambs.Next.Mobile.App.Dfs.Accessors;
using RSwitch.AMBS.Web.Accessors;
using RSwitch.AMBS.Web.Contracts.Accessors;
using Microsoft.Extensions.DependencyInjection;

namespace RSwitch.AMBS.Web.Extensions;

/// <summary>
/// Extensions for Accessors in IServiceCollection used in VecCtor apps.
/// </summary>
public static class AccessorsExtensions
{
    /// <summary>
    /// Adds <see cref="CurrentUserHttpAccessor"/> as scoped to <see cref="IServiceCollection"/>
    /// including AddHttpContextAccessor. 
    /// </summary>
    /// <param name="services">The <see cref="IServiceCollection"/> services.</param>
    public static IServiceCollection AddCurrentUserHttpAccessor(this IServiceCollection services)
    {
        services.AddHttpContextAccessor();
        services.AddScoped<ICurrentUserAccessor, CurrentUserHttpAccessor>();

        return services;
    }

    /// <summary>
    /// Adds <see cref="HttpHeaderAccessor"/> as scoped to <see cref="IServiceCollection"/>
    /// including AddHttpContextAccessor. 
    /// </summary>
    /// <param name="services">The <see cref="IServiceCollection"/> services.</param>
    public static IServiceCollection AddCorrelationIdHttpAccessor(this IServiceCollection services)
    {
        services.AddHttpContextAccessor();
        services.AddScoped<IHttpHeaderAccessor, HttpHeaderAccessor>();

        return services;
    }
    /// <summary>
    /// Adds <see cref="HttpHeaderAccessor"/> as scoped to <see cref="IServiceCollection"/>
    /// including AddHttpContextAccessor. 
    /// </summary>
    /// <param name="services">The <see cref="IServiceCollection"/> services.</param>
    public static IServiceCollection AddRequestIdHttpAccessor(this IServiceCollection services)
    {
        services.AddHttpContextAccessor();
        services.AddScoped<IHttpHeaderAccessor, HttpHeaderAccessor>();

        return services;
    }
}
