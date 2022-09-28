using System.Text.Json.Serialization;

namespace DevicesApi.Core.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum SortOrder
    {
        Asc = 0,
        Desc = 1
    }
}


