using Application.UseCases.FootballScores;
using Domain.Models.Requests;
using Microsoft.AspNetCore.Mvc;
using WebApi.Controllers.Base;

namespace WebApi.Controllers.v1.FootballScores;

[ApiVersion("1.0")]
[ApiController]
[Route("v{version:apiVersion}/[controller]")]
public class CaseOneController : ValidatorControllerBase
{
    private readonly IFootballScoresUseCase _useCase;

    public CaseOneController(IFootballScoresUseCase useCase)
    {
        _useCase = useCase;
    }
    
    [HttpPost]
    public IActionResult FootballScores([FromBody] FootballScoresRequest request)
    {
        return Ok(_useCase.Execute(request));
    }
    
}
