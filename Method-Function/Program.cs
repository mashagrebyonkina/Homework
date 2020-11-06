using System;

namespace Method_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = GetValue();

            Console.WriteLine("x = " + x);

            Console.ReadKey();
        }

        static double GetValue()
        {
            return F(2, 5, 5) + F(3, 7, 5) + F(5, 11, 11);
        }

/// <summary>
/// Вычисление повторяющегося выражения
/// </summary>
/// <param name="a">Повторяющаяся константа в числителе</param>
/// <param name="b">Первое слагаемое в знаменателе</param>
/// <param name="c">Аргумент в знаменателе</param>
/// <returns></returns>
        static double F(double a, double b, double c)
        {
            return ((a + Math.Sin(a))/ (b + Math.Cos(c)));
            
        }
    }
}
