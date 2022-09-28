using Microsoft.EntityFrameworkCore;

using DevicesApi.Core.Classes;
using DevicesApi.Infrastructure.Data;

namespace DevicesApi.Web.Extensions
{
    public class DatabaseContext
    {
        public static void AddDbContexts(ref IServiceCollection services)
        {
            // add db contexts
            services.AddDbContext<DataContext>(options => options.UseSqlServer(Config.GetConnectionString()));
        }
    }
}
