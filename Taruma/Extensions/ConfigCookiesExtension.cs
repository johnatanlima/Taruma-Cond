using System;
using System.Diagnostics;
using Taruma.Extensions

namespace Taruma.Extensions
{
	public static class ConfigCookiesExtension
	{
		public static void ToConfigCookies(this IServiceCollection service)
        {
            service.ConfigureApplicationCookie(options =>
            {

                options.Cookie.Name = "IdentityCookie";
                options.Cookie.HttpOnly = true;
                options.ExpireTimespan = TimeSpan.FromMinutes(60);
                options.LoginPath = "UsersLogin";
            });
            
        }
	}
}