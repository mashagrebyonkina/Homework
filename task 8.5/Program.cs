using System;

namespace task_8._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a, b, c, d, e");
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());
            var d = int.Parse(Console.ReadLine());
            var e = int.Parse(Console.ReadLine());
            var x = 0.0;
            while (Math.Pow(x, 4) - a * Math.Pow(x, 3) - b * Math.Pow(x, 2) - c * x - d < 0)
            {
                x++;
            }
            while ((x) / 2.0 > 2 * e)
            {
                x = x / 2;
            }
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
