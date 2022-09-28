using System.Text.Json;

namespace DevicesApi.Web.Extensions
{
    public class JsonOptions
    {
        public static void AddJsonOptions(ref IMvcBuilder mvcBuilder)
        {
            // setup the property naming
            mvcBuilder.AddJsonOptions(o => {
                o.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
                o.JsonSerializerOptions.DictionaryKeyPolicy = JsonNamingPolicy.CamelCase;
                o.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
                o.JsonSerializerOptions.WriteIndented = true;
            });
        }
    }
}
