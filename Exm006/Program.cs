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

            Console.WriteLine("Массив А: ");

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

            Console.WriteLine("Массив элементов, не нарушающих порядок возрастания: ");

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


            // 2) Отбросить элементы, которые больше среднего арифметического элементов A

            Console.WriteLine("Массив элементов, которые меньше среднего арифметического элементов А: ");

            int ArithmeticMean(int[] array)
            {
                int sum = 0;
                int index = 0;
                while (index < array.Length)
                {
                    sum = sum + array[index];
                    index++;
                }
                sum = sum / array.Length;
                return sum;
            }

            int mean = ArithmeticMean(arrayA);
            Console.WriteLine(mean + " - среднее арифметическое элементов массива А");
            index = 0;

            while (index <= 9)
            {
                if (arrayA[index] < mean)
                {
                    Console.Write(arrayA[index] + " ");
                }
                index++;
            }

            Console.WriteLine();

            // 3) Отбросить чётные элементы

            Console.WriteLine("Массив без четных элементов: ");

            index = 0;

            while (index <= 9)
            {
                if ((arrayA[index] % 2) != 0)
                {
                    Console.Write(arrayA[index] + " ");
                }
                index++;
            }

        }

    }
}

