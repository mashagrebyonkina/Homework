using System;

namespace task6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координату x");
            var x = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите координату у");
            var y = double.Parse(Console.ReadLine());

            Console.WriteLine($"Лежит ли точка в указанной области?" + IsPointInTheArea(x, y));
            Console.ReadKey();
        }
        static bool IsPointInTheArea (double x, double y)
        {
            return  x <= -2 && y >= 1;
        }
    }
}
