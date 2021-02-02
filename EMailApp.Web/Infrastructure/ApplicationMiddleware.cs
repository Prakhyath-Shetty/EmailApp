using EMailApp.Common;
using EMailApp.Common.Setting;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace EMailApp.Web.Infrastructure
{
    public static class ApplicationMiddlewareExtensions
    {
        public static IApplicationBuilder UseApplicationMiddleware(this IApplicationBuilder applicationBuilder)
        {
            return applicationBuilder.UseMiddleware<ApplicationMiddleware>();
        }
    }

    public class ApplicationMiddleware
    {
        private readonly RequestDelegate next;

        public ApplicationMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task Invoke(HttpContext context, ApplicationContext applicationContext, IServiceProvider serviceProvider, AppSettings appSettings)
        {
            if (context.User.Identity.IsAuthenticated)
            {
                if (int.TryParse(context.User.Claims.Single(x => x.Type == ClaimTypes.NameIdentifier).Value, out int userId))
                {
                    applicationContext.UserId = userId;
                }
            }

            await this.next.Invoke(context);
        }
    }
}
