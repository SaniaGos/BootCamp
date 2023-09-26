using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCamp
{
    internal class ChristmasTree
    {
        private int branches;
        private int maxWidth;
        private const int branchWidthDiff = 6;

        public ChristmasTree(int branches, int maxWidth)
        {
            this.branches = branches;
            this.maxWidth = maxWidth;
        }

        public void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            //Console.SetCursorPosition((Console.WindowWidth - maxWidth) / 2, Console.CursorTop);
            
            var startY = 0;
            for (int i = 0; i < branches; i++)
            {
                var widthTop = i * branchWidthDiff + 1;
                var widthBottom = maxWidth - ((branches - i) * branchWidthDiff + 11);
                var height = (i / 2) + 4;
                var startX = (branches - 1 - i) * (branchWidthDiff / 2);

                DrawBranch_V2(widthTop, widthBottom, height, startX, startY);
                startY += (i / 2) + 4;
            }
        }

        private void DrawBranch(int widthTop, int widthBottom, int height, int startX, int startY)
        {
            startX += 0;
            var diff = 0;

            for (var i = 0; i < height; i++)
            {
                Console.SetCursorPosition(startX + widthBottom - widthTop - diff, i + startY);
                for (int j = 0; j < widthTop + diff * 2; j++)
                {
                    Console.Write("*");
                }
                diff = (int)Math.Round((widthBottom - widthTop) / (double)height * (i + 1) / 2, 0);
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private void DrawBranch_V2(int widthTop, int widthBottom, int height, int startX, int startY)
        {
            var diff = 0;

            for (var i = 0; i < height; i++)
            {
                Console.SetCursorPosition((widthBottom / 2) + startX, i + startY);
                Console.Write("*");

                for (int j = 0; j < (widthTop / 2) + diff; j++)
                {
                    Task.Delay(20).Wait();
                    DrawElement();
                }

                Console.SetCursorPosition(((widthBottom - widthTop) / 2) - diff + startX + 1, i + startY);

                for (int j = 0; j < (widthTop / 2) + diff; j++)
                {
                    Task.Delay(20).Wait();
                    DrawElement();
                }

                diff = (int)Math.Round((widthBottom - widthTop) / (double)height * (i + 1) / 2, 0);

                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private bool IsDrawToy()
        {
            return Lib.Constants.MyRand(100) < 20;
        }

        
        static int minRepeatToy = 0;
        private void DrawElement()
        {
            if (IsDrawToy() && minRepeatToy <= 0)
            {
                var color = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("O");
                Console.ForegroundColor = color;
                minRepeatToy = 2;
            }
            else
            {
                Console.Write("*");
                minRepeatToy--;
            }
        }
    }
}
