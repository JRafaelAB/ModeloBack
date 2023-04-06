using Domain.Models.Responses.mockApi;

namespace Domain.Utils;

public static class ArticlesUtils
{
    public static List<ArticlesData> FilterArticles(this IEnumerable<ArticlesData> articlesDatas)
    {
        return articlesDatas.Where(article => !string.IsNullOrEmpty(article.Title) || !string.IsNullOrEmpty(article.StoryTitle)).ToList();
    }
}
