using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace MathFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение х:");
            var x = double.Parse(Console.ReadLine());
            
            var y = F(x);

            Console.WriteLine("f(x) = " + y);
            Console.ReadKey();
        }

        static double F(double x)
        {
            return Math.Sqrt(Math.Pow(2, (Math.Pow(x, x))) + Math.Pow(x, (Math.Pow(2, x))) + Math.Pow(x, (Math.Pow(x, 2))));
        }
    }
}
