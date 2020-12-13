using System;

namespace task_8._2
{
    class Program
    {
        static void Main(string[] args)
        
            {
                Console.WriteLine("Введите число n");
                var n = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите сопротивление");
                var k = int.Parse(Console.ReadLine());

                var sum = (n * (1.0 / k));
                Console.WriteLine(1 / sum);
            }
        }
    }



