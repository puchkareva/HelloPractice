using System;

namespace Exm013
{
    class Program
    {
        static void Main(string[] args)
        {

            // =========== Почувствуй себя сеньором =======================
            // ========== 31. Задать массив из 8 элементов и вывести их на экран  ==============

            int[] CreateArray(int count)
            {
                return new int[count];
            }

            string PrintArray(int[] array)
            {
                string res = String.Empty;
                for (int i = 0; i < array.Length; i++)
                {
                    res += $"{array[i]} ";
                }
                return res;
            }

            // int[] A = CreateArray(8);
            // Console.WriteLine(PrintArray(A));


            // ====== 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран ======


            void FillArray(int[] array, int minValue, int maxValue)
            {
                string res = String.Empty;
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = new Random().Next(minValue, maxValue + 1);
                }
            }

            // int[] B = CreateArray(8);
            // FillArray(B, 0, 1);
            // Console.WriteLine(PrintArray(B));


            // ======== 33. Задать массив из 12 элементов, заполненных числами из [0,9]. =========
            // =============Найти сумму положительных/отрицательных элементов массива ============

            // int SumArray(int[] arr)
            // {
            //     int sum = 0;
            //     for (int i = 0; i < arr.Length; i++)
            //     {
            //         sum = sum + arr[i];
            //     }
            //     return sum;
            // }

            // int[] C = CreateArray(12);
            // FillArray(C, 0, 9);
            // Console.WriteLine(PrintArray(C));
            // Console.WriteLine(SumArray(C));


            // ========== 34. Написать программу замену элементов массива на противоположные =======

            // void ChangeOpposite(int[] array)
            // {
            //     string res = String.Empty;
            //     for (int i = 0; i < array.Length; i++)
            //     {
            //         array[i] = -array[i];
            //     }
            // }

            // int[] D = CreateArray(10);
            // FillArray(D, -10, 10);
            // Console.WriteLine(PrintArray(D));
            // ChangeOpposite(D);
            // Console.WriteLine(PrintArray(D));


            // ====== 35. Определить, присутствует ли в заданном массиве, некоторое число ======

            // bool FindNum(int[] array, int x)
            // {
            //     bool res = false;
            //     for (int i = 0; i < array.Length; i++)
            //     {
            //         if (array[i] == x)
            //         {
            //             res = true;
            //             break;
            //         }
            //     }
            //     return res;
            // }

            // int[] E = CreateArray(10);
            // FillArray(E, 0, 10);
            // Console.WriteLine(PrintArray(E));
            // Console.WriteLine(FindNum(E, 7));


            // ===== 36. Задать массив, заполнить случайными положительными трёхзначными числами. ===========
            // ========= Показать количество нечетных\четных чисел ===============

            // int NumberOfEven(int[] array) // показывает количество четных
            // {
            //     int count = 0;
            //     for (int i = 0; i < array.Length; i++)
            //     {
            //         if (array[i] % 2 == 0)
            //         {
            //             count = count + 1;
            //         }
            //     }
            //     return count;
            // }

            // int[] F = CreateArray(10);
            // FillArray(F, 100, 1000);
            // Console.WriteLine(PrintArray(F));
            // Console.WriteLine(NumberOfEven(F));

            // int NumberOfOdd(int[] array) // показывает количество нечетных
            // {
            //     int count = 0;
            //     for (int i = 0; i < array.Length; i++)
            //     {
            //         if (array[i] % 2 != 0)
            //         {
            //             count = count + 1;
            //         }
            //     }
            //     return count;
            // }

            // int[] F = CreateArray(10);
            // FillArray(F, 100, 1000);
            // Console.WriteLine(PrintArray(F));
            // Console.WriteLine(NumberOfOdd(F));


            // ===== 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99] ======

            // int FindN (int[] array) 
            // {
            //     int count = 0;
            //     for (int i = 0; i < array.Length; i++)
            //     {
            //         if (10 <= array[i] && array [i] <= 99)
            //         {
            //             count = count + 1;
            //         }
            //     }
            //     return count;
            // }

            // int[] G = CreateArray(123);
            // FillArray(G, 0, 1000);
            // Console.WriteLine(PrintArray(G));
            // Console.WriteLine(FindN(G));

            // ======== 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции ===========

            // int FindSumOdd (int[] array)
            // {
            //     int sum = 0;
            //     for (int i = 1; i < array.Length; i+= 2)
            //     {
            //         sum = sum + array[i];
            //     }
            //     return sum;
            // }

            // int[] K = CreateArray(10);
            // FillArray(K, 0, 10);
            // Console.WriteLine(PrintArray(K));
            // Console.WriteLine(FindSumOdd(K));


            // ======== 39. Найти произведение пар чисел в одномерном массиве. ====================
            // ============ Парой считаем первый и последний элемент, второй и предпоследний и т.д. =========

            // string FindProductPairs (int[] array)
            // {
            //     string res = String.Empty; 
            //     int result = 0;
            //     int last = array.Length-1;
            //     for (int i = 0; i < array.Length/2; i++, last--)
            //     {
            //         result = array[i] * array[last];
            //         res += $"{result} ";
            //     }
            //     return res;
            // }

            // int[] L = CreateArray(10);
            // FillArray(L, 0, 10);
            // Console.WriteLine(PrintArray(L));
            // Console.WriteLine(FindProductPairs(L));


            // ======= 40. В Указанном массиве вещественных чисел найдите разницу  =============
            // =========== между максимальным и минимальным элементом ================== 

            // double[] CreateDoubleArray()
            // {
            //     double[] array = new double[10];
            //     for (int i = 0; i < array.Length; i++)
            //     {
            //         array[i] = new Random().NextDouble();
            //     }
            //     return array;
            // }

            // string PrintDoubleArray(double[] array)
            // {
            //     string res = String.Empty;
            //     for (int i = 0; i < array.Length; i++)
            //     {
            //         res += $"{array[i]} ";
            //     }
            //     return res;
            // }

            // double FindMax(double[] array)
            // {
            //     double max = 0.0;
            //     for (int i = 0; i < array.Length; i++)
            //     {
            //         if (array[i] > max) max = array[i];
            //     }
            //     return max;
            // }

            // double FindMin(double[] array)
            // {
            //     double min = 1.0;
            //     for (int i = 0; i < array.Length; i++)
            //     {
            //         if (array[i] < min) min = array[i];
            //     }
            //     return min;
            // }

            // double FindDiff(double max, double min)
            // {
            //     return max - min;
            // }

            // double[] M = CreateDoubleArray();
            // Console.WriteLine(PrintDoubleArray(M));
            // Console.WriteLine(FindMax(M));
            // Console.WriteLine(FindMin(M));
            // Console.WriteLine(FindDiff(FindMax(M), FindMin(M)));


            // ============= Почувствуй себя лидом ==================
            // ========== 41. Выяснить являются ли три числа сторонами треугольника ==============

            // bool Triangle(int a, int b, int c)
            // {
            //     return (a < b + c) && (b < a + c) && (c < a + b);
            // }

            // Console.WriteLine(Triangle(6, 2, 7));


            // ======== 42. Определить сколько чисел больше 0 введено с клавиатуры ==============

            // 43. Написать программу преобразования десятичного числа в двоичное
            // 44. Найти точку пересечения двух прямых заданных уравнением y=kx+b, а1 k1 и а2 и k2 заданы
            // 45. Показать числа Фибоначчи
            // 46. Написать программу масштабирования фигуры
            // 47. Написать программу копирования массива


           

        }
    }
}
