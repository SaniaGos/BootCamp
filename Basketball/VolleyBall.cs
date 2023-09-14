using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basketball
{
    public class VolleyBall : Game
    {
        private readonly IBall ball;

        public const int MAX_POINT = 25;

        public VolleyBall() : base("Basketball")
        {
            ball = new Ball(MyRand.GetRand(100, 1));
        }

        public override async Task PassAsync()
        {
            Console.WriteLine("Start game!\n");
            int point = 0;

            while (point < MAX_POINT)
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
                        Console.WriteLine("\nBall is broken!");
                        point = MAX_POINT;
                        break;
                    }
                    await Task.Delay(200);
                }
                point++;
                if (point <= MAX_POINT) Console.Write(point);
            }
            Console.WriteLine("\nGame over!");
        }

    }
}
