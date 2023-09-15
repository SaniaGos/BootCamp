using Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VolleyBall_V2.Interfaces;

namespace VolleyBall_V2.Models
{
    public class VolleyPlayer : BasePlayer, IVolleyPlayer
    {
        private const int maxRand = 10000;
        public VolleyPlayer(string name)
        {
            base.Name = name;
            base.Level = (PlayerLevel)Constants.MyRand(6, 1);
        }

        public override OutKickParametrs FirsKick()
        {
            Console.WriteLine($"Player {base.Name} first kick the ball");
            return new OutKickParametrs() { Level = base.Level, PlayerName = base.Name, IsKickPass = true };
        }

        public override OutKickParametrs FriendlyPass()
        {
            Console.WriteLine($"Player {base.Name} first pass the ball");
            return new OutKickParametrs() { Level = base.Level, PlayerName = base.Name, IsKickPass = true };
        }

        public override OutKickParametrs Kick(InKickParametrs kickpar)
        {
            if (kickpar == null)
            {
                throw new NullReferenceException(nameof(kickpar));
            }
            else
            {
                var isKickІStand = IsKickІStand(kickpar);
                if (isKickІStand)
                {
                    Console.WriteLine($"Player {base.Name} stand the kick from {kickpar.PlayerName}");
                }
                else
                {
                    Console.WriteLine($"Player {base.Name} not stand the kick from {kickpar.PlayerName}");
                }

                return new OutKickParametrs() { Level = base.Level, PlayerName = base.Name, IsKickPass = isKickІStand };
            }
        }

        private bool IsKickІStand(InKickParametrs parametrs)
        {
            var diffLevel = Level - parametrs.Level;

            return Constants.MyRand(maxRand, 1) < (0.66 * maxRand) + (0.08 * diffLevel * maxRand);
        }
    }
}
