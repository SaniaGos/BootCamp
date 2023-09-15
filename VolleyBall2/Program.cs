using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static VolleyBall2.PlayerBase;

namespace VolleyBall2
{
    internal class Program
    {
        public const int FieldWidth = 9;
        public const int FieldLength = 16;
        public const double GridHeight = 2.43;

        static void Main(string[] args)
        {
            IField field = new Field(FieldWidth, FieldLength, GridHeight);
            ITeam firstTeam = new Team("Dynamo", new List<Volleyballist>()
            {
                new Volleyballist(professionalism: Prof.Comp, name: "Billy Harrington"),
                new Volleyballist(professionalism: Prof.Int, name: "Garry Kasparov")
            });
            ITeam secondTeam = new Team("Shakhtar", new List<Volleyballist>()
            {
                new Volleyballist(professionalism: Prof.UpperInt, name: "John Wick"),
                new Volleyballist(professionalism: Prof.Rec, name: "Barack Obama")
            });
            VolleyBall volleyBall = new VolleyBall("VolleyBall", field, firstTeam, secondTeam);

            // Console.WriteLine(firstTeam.ToString());
            // Console.WriteLine(secondTeam.ToString());

            // volleyBall.StartGame();
        }
    }
}
