using EMailApp.Common.Setting;
using EMailApp.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMailApp.Business
{
    public static class BusinessDependencyRegistry
    {
        public static void RegisterDependency(IServiceCollection services, AppSettings appSettings)
        {
            RepositoryDependencyRegistry.RegisterDependency(services, appSettings);

            services.AddTransient<UserBusiness>();
            services.AddTransient<MailBusiness>();
        }
    }
}
