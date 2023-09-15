using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolleyBall2
{
    internal abstract class PlayerBase
    {
        public enum Prof
        {
            Comp = 90,     // COMPETITIVE        90% - chance to successfully receive the ball
            UpperInt = 80, // UPPER INTERMEDIATE 80%
            Int = 70,      // INTERMEDIATE       70%
            Rec = 55       // RECREATIONAL       55%
        }

        public Prof Professionalism { get; }

        public string Name
        {
            get;
        }

        protected PlayerBase(Prof professionalism, string name)
        {
            Professionalism = professionalism;
            Name = name;
        }

        public abstract int PassBall(int skillLevel, Team team);
        public abstract int PassBall();
    }
}
