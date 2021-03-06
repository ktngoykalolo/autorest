// This is my custom license header. I am a nice person so please don't steal
// my code.
//
// Cheers.

namespace AwesomeNamespace.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ProvisioningState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ProvisioningState
    {
        [EnumMember(Value = "Creating")]
        Creating,
        [EnumMember(Value = "ResolvingDNS")]
        ResolvingDNS,
        [EnumMember(Value = "Succeeded")]
        Succeeded
    }
    internal static class ProvisioningStateEnumExtension
    {
        internal static string ToSerializedValue(this ProvisioningState? value)  =>
            value == null ? null : ((ProvisioningState)value).ToSerializedValue();

        internal static string ToSerializedValue(this ProvisioningState value)
        {
            switch( value )
            {
                case ProvisioningState.Creating:
                    return "Creating";
                case ProvisioningState.ResolvingDNS:
                    return "ResolvingDNS";
                case ProvisioningState.Succeeded:
                    return "Succeeded";
            }
            return null;
        }

        internal static ProvisioningState? ParseProvisioningState(this string value)
        {
            switch( value )
            {
                case "Creating":
                    return ProvisioningState.Creating;
                case "ResolvingDNS":
                    return ProvisioningState.ResolvingDNS;
                case "Succeeded":
                    return ProvisioningState.Succeeded;
            }
            return null;
        }
    }
}
