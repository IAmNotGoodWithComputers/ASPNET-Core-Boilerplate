using DbAccess.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Ioc
{
    public class InversionOfControl
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            var configurationBuilder = new ConfigurationBuilder();
            configurationBuilder.AddEnvironmentVariables();
            var configuration = configurationBuilder.Build();
            
            services.AddDbContext<AppDbContext>(options => options.UseSqlite(configuration.GetValue<string>("DB_CONNECTION")));
        }
    }
}
