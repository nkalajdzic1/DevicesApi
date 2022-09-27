using DevicesApi.Core.Interfaces;
using DevicesApi.Infrastructure.Services;

namespace DevicesApi.Web.Extensions
{
    public class Scoped
    {
        public static void AddScopedConfig(ref IServiceCollection services)
        {
            // add services and their interfaces here
            services.AddScoped<IDeviceService, DeviceService>();
        }
    }
}
