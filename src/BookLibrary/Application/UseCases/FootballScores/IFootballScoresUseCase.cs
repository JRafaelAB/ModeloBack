using Domain.Models.Requests;
using Domain.Models.Responses;

namespace Application.UseCases.FootballScores;

public interface IFootballScoresUseCase
{
    FootballScoresResponse Execute(FootballScoresRequest request);
}
