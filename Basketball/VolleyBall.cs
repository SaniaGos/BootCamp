using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basketball
{
    public class VolleyBall : Game
    {
        public const int MAX_POINT = 25;
        private readonly IBall ball;

        public VolleyBall() : base("Basketball")
        {
            ball = new Ball(MyRand.GetRand(100, 1));
        }

        public override async Task GameStartAsync()
        {
            Console.WriteLine("Start game!\n");
            int point = 0;
            
            while (point < MAX_POINT)
            {
                if (await IsPassSuccessAsync())
                {
                    point++;
                    Console.Write(point);
                }
                else
                {
                    break;
                }
            }
            
            Console.WriteLine("\nGame over!");
        }

        private async Task<bool> IsPassSuccessAsync()
        {
            int randomPass = MyRand.GetRand(6, 2);
            
            for (int i = 0; i < randomPass; i++)
            {
                if (!ball.IsKick(MyRand.GetRand(100, 1)))
                {
                    Console.Write('_');
                }
                else
                {
                    Console.WriteLine("\n\nBall is broken!");
                    return false;
                }
                await Task.Delay(100);
            }
            return true;
        }
    }
}
