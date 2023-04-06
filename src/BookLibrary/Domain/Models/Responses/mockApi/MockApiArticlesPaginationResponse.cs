using Newtonsoft.Json;

namespace Domain.Models.Responses.mockApi;

public class MockApiArticlesPaginationResponse
{
    [JsonProperty("page")]
    public long Page { get; set; }

    [JsonProperty("per_page")]
    public long PerPage { get; set; }

    [JsonProperty("total")]
    public long Total { get; set; }

    [JsonProperty("total_pages")]
    public long TotalPages { get; set; }

    [JsonProperty("data")]
    public IEnumerable<ArticlesData>? Data { get; set; }
    
}
