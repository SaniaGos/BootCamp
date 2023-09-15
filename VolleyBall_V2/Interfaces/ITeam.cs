using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VolleyBall_V2.Models;

namespace VolleyBall_V2.Interfaces
{
    internal interface ITeam
    {
        string TeamName { get;}
        int Point { get;}

        void AddPoint();

        OutKickParametrs FirstKick(bool isNewPoint);

        OutKickParametrs IsKickStand(InKickParametrs parametrs);
    }
}
