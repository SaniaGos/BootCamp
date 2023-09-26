//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class Tree
//    {
//        static void Main(string[] args)
//        {
//            const int treeSize = 39;
//            int leftBorder, rightBorder, middleBorder = treeSize / 2;
//            leftBorder = rightBorder = middleBorder;
//            int startX = (Console.WindowWidth - treeSize) / 2;
//            int segmentHeigt = 3;
//            int counter = 0;
//            Console.SetWindowSize(100, 100);
//            for (int i = 0; i < treeSize; i++)
//            {
//                for (int j = 0; j < treeSize; j++)
//                {
//                    if (leftBorder <= j && j <= rightBorder)
//                    {
//                        Console.SetCursorPosition(j + startX, i);
//                        Console.Write("*");
//                        Thread.Sleep(1);
//                    }
//                }
                
//                if (counter < segmentHeigt)
//                {
//                    leftBorder -= 2;
//                    rightBorder += 2;
//                    counter++;
//                }
//                else
//                {
//                    leftBorder = rightBorder = middleBorder;
//                    leftBorder -= segmentHeigt;
//                    rightBorder += segmentHeigt;
//                    segmentHeigt++;
//                    counter = 0;
//                }

//                Console.WriteLine();
//            }
//        }
//    }
//}