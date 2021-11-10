using System;

namespace Exm010
{
    class Program
    {
        static void Main(string[] args)
        {

            // Даны два числа. Показать большее и меньшее число
            char GetMaxNumber(int num)
            {
                string ab = Convert.ToString(num);
                char a = ab[0];
                char b = ab[1];
                if (a > b) return a;
                else return b;
            }
            int G = new Random().Next(10,100);
            char result = GetMaxNumber(G);
            Console.WriteLine($"В числе {G} наибольшая цифра {result}");

        }
    }
}
