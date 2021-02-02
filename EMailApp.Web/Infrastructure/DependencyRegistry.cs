using EMailApp.Business;
using EMailApp.Common;
using EMailApp.Common.Setting;
using Microsoft.Extensions.DependencyInjection;

namespace EMailApp.Web.Infrastructure
{
    public static class DependencyRegistry
    {
        public static void RegisterDependency(this IServiceCollection services, AppSettings appsettings)
        {
            services.AddSingleton(appsettings);
            services.AddScoped<ApplicationContext>();
            BusinessDependencyRegistry.RegisterDependency(services, appsettings);
        }
    }
}
