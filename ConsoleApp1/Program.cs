//namespace ConsoleApp1
//{
//    class Program
//    {
//        static void UpdateBorder(int i, int middleBorder, ref int leftBorder, ref int rightBorder)
//        {
//            if (i < middleBorder)
//            {
//                leftBorder--;
//                rightBorder++;
//            }
//            else
//            {
//                leftBorder++;
//                rightBorder--;
//            }
//        }

//        static void Main(string[] args)
//        {
//            const int rombSize = 21;
//            int leftBorder, rightBorder, middleBorder = rombSize / 2;
//            leftBorder = rightBorder = middleBorder;
//            int startX = (Console.WindowWidth - rombSize) / 2;

//            for (int i = 0; i < rombSize; i++)
//            {
//                for (int j = 0; j < rombSize; j++)
//                {
//                    if (leftBorder <= j && j <= rightBorder)
//                    {
//                        Console.SetCursorPosition(j + startX, i);
//                        Console.Write("*");
//                    }
//                }

//                UpdateBorder(i, middleBorder, ref leftBorder, ref rightBorder);
//                Console.WriteLine();
//            }
//        }
//    }
//}