using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolleyBall2
{
    internal class Volleyballist : PlayerBase
    {
        private Random rand = new Random();

        public Volleyballist(Prof professionalism, string name) : base(professionalism, name)
        {
        }

        public override int PassBall() // Serving the ball from the edge of the field
        {
            int successPassChance =
                (int)this.Professionalism + (100 - (int)this.Professionalism) / 2; // Calculate success pass chance
            // If pass success
            if (Helper.IsChanceProc(successPassChance))
            {
                return rand.Next(1, 6); // Return number of the enemy player who should receive the ball
            }
            else
            {
                return 0;
            }
        }

        public bool AcceptBall(Team friendTeam) // Receives the ball from enemy team
        {
            int numberOfPasses;
            int lastPassPlayerNumber = 0;
            if (Helper.IsChanceProc((int)this.Professionalism))
            {
                // Console.WriteLine("The player caught the ball");
                Console.WriteLine("Гравець прийняв подачу!");
                numberOfPasses =
                    rand.Next(0, 2); // The number of passes between teammates after successfully receiving the ball
                for (int i = 0; i < numberOfPasses; i++)
                {
                    lastPassPlayerNumber = PassBall((int)this.Professionalism, friendTeam);
                }

                friendTeam.GetVolleyballistByNumber(lastPassPlayerNumber).PassBall();

                return true;
            }
            else
            {
                // Console.WriteLine("The player dropped the ball!");
                Console.WriteLine("Гравець не піймав м'яч!");
                return false;
            }
        }

        public override int PassBall(int skillLevel, Team friendTeam) // Pass the ball to a teammate
        {
            int successPassChance = (int)this.Professionalism +
                                    (100 - (int)this.Professionalism) *
                                          (skillLevel / 100); // Calculate success team pass chance
            // If pass success
            if (Helper.IsChanceProc(successPassChance))
            {
                Console.WriteLine("Гравець прийняв пас від товариша!");
                int teammateNumber = rand.Next(1, 6);
                while (teammateNumber == friendTeam.GetNumberByVolleyballist(this))
                {
                    teammateNumber = rand.Next(1, 6);
                }

                return teammateNumber; // Return number of the enemy player who should receive the ball
            }
            else
            {
                // Console.WriteLine("The player dropped the ball!");
                Console.WriteLine("Гравець не прийняв пас від товариша!");
                return 0;
            }
        }
    }
}