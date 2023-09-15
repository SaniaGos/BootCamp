using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolleyBall2
{
    internal static class Helper
    {
        private static Random random = new();
        public static bool IsChanceProc(int chance)
        {
            return chance < random.Next(100);
        }
    }
}
