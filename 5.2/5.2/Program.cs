using System;

namespace _5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "апельсин";

            text = text.Trim(); 
            text = text.Trim(new char[] { 'а', 'с','и', 'н' });
            text = text.Replace("л", "н");

            string text2 = "апельсин";
            
            text2 = text2.Replace("а", "с");
            text2 = text2.Replace("ь", "и");
            text2 = text2.Replace("н", "ь");
            text2 = text2.Replace("е", "а");
            text2 = text2.Replace("л", "н");
            text2 = text2.Replace("е", "с");
            text2 = text2.Replace("л", "и");

            int ind = text2.Length - 3;
            text2 = text2.Remove(ind);




            Console.WriteLine("апельсин");
            Console.WriteLine(text);
            Console.WriteLine(text2 + "ель");
            Console.ReadKey();

            

        }
    }
}
