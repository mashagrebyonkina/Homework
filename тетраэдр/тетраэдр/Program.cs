using System;
using System.Security.Cryptography.X509Certificates;

namespace тетраэдр
{
    class Program
    {
        static void Main()
        {
            double x;
            double b;
            double c;
           Console.WriteLine("Введите длину ребра тетраэдра:");
            x = double.Parse(Console.ReadLine());
           
            b = x*x*x*Math.Sqrt(2)/12;
            c = x * x * Math.Sqrt(3);

            Console.WriteLine("Объём тетраэдра:" + b);
            Console.WriteLine("Площадь поверхности тетраэдра:" + c);


            Console.ReadKey();
        }
    }
}
