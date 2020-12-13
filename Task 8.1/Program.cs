using System;

namespace Task_8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0.0;
            for (var i = 1; i <= n; i++)
            {
                sum += i / (i + 1.0);
            }
            Console.WriteLine(sum);
        }
    }
}