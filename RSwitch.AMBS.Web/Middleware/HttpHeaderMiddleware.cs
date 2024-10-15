using Microsoft.Extensions.Primitives;

namespace RSwitch.AMBS.Web.Middleware
{
    public class HttpHeaderMiddleware
    {
        private const string CorrelationIdHeaderKey = "X-Correlation-Id";
        private const string RequestIdHeaderKey = "X-Request-Id";
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;
        public HttpHeaderMiddleware(RequestDelegate next,
        ILoggerFactory loggerFactory)
        {
            _next = next ?? throw new ArgumentNullException(nameof(next));
            _logger = loggerFactory.CreateLogger<HttpHeaderMiddleware>();
        }
        public async Task Invoke(HttpContext httpContext)
        {
            string correlationId = null;
            string requestId = null;
            if (httpContext.Request.Headers.TryGetValue(
            CorrelationIdHeaderKey, out StringValues correlationIds))
            {
                //correlationId = correlationIds.FirstOrDefault(k => k.Equals(CorrelationIdHeaderKey));
                correlationId = correlationIds.FirstOrDefault();
                _logger.LogInformation($"CorrelationId from Request Header:{ correlationId}");
            }
            if (httpContext.Request.Headers.TryGetValue(
            RequestIdHeaderKey, out StringValues requestIds))
            {
                requestId = requestIds.FirstOrDefault();
                _logger.LogInformation($"RequestId from Request Header:{ requestId}");
            }
            //else
            //{
            //    correlationId = Guid.NewGuid().ToString();
            //    httpContext.Request.Headers.Add(CorrelationIdHeaderKey,
            //    correlationId);
            //    _logger.LogInformation($"Generated CorrelationId:{ correlationId}");
            //}
            httpContext.Response.OnStarting(() =>
            {
                if (!httpContext.Response.Headers.
                TryGetValue(CorrelationIdHeaderKey,
                out correlationIds))
                    httpContext.Response.Headers.Add(
                    CorrelationIdHeaderKey, correlationId);
                return Task.CompletedTask;
                
                if (!httpContext.Response.Headers.
                TryGetValue(RequestIdHeaderKey,
                out requestIds))
                    httpContext.Response.Headers.Add(
                    RequestIdHeaderKey, requestId);
                return Task.CompletedTask;
            });
            await _next.Invoke(httpContext);
        }
    }
}
