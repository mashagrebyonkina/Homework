using System;

namespace task6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числo m");
            var m = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите числo n");
            var n = int.Parse(Console.ReadLine());

            string answer = "Нет.";
            if (EvaluateLogExpression(m, n))
                answer = "Да.";

            Console.WriteLine($"Верно ли, что каждое из чисел m и n нечетное? -" + answer);

        }
        
        static bool EvaluateLogExpression (double m, double n)
        {
            //Каждое из чисел m и n нечетное

            return m % 2 !=0 && n % 2 != 0;
        }
    } 
     
}
