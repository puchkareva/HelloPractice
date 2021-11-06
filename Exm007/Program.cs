using System;

namespace Exm007
{
    class Program
    {
        static void Main(string[] args)
        {
            // Практикум 
            // Dev 1
            // Имеется числовой массив A заполненный числами из отрезка [minValue; maxValue]. 
            // Создать на его основе масив B, отбрасывая те, которые нарушают порядок
            // 1) возрастания
            // 2) элементы, больше 8
            // 3) знакочередования

            // Создание массива

            Console.WriteLine("Массив А: ");

            int GetRandom(int minValue, int maxValue)
            {
                return new Random().Next(minValue, maxValue);
            }

            int[] arrayA = new int[10];
            int index = 0;
            while (index < 10)
            {
                arrayA[index] = GetRandom(-10, 10);
                Console.Write(arrayA[index] + " ");
                index++;
            }

            Console.WriteLine();

            // 1) Отбросить элементы, которые нарушают порядок возрастания

            Console.WriteLine("Массив элементов, не нарушающий порядок возрастания: ");

            int current = arrayA[0];
            Console.Write(current + " ");

            index = 1;

            while (index <= 9)
            {
                if (arrayA[index] > current)
                {
                    Console.Write(arrayA[index] + " ");
                    current = arrayA[index];
                }
                index++;
            }

            Console.WriteLine();

            // 2) Отбросить элементы больше 8

            Console.WriteLine("Массив элементов больше 8: ");

            index = 0;

            while (index <= 9)
            {
                if (arrayA[index] < 8)
                {
                    Console.Write(arrayA[index] + " ");
                }
                index++;
            }

            Console.WriteLine();

            //  3) Отбросить элементы, которые нарушают порядок знакочередования

            Console.WriteLine("Массив элементов, не нарушающий порядок знакочередования: ");

            current = arrayA[0];
            index = 1;

            Console.Write(current + " ");

            while (index <= 9)
            {
                if ((current > 0) && (arrayA[index] < 0))
                {
                    Console.Write(arrayA[index] + " ");
                    current = arrayA[index];
                }
                if ((current < 0) && (arrayA[index] > 0))
                {
                    Console.Write(arrayA[index] + " ");
                    current = arrayA[index];
                }
                index++;
            }

        }

    }
}
