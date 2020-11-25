using System;

namespace task7
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, f;
            Console.WriteLine("Введите значение x:");
            x = double.Parse(Console.ReadLine());

            if (Math.Abs(Math.Sin(x)) > x )
                {
                f = Math.Sin(x);
                Console.WriteLine("Значение функции F(x):" + f);
                }
            else
                if (Math.Abs(Math.Sin(x)) == x)
            {
                f = 0;
                Console.WriteLine("Значение функции F(x):" + f);
            }
            else
                if (Math.Abs(Math.Sin(x)) < x)
            {
                f = -Math.Sin(x);
                Console.WriteLine("Значение функции F(x):" + f);
            }
                Console.ReadKey();
        }
        
        
      
        
    }
}
