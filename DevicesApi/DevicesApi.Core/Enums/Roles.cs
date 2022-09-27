using System.Text.Json.Serialization;

namespace DevicesApi.Core.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Roles
    {
        User = 0,
        Guest = 1,
        Admin = 2
    }
}
