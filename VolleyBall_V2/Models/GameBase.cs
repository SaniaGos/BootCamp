using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolleyBall_V2.Models
{
    internal abstract class GameBase
    {
        public string Name { get; }

        public GameBase(string name)
        {
            Name = name;
        }

        public abstract void StartGame();
    }
}
