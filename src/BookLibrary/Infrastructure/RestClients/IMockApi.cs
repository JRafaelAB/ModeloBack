using Domain.Models.Responses.mockApi;
using RestEase;

namespace Infrastructure.RestClients;

public interface IMockApi
{
    [Get("articles")]
    Task<MockApiArticlesPaginationResponse> GetArticles([Query("page")] int? Page = null);
}
