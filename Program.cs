using System;

namespace task6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите позицию белого коня:");
            var whiteKnightPosition = Console.ReadLine();
            Console.WriteLine("Введите позицию черного слона:");
            var blackBishopPosition = Console.ReadLine();

            if (CheckPosition(whiteKnightPosition, blackBishopPosition))
            {
                Console.WriteLine("Введите ход белого коня:");
                var whiteKnightMove = Console.ReadLine();
                if (CanKhightMakeSafeMove(whiteKnightPosition, whiteKnightMove, blackBishopPosition)) 
                Console.WriteLine("Конь может ходить.");
                else
                    Console.WriteLine("Конь не может ходить.");

            }
            else
                Console.WriteLine("Введенные позиции некорректны.");
                Console.ReadKey();

        }

        static void GetCoordinates (string position, out int x, out int y)
        {
            x = (int)position[0] - 0x60;

            y = int.Parse(position[1].ToString());
        }
        static bool CanKnightMakeMove (string start, string end)
        {
            if (start == end)
                return false;
            int startX, startY, endX, endY;
            GetCoordinates(start, out startX, out startY);
            GetCoordinates(end, out endX, out endY);

            return startX == endX + 1 || startX == endX - 1 || startY == endY + 3;
        }
        static bool CanBishopMakeMove (string start, string end)
        {
            if (start == end)
                return false;
            int startX, startY, endX, endY;
            GetCoordinates(start, out startX, out startY);
            GetCoordinates(end, out endX, out endY);

            return Math.Abs(endX - startX) == Math.Abs(endY - startY);
        }
        static bool CheckPosition (string whitePos, string blackPos)
        {
            return whitePos != blackPos && !CanKnightMakeMove(whitePos, blackPos) && !CanBishopMakeMove(blackPos, whitePos);
        }

        static bool CanKhightMakeSafeMove(string knightStartPos, string knightEndPos, string bishopPos)
        {
            return CanKnightMakeMove(knightStartPos, knightEndPos) && !CanBishopMakeMove(bishopPos, knightEndPos);
        }

      
        

     
    }



}
