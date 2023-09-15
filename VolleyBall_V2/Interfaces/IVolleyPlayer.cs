using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VolleyBall_V2.Models;

namespace VolleyBall_V2.Interfaces
{
    public interface IVolleyPlayer
    {
        string Name { get; }
        PlayerLevel Level { get; }

        public abstract OutKickParametrs FirsKick();
        public abstract OutKickParametrs FriendlyPass();
        public abstract OutKickParametrs Kick(InKickParametrs kickpar);
    }
}
