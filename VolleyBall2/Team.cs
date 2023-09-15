using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolleyBall2
{
    internal class Team : ITeam
    {
        private const int MaxPlayers = 6;
        public readonly string TeamName;
        public List<Volleyballist> Players = new();

        public Team(string teamName)
        {
            TeamName = teamName;
        }

        public Team(string teamName, List<Volleyballist> players)
        {
            TeamName = teamName;
            if (players.Count <= MaxPlayers)
            {
                Players = players;
            }
            else
            {
                throw new ArgumentException("Players count must be less or equal 6");
            }
        }

        public Volleyballist GetVolleyballistByNumber(int number)
        {
            return Players.ElementAt(number);
        }

        public int GetNumberByVolleyballist(Volleyballist volleyballist)
        {
            return Players.IndexOf(volleyballist);
        }

        public void AddPlayer(Volleyballist volleyballist)
        {
            Players.Add(volleyballist);
        }

        public bool RemovePlayer(Volleyballist volleyballist)
        {
            return Players.Remove(volleyballist);
        }

        public bool IsFullTeam()
        {
            return Players.Count == MaxPlayers;
        }

        public override string ToString()
        {
            int index = 1;
            string playerList = string.Empty;

            foreach (var player in Players)
            {
                playerList += $"{index}. {player.Name} \t\t {player.Professionalism}\n";
                index++;
            }

            return $"Team: {TeamName}\n{playerList}\n";
        }
    }
}
