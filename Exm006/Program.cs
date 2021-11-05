using System;

namespace Exm006
{
    class Program
    {
        static void Main(string[] args)
        {
            // Практикум 
            // Dev 1
            // Cформировать случайным образом целочисленный массив A из натуральных двузначных чисел. 
            // Создать на его основе масив B, отбрасывая те, которые
            // 1) нарушают порядок возрастания
            // 2) больше среднего арифметического элементов A
            // 3) чётные

            // Создание массива А

            /*

            int[] arrayA = new int[10];
            int index = 0;
            int length = arrayA.Length;

            while (index < length)
            {
                arrayA[index] = new Random().Next(10, 100);
                Console.WriteLine(index);
                index++;
            }
            */

            int GetRandom(int minValue, int maxValue)
            {
                return new Random().Next(minValue, maxValue);
            }

            int[] arrayA = new int[10];
            int index = 0;
            while (index < 10)
            {
                arrayA[index] = GetRandom(10, 50);
                Console.Write(arrayA[index] + " ");
                index++;
            }
            Console.WriteLine();

            // 1) Отбросить элементы, которые нарушают порядок возрастания

            int current = arrayA[0];
            Console.WriteLine(current);


            index = 1;

            while (index <= 9)
            {
                if (arrayA[index] > current)
                {
                    Console.WriteLine(arrayA[index] + " ");
                    current = arrayA[index];
                }
                index++;
            }







        }



    }
}

