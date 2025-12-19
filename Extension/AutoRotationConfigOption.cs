#region

using System.Reflection;
using WrathCombo.API.Attribute;

#endregion

namespace WrathCombo.API.Extension;

/// <summary>
///     Extension methods for <see cref="API.Enum.AutoRotationConfigOption" />.
/// </summary>
public static class AutoRotationConfigOption
{
    extension(Enum.AutoRotationConfigOption option)
    {
        /// <summary>
        ///     Gets the expected value type for the given
        ///     <see cref="API.Enum.AutoRotationConfigOption" />.
        /// </summary>
        /// <value>The option to get the value type for.</value>
        /// <value>The expected <see cref="Type" />, or <c>null</c> if not defined.</value>
        public Type? ValueType
        {
            get
            {
                var enumValue = typeof(Enum.AutoRotationConfigOption)
                    .GetField(option.ToString());
                var attr = enumValue?
                    .GetCustomAttribute<ConfigValueTypeAttribute>();
                return attr?.ValueType;
            }
        }
    }
}