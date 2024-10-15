using Ambs.Next.Mobile.App.Dfs.Accessors;
using RSwitch.AMBS.Web.Helpers;
using RSwitch.AMBS.Web.Contracts.Accessors;
using RSwitch.AMBS.Web.Contracts.Constants;
using Microsoft.AspNetCore.Http;

namespace RSwitch.AMBS.Web.Accessors;

/// <summary>
/// Represents an accessor related to a correlation identifier to read data from HTTP request headers.
/// It implements the <see cref="IHttpHeaderAccessor" /> interface.
/// </summary>
public class HttpHeaderAccessor : IHttpHeaderAccessor
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    private DefinedValue<string?>? _correlationId;
    private DefinedValue<string?>? _requestId;

    /// <summary>
    /// Initializes a new instance of the <see cref="HttpHeaderAccessor"/> class.
    /// </summary>
    /// <param name="httpContextAccessor">The <see cref="IHttpContextAccessor"/> accessor.</param>
    public HttpHeaderAccessor(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    /// <inheritdoc />
    public string? CorrelationId
    {
        get
        {
            if (_correlationId is not null)
            {
                return _correlationId.Value;
            }

            _correlationId = HttpRequestHeadersUtils.GetDefinedValueWithNullableString(_httpContextAccessor.HttpContext,
                HttpCustomHeaders.CorrelationId);
                
            return _correlationId.Value;
        }
    }
    public string? RequestId
    {
        get
        {
            if (_requestId is not null)
            {
                return _requestId.Value;
            }

            _requestId = HttpRequestHeadersUtils.GetDefinedValueWithNullableString(_httpContextAccessor.HttpContext,
                HttpCustomHeaders.RequestId);

            return _requestId.Value;
        }
    }
}
