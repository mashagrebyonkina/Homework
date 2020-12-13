using System;

namespace task_8._3
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Введите а");
                var a = double.Parse(Console.ReadLine());
                var n = 0;
                var sum = 0.0;
                while (sum < a)
                {
                    sum += 1 / (Math.Pow(2, n));
                    n++;
                }
                Console.WriteLine(n);
            }
        }
    }

