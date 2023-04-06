

using Application.UseCases.FootballScores;
using Application.UseCases.GetTopArticles;

namespace WebApi.Modules.ServiceCollectionExtensions;

public static class UseCaseExtensions
{
    public static IServiceCollection AddUseCases(this IServiceCollection services)
    {
        services.AddScoped<IFootballScoresUseCase, FootballScoresUseCase>();
        services.AddScoped<IGetTopArticlesUseCase, GetTopArticlesUseCase>();
        return services;
    }
    
}
