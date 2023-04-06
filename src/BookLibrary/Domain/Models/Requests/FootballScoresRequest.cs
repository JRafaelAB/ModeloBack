namespace Domain.Models.Requests;

public class FootballScoresRequest
{
    public IEnumerable<int> TeamA { get; set; }
    public IEnumerable<int> TeamB { get; set; }
    
    
    public FootballScoresRequest(IEnumerable<int> teamA, IEnumerable<int> teamB)
    {
        TeamA = teamA;
        TeamB = teamB;
    }
}
