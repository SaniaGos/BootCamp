using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basketball
{
    internal class MyRand
    {
        private static Random rand;
        static MyRand()
        {
            InitRand();
        }

        private static void InitRand()
        {
            rand = new Random();
        }

        public static int GetRand(int maxValue, int minValue = 0)
        {
            if (rand == null)
            {
                InitRand();
            }
            if (maxValue > minValue)
            {
                return rand.Next(minValue, maxValue);
            }
            else
            {
                return rand.Next(maxValue, minValue);
            }

        }
    }
}
