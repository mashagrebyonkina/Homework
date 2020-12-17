using System;
using System.Reflection.Metadata;

namespace strings_symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a line in English");
            
            string x =  Console.ReadLine();

            var y = F(x);

            Console.WriteLine("New line is:" + F(x));

            Console.ReadKey();
        }
        static string F(string x)
        {
            
            return x.Replace("a", "4").Replace("b", "8").Replace("с", "(").
                Replace("d", "|)").Replace("e", "3").Replace("f", "|=").
                Replace("g", "6").Replace("h", "|-|").Replace("i", "!").
                Replace("j", ")").Replace("k", "|<").Replace("l", "1").
                Replace("m", "|\\/|").Replace("n", "|\\|").Replace("o", "0").
                Replace("p", "|>").Replace("q", "9").Replace("r", "|2").
                Replace("s", "5").Replace("t", "7").Replace("u", "|_|").
                Replace("v", "\\/").Replace("w", "\\/\\/").Replace("x", "><").
                Replace("y", "'/").Replace("z", "2");
        }
    }
}
