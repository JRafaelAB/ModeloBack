namespace Domain.Models.Responses;

public class FootballScoresResponse
{
    public IEnumerable<int> Result { get; set; }
    
    public FootballScoresResponse(IEnumerable<int> result)
    {
        Result = result;
    }
}
