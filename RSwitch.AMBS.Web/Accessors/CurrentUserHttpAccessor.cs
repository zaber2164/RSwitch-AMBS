using RSwitch.AMBS.Web.Helpers;
using RSwitch.AMBS.Web.Contracts.Accessors;
using RSwitch.AMBS.Web.Contracts.Constants;
using Microsoft.AspNetCore.Http;
using System.ComponentModel;
using System.Net.Http;

namespace RSwitch.AMBS.Web.Accessors;

/// <summary>
/// Represents an accessor related to a current user to read data from HTTP request headers.
/// It implements the <see cref="ICurrentUserAccessor" /> interface.
/// </summary>
public class CurrentUserHttpAccessor : ICurrentUserAccessor 
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    private DefinedValue<Guid?>? _userId;

    private DefinedValue<string?>? _userFirstName;

    private DefinedValue<string?>? _userMiddleName;

    private DefinedValue<string?>? _userLastName;

    private DefinedValue<string?>? _userFullName;

    private DefinedValue<string?>? _userPhoneNumber;

    private DefinedValue<long?>? _ambsCustomerId;

    private DefinedValue<string?>? _cbsCustomerId;

    private DefinedValue<string?>? _deviceId;

    /// <summary>
    /// Initializes a new instance of the <see cref="CurrentUserHttpAccessor"/> class.
    /// </summary>
    /// <param name="httpContextAccessor">The <see cref="IHttpContextAccessor"/> accessor.</param>
    public CurrentUserHttpAccessor(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    /// <inheritdoc />
    public Guid? UserId
    {
        get
        {
            if (_userId is not null)
            {
                return _userId.Value;
            }

            _userId = HttpRequestHeadersUtils.GetDefinedValueWithNullableGuid(_httpContextAccessor.HttpContext,
                HttpCustomHeaders.User.Id);

            return _userId.Value;
        }
    }

    /// <inheritdoc />
    public string? UserFirstName
    {
        get
        {
            if (_userFirstName is not null)
            {
                return _userFirstName.Value;
            }

            _userFirstName = HttpRequestHeadersUtils.GetDefinedValueWithNullableString(_httpContextAccessor.HttpContext,
                HttpCustomHeaders.User.FirstName);

            return _userFirstName.Value;
        }
    }

    /// <inheritdoc />
    public string? UserMiddleName
    {
        get
        {
            if (_userMiddleName is not null)
            {
                return _userMiddleName.Value;
            }

            _userMiddleName = HttpRequestHeadersUtils.GetDefinedValueWithNullableString(_httpContextAccessor.HttpContext,
                HttpCustomHeaders.User.MiddleName);

            return _userMiddleName.Value;
        }
    }

    /// <inheritdoc />
    public string? UserLastName
    {
        get
        {
            if (_userLastName is not null)
            {
                return _userLastName.Value;
            }

            _userLastName = HttpRequestHeadersUtils.GetDefinedValueWithNullableString(_httpContextAccessor.HttpContext,
                HttpCustomHeaders.User.LastName);

            return _userLastName.Value;
        }
    }

    /// <inheritdoc />
    public string? UserFullName
    {
        get
        {
            if (_userFullName is not null)
            {
                return _userFullName.Value;
            }

            var firstName = UserFirstName;
            var middleName = UserMiddleName;
            var lastName = UserLastName;

            if (string.IsNullOrEmpty(firstName) && 
                string.IsNullOrEmpty(middleName) && 
                string.IsNullOrEmpty(lastName))
            {
                _userFullName = new DefinedValue<string?>
                {
                    Value = null,
                };

                return _userFullName.Value;
            }

            var fullName = $"{firstName} {middleName}".TrimEnd();
            fullName = $"{fullName} {lastName}";

            _userFullName = new DefinedValue<string?>
            {
                Value = fullName,
            };

            return _userFullName.Value;
        }
    }

    /// <inheritdoc />
    public string? UserPhoneNumber
    {
        get
        {
            if (_userPhoneNumber is not null)
            {
                return _userPhoneNumber.Value;
            }

            _userPhoneNumber = HttpRequestHeadersUtils.GetDefinedValueWithNullableString(_httpContextAccessor.HttpContext,
                HttpCustomHeaders.User.PhoneNumber);

            return _userPhoneNumber.Value;
        }
    }

    /// <inheritdoc />
    public long? AmbsCustomerId
    {
        get
        {
            if (_ambsCustomerId is not null)
            {
                return _ambsCustomerId.Value;
            }

            _ambsCustomerId = HttpRequestHeadersUtils.GetDefinedValueWithNullableLong(_httpContextAccessor.HttpContext,
                HttpCustomHeaders.User.AmbsCustomerId);

            return _ambsCustomerId.Value;
        }
    }

    /// <inheritdoc />
    public string? CbsCustomerId
    {
        get
        {
            if (_cbsCustomerId is not null)
            {
                return _cbsCustomerId.Value;
            }

            _cbsCustomerId = HttpRequestHeadersUtils.GetDefinedValueWithNullableString(_httpContextAccessor.HttpContext,
                HttpCustomHeaders.User.CbsCustomerId);

            return _cbsCustomerId.Value;
        }
    }

    /// <inheritdoc />
    public string? DeviceId
    {
        get
        {
            if (_deviceId is not null)
            {
                return _deviceId.Value;
            }

            _deviceId = HttpRequestHeadersUtils.GetDefinedValueWithNullableString(_httpContextAccessor.HttpContext,
                HttpCustomHeaders.DeviceId);

            return _deviceId.Value;
        }
    }

    /// <inheritdoc />
    public T? GetClaimValue<T>(string key)
    {
        var claim = _httpContextAccessor.HttpContext?.User.Claims.FirstOrDefault(x => x.Type == key)?.Value;

        if (claim == null)
        {
            throw new KeyNotFoundException($"User claim of type: '{key}' not found");
        }

        return (T?)TypeDescriptor.GetConverter(typeof(T)).ConvertFrom(claim);
    }
}
