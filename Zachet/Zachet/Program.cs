using System;

namespace Zachet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число");
            int n = new int();
            while (true)
            { 
                var UserNumb = (Console.ReadLine());
                if (!int.TryParse(UserNumb, out n) || !(int.Parse(UserNumb) > 0)) 
                    {
                    Console.WriteLine("Ошибка ввода.Попробуйте ещё раз.");
                    continue;
                }
                else
                {
                    Answer(n);
                    break;
                }
            }
        }
        static void Answer (int n)
        {
            int amount = 0;
            int maxnumb = 0;

            while(n!=1)
            {
                amount +=1;
                if (n>maxnumb)
                {
                    maxnumb = n;
                }
                if (n%2==0)
                {
                    n /= 2;
                }
                else 
                {
                    n *= 3;
                    n += 1;
                }
            }
            Console.WriteLine($"Цепочка состоит из {amount} элементов. Максимальное значение в цепи - {maxnumb}");
        }
    }
}
