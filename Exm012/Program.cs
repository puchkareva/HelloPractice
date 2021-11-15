using System;

namespace Exm012
{
    class Program
    {
        static void Main(string[] args)
        {

            // Создать массив А и на его основе - массив В, в который войдут только четные элементы А
            int[] a = new int[10];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = new Random().Next(10);
                Console.Write($"{a[i]} ");
            }

            int[] b = new int[a.Length];
            Console.WriteLine("\n до ");
            int index = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    b[index] = a[i];
                    Console.Write($"{b[index]} ");
                    index++;
                }
            }
            Console.WriteLine("\n\n после ");

            for (int i = 0; i < index; i++)
            {
                Console.Write($"{b[i]} ");
            }

            // Array.Resize(ref b, index); // строчки кода 32-35 можно переписать, зная оператор Resize

            // for (int i = 0; i < b.Length; i++)
            // {
            //     Console.Write($"{b[i]} ");
            // }
        }
    }
}
