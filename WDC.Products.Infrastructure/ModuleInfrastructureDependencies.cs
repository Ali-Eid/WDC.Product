using Microsoft.Extensions.DependencyInjection;
using WDC.Products.Infrastructure.Bases.RepositoryBase;

namespace WDC.Products.Infrastructure;

public static class ModuleInfrastructureDependencies
{
    public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services)
    {
        services.AddTransient(typeof(IGenericRepositoryAsync<>), typeof(GenericRepositoryAsync<>));

        return services;
    }
}

