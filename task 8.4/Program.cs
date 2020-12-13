using System;

namespace task_8._4
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Введите число n");
                var n = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите k");
                var k = int.Parse(Console.ReadLine());
                var s = 0;
                while (n != 0)
                {
                    if (k < n % 10)
                    {
                        s += n % 10;
                    }
                    n = n / 10;
                }
                Console.WriteLine(s);
            }
        }
    }

    

