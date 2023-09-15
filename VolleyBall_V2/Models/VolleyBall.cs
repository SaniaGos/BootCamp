using Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VolleyBall_V2.Interfaces;

namespace VolleyBall_V2.Models
{
    internal class VolleyBall : GameBase
    {
        ITeam firstTeam;
        ITeam secondTeam;

        int numOfSubmitterTeam = 0;
        int numOfPassTeam = 0;
        int numOfHostTeam = 0;

        public ITeam this[int i]
        {
            get
            {
                if (i == 1) return firstTeam;
                if (i == 2) return secondTeam;
                throw new IndexOutOfRangeException();
            }
        }

        public VolleyBall(int numOfPlayers) : base("VolleyBall")
        {
            firstTeam = new Team(numOfPlayers, "First Command", ConsoleColor.Green);
            secondTeam = new Team(numOfPlayers, "Second Command", ConsoleColor.Red);
        }

        public override void StartGame()
        {
            SetStartTeam();

            var pass = this[numOfSubmitterTeam].FirstKick(true);

            while (firstTeam.Point < 25 && secondTeam.Point < 25)
            {
                pass = this[numOfHostTeam].IsKickStand(new InKickParametrs() { Level = pass.Level, PlayerName = pass.PlayerName });

                if (!pass.IsKickPass)
                {
                    if (numOfSubmitterTeam == numOfPassTeam)
                    {
                        this[numOfSubmitterTeam].AddPoint();
                        if (this[numOfSubmitterTeam].Point == 25)
                        {
                            break;
                        }
                        pass = this[numOfSubmitterTeam].FirstKick(true);
                    }
                    else
                    {
                        numOfPassTeam = numOfSubmitterTeam;
                        pass = this[numOfSubmitterTeam].FirstKick(false);
                    }
                }
                else
                {
                    SwapTeam();
                }

                Task.Delay(100).Wait();
            }
        }

        private void SwapTeam()
        {
            var tmp = numOfSubmitterTeam;
            numOfSubmitterTeam = numOfHostTeam;
            numOfHostTeam = tmp;
        }

        private void SetStartTeam()
        {
            numOfSubmitterTeam = Constants.MyRand(3, 1);
            numOfPassTeam = numOfSubmitterTeam;
            numOfHostTeam = numOfSubmitterTeam == 1 ? 2 : 1;
        }
    }
}
