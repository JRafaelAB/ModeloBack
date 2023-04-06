using Application.UseCases.GetTopArticles;
using Microsoft.AspNetCore.Mvc;
using WebApi.Controllers.Base;

namespace WebApi.Controllers.v1.GetTopArticles;

[ApiVersion("1.0")]
[ApiController]
[Route("v{version:apiVersion}/[controller]")]
public class ArticlesController : ValidatorControllerBase
{
    private readonly IGetTopArticlesUseCase _useCase;

    public ArticlesController(IGetTopArticlesUseCase useCase)
    {
        _useCase = useCase;
    }

    [HttpGet("{limit:int}")]
    public async Task <IActionResult> GetTopArticles([FromRoute] int limit)
    {
        return Ok(await _useCase.Execute(limit));
    }
    
}
