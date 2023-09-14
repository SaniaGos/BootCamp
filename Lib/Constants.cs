using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public static class Constants
    {
        public const string Error = "Error";
        public const string StrSpase = " ";

        private static Random rand;
        static Constants()
        {
            InitRand();
        }

        private static void InitRand()
        {
            rand = new Random();
        }

        public static int MyRand(int maxValue, int minValue = 0)
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

    public static class ConstantsNonEfective
    {
        public static int MyRand(int maxValue, int minValue = 0)
        {
            var rand = new Random();
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
