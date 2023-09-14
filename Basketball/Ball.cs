using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basketball
{
    internal class Ball : IBall
    {
        private readonly int _quality;

        public Ball(int quality)
        {
            _quality = (1 < quality && quality <= 100) ? 3 - (int)(quality / 33.34) : throw new ArgumentOutOfRangeException();
            Console.WriteLine($"Ball Quality {_quality}");
        }

        public bool IsKick(int power)
        {
            return MyRand.GetRand(10000, 1) < (_quality * power);
        }
    }
}
