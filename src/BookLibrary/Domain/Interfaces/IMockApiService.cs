using Domain.Models.Responses.mockApi;

namespace Domain.Interfaces;

public interface IMockApiService
{
    Task<List<ArticlesData>> GetAllArticles();
}
