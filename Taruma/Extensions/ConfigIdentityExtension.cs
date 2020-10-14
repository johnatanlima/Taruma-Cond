using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjections;

namespace Taruma.Extensions
{
    public static class ConfigIdentityExtension
    {
        public static void ToConfigUserIdentity(this IServiceCollection services)
        {
            services.Configure<IdentityOptions>(options =>
            {
                options.User.RequireUniqueEmail = true;
            });
        }

        public static void ToConfigPassUser(this IServiceCollection service)
        {
            service.Configure<IdentityOptions>(options =>
            {
                options.Password.RequiredDigit = true;
                options.Password.RequireLowercase = true;
            });
        }

    }
}