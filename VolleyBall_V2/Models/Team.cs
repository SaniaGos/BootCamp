using Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using VolleyBall_V2.Helper;
using VolleyBall_V2.Interfaces;

namespace VolleyBall_V2.Models
{
    public class Team : ITeam
    {
        public string TeamName { get; }
        public int Point { get; private set; }
        readonly int countPlayer;

        ConsoleColor foregroundColor;


        IList<IVolleyPlayer> players;

        int numOfCurrentPlayer = 0;

        public Team(int playerCount, string teamName, ConsoleColor foregroundColor)
        {
            TeamName = teamName;
            countPlayer = playerCount > 5 ? 5 : playerCount < 2 ? 2 : playerCount;
            GetComand(countPlayer);
            this.foregroundColor = foregroundColor;
        }

        private void GetComand(int countPlayer)
        {
            players = new List<IVolleyPlayer>();
            for (int i = 0; i < countPlayer; i++)
            {
                var playerName = GameHelper.GetRandomPlayerName() + "_" + (i + 1);
                players.Add(new VolleyPlayer(playerName));
            }
        }

        public void AddPoint()
        {
            SetConsoleColor();
            Point++;
            Console.WriteLine($"Team {TeamName} get the point {Point}");
            CheckIfWin();
        }

        public OutKickParametrs FirstKick(bool isNewPoint)
        {
            SetConsoleColor();
            if (!isNewPoint)
            {
                SetNexCurrentPlayer();
            }

            Console.WriteLine($"Player of {TeamName} Pass the ball");
            return players[numOfCurrentPlayer].FirsKick();
        }

        public OutKickParametrs IsKickStand(InKickParametrs parametrs)
        {
            SetConsoleColor();
            Console.WriteLine($"Player of {TeamName} try receive the ball");
            var param = players[Constants.MyRand(countPlayer, 1)].Kick(parametrs);

            if (param.IsKickPass)
            {
                var numOfPassing = Constants.MyRand(3, 0);

                for (int i = 0; i < numOfPassing; i++)
                {
                    Console.WriteLine($"Player of {TeamName} {param.PlayerName} pass to friend");
                    param = players[Constants.MyRand(countPlayer, 1)].FriendlyPass();
                    Console.WriteLine($"Player of {TeamName} {param.PlayerName} get pass from friend");
                }
            }

            return param;
        }

        private void CheckIfWin()
        {
            if (Point == 25)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"Team {TeamName} has won!!!!!");
            }
        }

        private void SetConsoleColor()
        {
            Console.ForegroundColor = foregroundColor;
        }

        private void SetNexCurrentPlayer()
        {
            numOfCurrentPlayer = numOfCurrentPlayer == countPlayer - 1 ? 0 : numOfCurrentPlayer + 1;
        }
    }

}
