namespace VolleyBall2;

internal interface ITeam
{
    Volleyballist GetVolleyballistByNumber(int number);
    void AddPlayer(Volleyballist volleyballist);
    bool RemovePlayer(Volleyballist volleyballist);
    bool IsFullTeam();
    string ToString();
}