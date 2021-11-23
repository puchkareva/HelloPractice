using System;

namespace Exm016
{
    class Program
    {
        static void Main(string[] arr)
        {
            // ============= ## Двумерные массивы ===============

            // ========= 48. Показать двумерный массив размером m×n заполненный целыми числами ========

            int[,] CreateArray(int row, int column)
            {
                return new int[row, column];
            }


            void FillArray(int[,] array, int minValue, int maxValue)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i, j] = new Random().Next(minValue, maxValue + 1);
                    }
                }
            }

            void PrintArray(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write($"{array[i, j]} ");
                    }
                    Console.WriteLine();
                }
            }

            // int m = new Random().Next(2, 10);
            // int n = new Random().Next(2, 10);
            // int[,] ArrA = CreateArray(m, n);
            // FillArray(ArrA, -100, 100);
            // PrintArray(ArrA);


            // ====== 49. Показать двумерный массив размером m×n заполненный вещественными числами  =========

            // double[,] CreateArray(int row, int column)
            // {
            //     return new double[row, column];
            // }


            // void FillArray(double[,] array)
            // {
            //     for (int i = 0; i < array.GetLength(0); i++)
            //     {
            //         for (int j = 0; j < array.GetLength(1); j++)
            //         {
            //             array[i, j] = new Random().NextDouble() * 100;
            //         }
            //     }
            // }

            // void PrintArray(double[,] array)
            // {
            //     for (int i = 0; i < array.GetLength(0); i++)
            //     {
            //         for (int j = 0; j < array.GetLength(1); j++)
            //         {
            //             Console.Write($"{array[i, j]} ");
            //         }
            //         Console.WriteLine();
            //     }
            // }

            // int m = new Random().Next(2, 5);
            // int n = new Random().Next(2, 5);
            // double[,] ArrB = CreateArray(m, n);
            // FillArray(ArrB);
            // PrintArray(ArrB);


            // ========= 50. В двумерном массиве n×k заменить четные элементы на противоположные =========

            // int[,] EvenToOpposite(int[,] array)
            // {
            //     for (int i = 0; i < array.GetLength(0); i++)
            //     {
            //         for (int j = 0; j < array.GetLength(1); j++)
            //         {
            //             if (array[i, j] % 2 == 0) array[i, j] = -array[i, j];
            //         }
            //     }
            //     return array;
            // }

            // int n = new Random().Next(2, 10);
            // int k = new Random().Next(2, 10);
            // int[,] ArrC = CreateArray(n, k);
            // FillArray(ArrC, 0, 100);
            // PrintArray(ArrC);
            // EvenToOpposite(ArrC);
            // Console.WriteLine();
            // PrintArray(ArrC);


            // ========= 51. Задать двумерный массив следующим правилом: Aₘₙ = m+n ===========

            // void FillArrayRule(int[,] array)
            // {
            //     for (int i = 0; i < array.GetLength(0); i++)
            //     {
            //         for (int j = 0; j < array.GetLength(1); j++)
            //         {
            //             array[i, j] = i + j;
            //         }
            //     }
            // }

            // int m = new Random().Next(5, 10);
            // int n = new Random().Next(5, 10);
            // int[,] ArrD = CreateArray(m, n);
            // FillArrayRule(ArrD);
            // PrintArray(ArrD);


            // ======= 52. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты =====

            // int[,] ReplaceEvenToSquare(int[,] array)
            // {
            //     for (int i = 0; i < array.GetLength(0); i += 2)
            //     {
            //         for (int j = 0; j < array.GetLength(1); j += 2)
            //         {
            //             array[i, j] *= array[i, j];
            //         }
            //     }
            //     return array;
            // }

            // int[,] ArrE = CreateArray(6, 7);
            // FillArray(ArrE, 0, 100);
            // PrintArray(ArrE);
            // ReplaceEvenToSquare(ArrE);
            // Console.WriteLine();
            // PrintArray(ArrE);

            // ======== 53. В двумерном массиве показать позиции числа, заданного пользователем или указать, ======
            // ============ что такого элемента нет =============

            
            // 54. В матрице чисел найти сумму элементов главной диагонали
            // 55. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
            // 56. Написать программу, которая обменивает элементы первой строки и последней строки
            // 57. Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.
            // 58. Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить
            // 59. В прямоугольной матрице найти строку с наименьшей суммой элементов.
            // 60. Составить частотный словарь элементов двумерного массива
            // 61. Найти произведение двух матриц
            // 62. В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.
            // 63. Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента
            // 64. Показать треугольник Паскаля
            // *Сделать вывод в виде равнобедренного треугольника
            // 65. Спирально заполнить двумерный массив:
            // ```
            //   1  2  3  4
            //  12 13 14  5
            //  11 16 15  6
            //  10  9  8  7 
            // ```



        }
    }
}
