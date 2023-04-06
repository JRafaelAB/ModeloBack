using Domain.Interfaces;

namespace Application.UseCases.GetTopArticles;

public class GetTopArticlesUseCase : IGetTopArticlesUseCase
{
    private readonly IMockApiService _mockApiService;

    public GetTopArticlesUseCase(IMockApiService mockApiService)
    {
        _mockApiService = mockApiService;
    }

    public async Task<List<string?>> Execute(int limit)
    {
        var articleList = (await _mockApiService.GetAllArticles())
            .OrderByDescending(article => article.NumComments)
            .ThenByDescending(article => article.GetTitle());
            
        
        return articleList.Take(limit)
            .Select(article => article.GetTitle())
            .ToList();
    }
}
