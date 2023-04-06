using Newtonsoft.Json;

namespace Domain.Models.Responses.mockApi;

public class ArticlesData
{
    [JsonProperty("title")]
    public string? Title { get; set; }

    [JsonProperty("url")]
    public string? Url { get; set; }

    [JsonProperty("author")]
    public string? Author { get; set; }

    [JsonProperty("num_comments")]
    public long? NumComments { get; set; }

    [JsonProperty("story_id")]
    public string? StoryId { get; set; }

    [JsonProperty("story_title")]
    public string? StoryTitle { get; set; }

    [JsonProperty("story_url")]
    public string? StoryUrl { get; set; }

    [JsonProperty("parent_id")]
    public long? ParentId { get; set; }

    [JsonProperty("created_at")]
    public long CreatedAt { get; set; }

    public string? GetTitle()
    {
        return !string.IsNullOrEmpty(Title) ? Title : StoryTitle;
    }
}
