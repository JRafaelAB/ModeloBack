using Infrastructure.RestClients;
using RestEase.HttpClientFactory;

namespace WebApi.Modules.ServiceCollectionExtensions;

public static class HttpClientsExtensions
{
    public static IServiceCollection AddHttpClients(this IServiceCollection services)
    {
        services.AddRestEaseClient<IMockApi>("http://mock-api.hypnobox.com.br:4011/teste/api/");
        return services;
    }
    
}
