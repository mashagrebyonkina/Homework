using System;

namespace Арифметика
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Введите трёхзначное число");
            //x = (Console.ReadLine());
            x = int.Parse(Console.ReadLine());
            y = ((x/10) + (x%10)*100);
            Console.WriteLine(y);
            Console.ReadKey();
            

        }
    }
}
