using Microsoft.Extensions.DependencyInjection;
using Solid_Principle_Services;

namespace Solid_Principle_DependencyInjectionExtensions
{
	public static class IServiceCollectionExtensions
	{
		public static void RegisterServicesAndRepositories(this IServiceCollection services)
		{
			services.Scan(selector => selector
				.FromAssemblies(
				  typeof(IBookService).Assembly
				).AddClasses()
				.AsImplementedInterfaces()
				.WithScopedLifetime());
		}
	}
}
