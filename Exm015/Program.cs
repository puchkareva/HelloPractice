﻿using System;

namespace Exm015
{
    class Program
    {
        static void Main(string[] args)
        {
            // Двумерные массивы и рекурсия

            // string[,] table = new string[2, 5];
            // //String.Empty - иницилизация для строк
            // // table [0,0] table [0,1]  table [0, 2] ... table [0,4]
            // // table [1,0] table [1,1]  table [1, 2] ... table [1,4]

            // table[1, 2] = "слово";

            // for (int rows = 0; rows < 2; rows++)
            // {
            //     for (int columns = 0; columns < 5; columns++)
            //     {
            //         Console.WriteLine($"-{table[rows, columns]}-");
            //     }
            // }

            // int[,] matrix = new int[3, 4];
            // for (int i = 0; i < matrix.GetLength(0); i++) // for (int i = 0; i < 3; i++)
            // {
            //     for (int j = 0; j < matrix.GetLength(1); j++) // for (int j = 0; j < 4, i++)
            //     {
            //         Console.Write($"{matrix[i, j]} ");
            //     }
            //     Console.WriteLine();
            // }

            // // Метод для печати двумерной матрицы

            // void PrintArray(int[,] matr)
            // {
            //     for (int i = 0; i < matr.GetLength(0); i++)
            //     {
            //         for (int j = 0; j < matr.GetLength(1); j++)
            //         {
            //             Console.Write($"{matr[i, j]} ");
            //         }
            //         Console.WriteLine();
            //     }
            // }

            // // Метод для заполнения двумерной матрицы

            // void FillArray(int[,] matr)
            // {
            //     for (int i = 0; i < matr.GetLength(0); i++)
            //     {
            //         for (int j = 0; j < matr.GetLength(1); j++)
            //         {
            //             matr[i, j] = new Random().Next(1, 10); // [1, 10)
            //         }
            //     }
            // }

            // int[,] matrix = new int[3, 4];
            // PrintArray(matrix);
            // FillArray(matrix);
            // Console.WriteLine();
            // PrintArray(matrix);

            // Закрашивание черно-белого изображения

            //     int[,] pic = new int[,]
            // {
            //     {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
            //     {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
            //     {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
            //     {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
            //     {0,0,0,0,0,0,0,0,0,0,0,-1,-1,-1,-1,-1,-1,-1,0,0,0,0,0,0,0,0,0,0,0,0,-1,-1,-1,-1,-1,-1,-1,-1,-1,0,0,0,0,0,0,0,0,0,0,0},
            //     {0,0,0,0,0,0,0,0,-1,-1,-1,-1,0,0,0,0,0,-1,-1,-1,-1,-1,-1,-1,0,0,-1,-1,-1,-1,-1,0,0,0,0,0,0,0,-1,-1,-1,0,0,0,0,0,0,0,0,0},
            //     {0,0,0,0,0,0,-1,-1,-1,0,0,0,0,0,0,0,0,0,0,0,0,0,-1,-1,-1,-1,-1,0,0,0,0,0,0,0,0,0,0,0,0,0,-1,-1,-1,0,0,0,0,0,0,0},
            //     {0,0,0,0,-1,-1,-1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-1,-1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-1,-1,0,0,0,0,0,0},
            //     {0,0,0,-1,-1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-1,-1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-1,-1,0,0,0,0,0},
            //     {0,0,-1,-1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-1,-1,0,0,0,0},
            //     {0,0,-1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-1,-1,-1,-1,0,0},
            //     {0,0,-1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-1,-1,-1,-1,0,0},
            //     {0,0,-1,-1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-1,-1,-1,-1,0,0,0},
            //     {0,0,0,-1,-1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-1,-1,-1,-1,-1,0,0,0},
            //     {0,0,0,0,-1,-1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-1,-1,-1,-1,-1,-1,0,0,0,0,0,0},
            //     {0,0,0,0,0,-1,-1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-1,-1,-1,-1,-1,-1,-1,0,0,0,0,0,0,0,0},
            //     {0,0,0,0,0,0,-1,-1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-1,-1,-1,-1,-1,-1,-1,-1,-1,0,0,0,0,0,0,0,0},
            //     {0,0,0,0,0,0,0,-1,-1,-1,-1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-1,-1,-1,-1,-1,-1,0,0,0,0,0,0,0,0,0,0,0,0,0},
            //     {0,0,0,0,0,0,0,0,0,0,-1,-1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-1,-1,-1,-1,-1,-1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
            //     {0,0,0,0,0,0,0,0,0,0,0,-1,-1,-1,0,0,0,0,0,0,0,0,0,0,0,0,0,-1,-1,-1,-1,-1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
            //     {0,0,0,0,0,0,0,0,0,0,0,0,0,-1,-1,-1,0,0,0,0,0,0,0,0,0,0,-1,-1,-1,-1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
            //     {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-1,-1,-1,0,0,0,0,0,0,0,0,-1,-1,-1,-1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
            //     {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-1,-1,-1,0,0,0,0,-1,-1,-1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
            //     {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-1,-1,0,0,0,-1,-1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
            //     {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-1,-1,-1,-1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
            //     {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-1,-1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
            //     {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
            //     {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
            //     {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
            //      {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
            //     {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},


            // };


            // void PrintImage(int[,] image)
            // {
            //     for (int i = 0; i < image.GetLength(0); i++)
            //     {
            //         for (int j = 0; j < image.GetLength(1); j++)
            //         {
            //             // Console.Write($"{image[i, j]} ");
            //             if (image[i, j] == 0) Console.Write($" ");
            //             else Console.Write($"+");
            //         }
            //         Console.WriteLine();
            //     }
            // }

            // PrintImage(pic);

            // // Метод для закрашивания картинки

            // void FillImage(int row, int col)
            // {
            //     if (pic[row, col] == 0)
            //     {
            //         pic[row, col] = 1;
            //         FillImage(row - 1, col);
            //         FillImage(row, col - 1);
            //         FillImage(row + 1, col);
            //         FillImage(row, col + 1);
            //     }
            // }
            // FillImage(13, 13);
            // PrintImage(pic);


            // // Факториал

            // double Factorial(int n)
            // {
            //     // 1! = 1
            //     // 0! = 1
            //     if (n == 1) return 1;
            //     else return n * Factorial(n - 1);
            // }
            // for (int i = 0; i < 40; i++)
            // {
            //     Console.WriteLine($"{i}! = {Factorial(i)}");
            // }


            // // Числа Фибоначчи 
            // // f(1) = 1
            // // f(2) = 1
            // // f(n) = f(n-1) + f(n-2)

            // double Fibonacci(int n)
            // {
            //     if (n == 1 || n ==2) return 1;
            //     else return Fibonacci(n-1) + Fibonacci(n-2);
            // }

            // for (int i = 1; i < 50; i++)
            // {
            //     Console.WriteLine($"f({i}) = {Fibonacci(i)}");
            // }


            



        }
    }
}
