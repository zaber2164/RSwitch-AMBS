namespace RSwitch.AMBS.Web.Helpers;

/// <summary>
/// Represents a value already defined.
/// </summary>
/// <typeparam name="T">Value type.</typeparam>
public class DefinedValue<T>
{
    /// <summary>
    /// Gets the value.
    /// </summary>
    public T Value { get; init; } = default!;
}
