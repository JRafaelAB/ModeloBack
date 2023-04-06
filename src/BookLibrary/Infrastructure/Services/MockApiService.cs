using Domain.Interfaces;
using Domain.Models.Responses.mockApi;
using Domain.Utils;
using Infrastructure.RestClients;

namespace Infrastructure.Services;

public class MockApiService : IMockApiService
{
    private readonly IMockApi _mockApi;

    public MockApiService(IMockApi mockApi)
    {
        _mockApi = mockApi;
    }
    
    public async Task<List<ArticlesData>> GetAllArticles()
    {
        var taskList = new List<Task<MockApiArticlesPaginationResponse>>();
        var articleList = new List<ArticlesData>();
        
        var pagination = await _mockApi.GetArticles();

        for (var i = 1; i <= pagination.TotalPages; i++)
        {
            taskList.Add(_mockApi.GetArticles(i));
        }
        
        await Task.WhenAll(taskList);

        articleList = taskList
            .Aggregate(articleList, (current, task) => current
                .Concat(task.Result.Data!)
                .ToList());

        return articleList.FilterArticles();
    }
}
