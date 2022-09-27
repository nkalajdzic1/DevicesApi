using DevicesApi.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace DevicesApi.Web.Extensions
{
    public class DatabaseContext
    {
        public static void AddDbContexts(ref IServiceCollection services, IConfiguration configuration)
        {
            // add your db contexts here
            services.AddDbContext<DataContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        }
    }
}
