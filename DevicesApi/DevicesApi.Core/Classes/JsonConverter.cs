using Microsoft.AspNetCore.Http;

namespace DevicesApi.Core.Classes
{
    public class JsonConverter
    {
        public static T? Deserialize<T>(string content)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(content);
        }

        public static T? ReaFileToJson<T>(IFormFile file)
        {
            string fileContent = string.Empty;
            using (var reader = new StreamReader(file.OpenReadStream()))
            {
                fileContent = reader.ReadToEnd();
            }

            return Deserialize<T>(fileContent);
        }
    }
}
