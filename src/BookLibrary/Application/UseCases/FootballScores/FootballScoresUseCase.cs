using Domain.Models.Requests;
using Domain.Models.Responses;

namespace Application.UseCases.FootballScores;

public class FootballScoresUseCase : IFootballScoresUseCase
{
    public FootballScoresResponse Execute(FootballScoresRequest request)
    {
        var result = request.TeamB.Select(score => request.TeamA.Count(aScore => aScore <= score)).ToList();

        return new FootballScoresResponse(result);
    }
}
