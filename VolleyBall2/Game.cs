using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolleyBall2
{
    internal abstract class Game
    {
        public string Name
        {
            get;
        }

        protected Game(string name)
        {
            Name = name;
        }

        public abstract void StartGame();
    }
}
