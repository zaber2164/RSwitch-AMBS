namespace Ambs.Next.Mobile.App.Dfs.Accessors
{
    /// <summary>
    /// Defines properties for correlation id accessor.
    /// </summary>
    public interface IHttpHeaderAccessor
    {
        /// <summary>
        /// Gets the correlation identifier.
        /// </summary>
        string? CorrelationId { get; }
        /// <summary>
        /// Gets the request identifier.
        /// </summary>
        string? RequestId { get; }
    }
}
