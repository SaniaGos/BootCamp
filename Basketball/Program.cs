﻿namespace Basketball
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VolleyBall volleyBall = new VolleyBall();

            volleyBall.PassAsync().Wait();

        }
    }
}