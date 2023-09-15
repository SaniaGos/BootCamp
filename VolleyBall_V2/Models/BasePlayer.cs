using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VolleyBall_V2.Interfaces;

namespace VolleyBall_V2.Models
{
    public abstract class BasePlayer 
    {
        public string Name { get; protected set; }
        public PlayerLevel Level { get; protected set; }

        public abstract OutKickParametrs FirsKick();
        public abstract OutKickParametrs FriendlyPass();
        public abstract OutKickParametrs Kick(InKickParametrs kickpar);
        

    }
}
