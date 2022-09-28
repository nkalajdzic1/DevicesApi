using Microsoft.Extensions.Configuration;

namespace DevicesApi.Core.Classes
{
    public class Config
    {
        // read appsettings.json and set the file for the config
        private static readonly IConfiguration _configuration = new ConfigurationBuilder()
                .AddJsonFile(Path.Combine(path1: Directory.GetParent(path: Directory.GetCurrentDirectory()).FullName,
                                          "DevicesApi.Web",
                                          "appsettings.json"), optional: false)
                .Build();

        // get database connection string from appsettings.json
        public static string GetConnectionString() => _configuration.GetConnectionString("DefaultConnection");

    }
}
