using Microsoft.Extensions.DependencyInjection;
using WDC.Products.Service.ProductServices;

namespace WDC.Products.Service;

public static class ModuleServiceDependencies
{
    public static IServiceCollection AddServiceDependencies(this IServiceCollection services)
    {
        services.AddTransient<IProductService, ProductService>();
        return services;
    }
}