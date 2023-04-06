namespace Application.UseCases.GetTopArticles;

public interface IGetTopArticlesUseCase
{
    Task<List<string?>> Execute(int limit);
}
