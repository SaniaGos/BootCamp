using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VolleyBall_V2.Interfaces;
using VolleyBall_V2.Models;

namespace VolleyBall_V2.Interfaces
{
    public class Program
    {
        static void Main(string[] args)
        {
            var game = new VolleyBall(5);
            game.StartGame();
        }
    }
}