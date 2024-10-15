using Microsoft.AspNetCore.Http;

namespace RSwitch.AMBS.Web.Helpers;

/// <summary>
/// Utils for reading data from reqet headers.
/// </summary>
public static class HttpRequestHeadersUtils
{
    /// <summary>
    /// Reads a value as string from a HTTP request header with a given name.
    /// </summary>
    /// <param name="httpContext">The <see cref="HttpContext" /> context.</param>
    /// <param name="headerName">The header's name.</param>
    /// <returns>Returns a value read from header as string.</returns>
    public static string? ReadValueAsString(HttpContext? httpContext, string headerName)
    {
        if (httpContext is null || !httpContext.Request.Headers.TryGetValue(headerName, out var headerValue))
        {
            return null;
        }

        return headerValue.ToString();
    }

    /// <summary>
    /// Gets a defined value of nullable string based on a value read from a HTTP request header with a given name.
    /// </summary>
    /// <param name="httpContext">The <see cref="HttpContext" /> context.</param>
    /// <param name="headerName">The header's name.</param>
    /// <returns>Returns a defined value of string?.</returns>
    public static DefinedValue<string?> GetDefinedValueWithNullableString(HttpContext? httpContext, string headerName)
    {
        var strValue = ReadValueAsString(httpContext, headerName);

        return new DefinedValue<string?>
        {
            Value = strValue
        };
    }

    /// <summary>
    /// Gets a defined value of nullable Guid based on a value read from a HTTP request header with a given name.
    /// </summary>
    /// <param name="httpContext">The <see cref="HttpContext" /> context.</param>
    /// <param name="headerName">The header's name.</param>
    /// <returns>Returns a defined value of Guid?.</returns>
    public static DefinedValue<Guid?> GetDefinedValueWithNullableGuid(HttpContext? httpContext, string headerName)
    {
        var strValue = ReadValueAsString(httpContext, headerName);

        return new DefinedValue<Guid?>
        {
            Value = !string.IsNullOrEmpty(strValue) ? Guid.Parse(strValue) : null
        };
    }

    /// <summary>
    /// Gets a defined value of nullable long based on a value read from a HTTP request header with a given name.
    /// </summary>
    /// <param name="httpContext">The <see cref="HttpContext" /> context.</param>
    /// <param name="headerName">The header's name.</param>
    /// <returns>Returns a defined value of long?.</returns>
    public static DefinedValue<long?> GetDefinedValueWithNullableLong(HttpContext? httpContext, string headerName)
    {
        var strValue = ReadValueAsString(httpContext, headerName);

        return new DefinedValue<long?>
        {
            Value = !string.IsNullOrEmpty(strValue) ? Convert.ToInt64(strValue) : null
        };
    }

    /// <summary>
    /// Gets a defined value of nullable int based on a value read from a HTTP request header with a given name.
    /// </summary>
    /// <param name="httpContext">The <see cref="HttpContext" /> context.</param>
    /// <param name="headerName">The header's name.</param>
    /// <returns>Returns a defined value of int?.</returns>
    public static DefinedValue<int?> GetDefinedValueWithNullableInt(HttpContext? httpContext, string headerName)
    {
        var strValue = ReadValueAsString(httpContext, headerName);

        return new DefinedValue<int?>
        {
            Value = !string.IsNullOrEmpty(strValue) ? Convert.ToInt32(strValue) : null
        };
    }
}
