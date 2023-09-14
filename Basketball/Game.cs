using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basketball
{
    public abstract class Game
    {
        public readonly string Name;

        protected Game(string name)
        {
            Name = name;
        }

        public abstract Task GameStartAsync();
    }
}
