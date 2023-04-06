using Microsoft.AspNetCore.Mvc;
using WebApi.Modules.ServiceCollectionExtensions;
using WebApi.Modules.Swagger;

namespace WebApi.Modules;

internal static class IServiceCollectionExtensions
{
    public static void AddDependencyInjections(this IServiceCollection services, IConfiguration configuration)
    {
        services
            .AddSwagger()
            .AddVersioning()
            .AddHttpClients()
            .AddInfrastructureServices()
            .AddUseCases()
            .AddControllers();

        services.AddCors();
        services.Configure<ApiBehaviorOptions>(options =>
        {
            options.SuppressModelStateInvalidFilter = true;
        });
    }
}
