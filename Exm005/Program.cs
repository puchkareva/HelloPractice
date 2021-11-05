using System;

namespace Exm005
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача.
            // Сформировать случайным образом N элементный массив,
            // заполненный однозначными целыми числами разных знаков.
            // Задать К и выяснить
            // - сколько раз повторяется К в массиве
            // - сколько элементов находится между первым и последним К

            // Формирование массива

            /*

            int[] arrA = new int[10];
            int index = 0;
            int length = 10;

            while (index < length)
            {
                arrA[index] = new Random().Next(-5, 5);
                Console.Write(arrA[index] + " ");
                index++;
            }

            Console.WriteLine();

            

            // Стихийное решение - сколько раз повторяется К в массиве

            index = 0;
            int K = 1;
            int count = 0;

            while(index < length)
            {
                if (arrA[index] == K)
                {
                    count++;
                }
                index++;
            }
            Console.WriteLine();
            Console.WriteLine(count);

           

            // Решение через метод - сколько раз повторяется К в массиве

            int CountK(int[] array, int K)
            {
                int index = 0;
                int count = 0;
                int length = array.Length;
                while(index < length)
                {
                    if(array[index] == K)
                    {
                        count++;
                    }
                    index++;
                }
            return count;
            }
            Console.WriteLine();
            int numberA = CountK(arrA, 4);
            Console.WriteLine(numberA);

            int[] arrB = {6, -3, 2, 2, 7, -9};
            int numberB = CountK(arrB, 2);
            Console.WriteLine(numberB);

             */

            // сколько элементов находится между первым и последним К

            int[] arrB = { 1, 6, -3, 2, 2, 7, 6, -9 };
            int index = 0;
            int length = arrB.Length;
            int K = 6;

            while (index < length)
            {
                if (arrB[index] == K)
                {
                    Console.WriteLine("index first K = " + index);
                    break;
                }
                index++;
            }

            //   задача не дорешена!!!






        }
    }
}
