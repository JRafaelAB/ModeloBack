using Domain.Interfaces;
using Infrastructure.Services;

namespace WebApi.Modules.ServiceCollectionExtensions;

public static class InfrastructureServicesExtensions
{  
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        services.AddScoped<IMockApiService, MockApiService>();
        return services;
    }
    
}
