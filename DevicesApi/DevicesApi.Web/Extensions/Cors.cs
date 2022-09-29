using DevicesApi.Core.Constants;

namespace DevicesApi.Web.Extensions
{
    public class Cors
    {
        public static void AddCors(IApplicationBuilder app)
        {
            app.UseCors(options => options.WithOrigins(
                            "https://localhost:3000",
                            "http://localhost:3000"
                       ).AllowAnyMethod()
                        .AllowAnyHeader()
                        .WithExposedHeaders(Headers.XTotalCount)
            );
        }
    }
}
