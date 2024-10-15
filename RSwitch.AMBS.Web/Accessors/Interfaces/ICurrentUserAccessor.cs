namespace RSwitch.AMBS.Web.Contracts.Accessors;

/// <summary>
/// Defines accessor related to a current user.
/// </summary>
public interface ICurrentUserAccessor
{
    /// <summary>
    /// Gets the user identifier.
    /// </summary>
    Guid? UserId { get; }

    /// <summary>
    /// Gets the user's first name.
    /// </summary>
    string? UserFirstName { get; }

    /// <summary>
    /// Gets the user's middle name.
    /// </summary>
    string? UserMiddleName { get; }

    /// <summary>
    /// Gets the user's last name.
    /// </summary>
    string? UserLastName{ get; }

    /// <summary>
    /// Gets the user's full name.
    /// </summary>
    string? UserFullName { get; }

    /// <summary>
    /// Gets the user's phone number.
    /// </summary>
    string? UserPhoneNumber { get; }

    /// <summary>
    /// Gets the customer (member) identifier in AMBS.
    /// </summary>
    long? AmbsCustomerId { get; }

    /// <summary>
    /// Gets the customer identifier in CBS.
    /// </summary>
    string? CbsCustomerId { get; }

    /// <summary>
    /// Gets the device's identifier.
    /// </summary>
    string? DeviceId { get; }

    /// <summary>
    /// Gets a claim value of given type for a given key as a type name.
    /// </summary>
    /// <typeparam name="T">Type of return value.</typeparam>
    /// <param name="key">Type name in claims.</param>
    /// <returns>Value of a given type.</returns>
    T? GetClaimValue<T>(string key);
}
