using System.ComponentModel;
using System.Text.Json.Serialization;


namespace DevicesApi.Core.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum InstallationPosition
    {
        [Description("horizontal")]
        Horizontal = 0,

        [Description("vertical")]
        Vertical = 1,
    }

    public static class InstallationPositionsExtensions
    {
        public static string GetDescriptionString(this InstallationPosition val)
        {
            #pragma warning disable CS8602 // Dereference of a possibly null reference.
            DescriptionAttribute[] attributes = (DescriptionAttribute[])val.GetType().GetField(val.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), false);
            #pragma warning restore CS8602 // Dereference of a possibly null reference.
            
            return attributes.Length > 0 ? attributes[0].Description : string.Empty;
        }
    }
}


