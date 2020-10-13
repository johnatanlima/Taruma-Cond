using Microsoft.Extensions.DependencyInjection;
using System;
using System.Xml.Serialization;
using Taruma.DAL.Interfaces;
using Taruma.DAL.Repositories;

namespace Taruma.DAL
{ 
	public static class RepositoryConfigExtension
	{
		public static void ToConfigRepositories(this IServiceCollection services)
        {
			services.AddTransient<IUserRepository, UserRepository>();
		}


	}
}
