namespace VolleyBall2;

internal class VolleyBall : Game, IVolleyBall
{
    private readonly IField _field;
    private readonly ITeam _firstTeam;
    private readonly ITeam _secondTeam;

    public VolleyBall(string name, IField field, ITeam firstTeam, ITeam secondTeam) : base(name)
    {

        _field = field;
        _firstTeam = firstTeam;
        _secondTeam = secondTeam;
    }

    public override void StartGame()
    {
        int firstTeamCounter = 1;
        int secondTeamCounter = 1;

        if (!_firstTeam.IsFullTeam() && _secondTeam.IsFullTeam())
        {
            throw new Exception("Team is not full!");
        }

        for (int i = 0; i < 25; i++)
        {

            _firstTeam.GetVolleyballistByNumber(i == 0 ? 1 : i);
        }


        


    }
    
    

}