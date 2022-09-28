using Microsoft.OpenApi.Models;

namespace DevicesApi.Web.Extensions
{
    public class Swagger
    {
        public static void AddSwaggerConfig(ref IServiceCollection services)
        {
            services.AddSwaggerGen(c => c.SwaggerDoc("v1", new OpenApiInfo { Title = "Devices API", Version = "v1" }));
        }
    }
}
