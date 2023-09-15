using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolleyBall2
{
    internal class Field : IField
    {
        public int Width { get; set; }
        public int Length { get; set; }
        public double GridHeight { get; set; }

        public Field(int width, int length, double gridHeight)
        {
            Width = width;
            Length = length;
            GridHeight = gridHeight;
        }
    }
}
