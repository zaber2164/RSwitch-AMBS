namespace RSwitch.AMBS.Web.Contracts.Constants;

/// <summary>
/// HTTP custom header names used in DFS.
/// </summary>
public static class HttpCustomHeaders
{
    /// <summary>
    /// Header name for correlation identifier.
    /// </summary>
    public const string CorrelationId = "X-Correlation-Id";
    public const string RequestId = "X-Request-Id";

    /// <summary>
    /// HTTP custom header names related to user.
    /// </summary>
    public static class User
    {
        /// <summary>
        /// Header name for user identifier.
        /// </summary>
        public const string Id = "X-User-Id";

        /// <summary>
        /// Header name for user's first name.
        /// </summary>
        public const string FirstName = "X-User-FirstName";

        /// <summary>
        /// Header name for user's middle name.
        /// </summary>
        public const string MiddleName = "X-User-MiddleName";

        /// <summary>
        /// Header name for user's last name.
        /// </summary>
        public const string LastName = "X-User-LastName";

        /// <summary>
        /// Header name for user's phone number.
        /// </summary>
        public const string PhoneNumber = "X-User-PhoneNumber";

        /// <summary>
        /// Header name for user's customer identifier in AMBS.
        /// </summary>
        public const string AmbsCustomerId = "X-User-AmbsCustomerId";

        /// <summary>
        /// Header name for user's customer identifier in CBS.
        /// </summary>
        public const string CbsCustomerId = "X-User-CbsCustomerId";
    }

    /// <summary>
    /// HTTP custom header names related to forwarded.
    /// </summary>
    public static class Forwarded
    {
        /// <summary>
        /// Header name for forwarded Proto.
        /// </summary>
        public const string Proto = "X-Forwarded-Proto";

        /// <summary>
        /// Header name for forwarded Host.
        /// </summary>
        public const string Host = "X-Forwarded-Host";

        /// <summary>
        /// Header name for forwarded Prefix.
        /// </summary>
        public const string Prefix = "X-Forwarded-Prefix";
    }

    /// <summary>
    /// Header name for service prefix.
    /// </summary>
    public const string ServicePrefix = "X-Service-Prefix";

    /// <summary>
    /// Header name for session token
    /// </summary>
    public const string SessionToken = "X-Session-Token";

    /// <summary>
    /// Header name for DeviceId
    /// </summary>
    public const string DeviceId = "X-Device-Id";
}
