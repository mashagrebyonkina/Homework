using System;

namespace _5._2
{
    class Program
    {
        static void Main()
        {
            var orange = "апельсин";

            var stump = orange.Substring(1, 2) + orange[7] + orange[4];
            var spaniel = orange.Substring(5, 1) + orange[1] + orange[0] + orange.Substring(7, 1) + orange[6] + orange.Substring(2, 3);


            Console.WriteLine($"Данное слово: {orange}.");
        
            Console.WriteLine($"Получившиеся слова: {stump}, {spaniel}.");
            Console.ReadKey();

            

        }
    }
}
