using Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolleyBall_V2.Helper
{
    public static class GameHelper
    {
        private static readonly string[] playerNames = {"Ronaldini", "Natalini", "Vasil", "Vitalii", "Zinchenko", "Anton",
                                                        "Oleg", "Oleksandra", "Mishko", "Nadia", "Kostya", "Anatoliy", "Pavlo"};
        public static string GetRandomPlayerName()
        {
            return playerNames[Constants.MyRand(playerNames.Length, 0)];
        }

    }
}
