﻿using System;

namespace Exm011
{
    class Program
    {
        static void Main(string[] args)
        {

            // ================ Почувствуй себя мидлом =============
            // ============ 23. Показать таблицу квадратов чисел от 1 до N ============= 

            // Решение 1
            // void Pow2(int n)
            // {
            //     for (int i = 1; i <= n; i++)
            //     {
            //         Console.WriteLine($"{i}^2 = {i * i}");
            //        // Console.WriteLine($"{i}^2 = {Math.Pow(i,2)}");
            //     }
            // }

            // Pow2(5);

            // Решение 2
            // double[] Pow2(int n)
            // {
            //     double[] array = new double[n];
            //     for (int i = 1; i <= n; i++)
            //     {
            //         array[i - 1] = Math.Pow(i, 2);
            //     }
            //     return array;
            // }

            // double[] Sqr = Pow2(5);
            // for (int index = 0; index < Sqr.Length; index++)
            //     Console.WriteLine(Sqr[index]);


            // ============ 24. Найти кубы чисел от 1 до N =============

            // Решение 1
            // void Pow3(int n)
            // {
            //     for (int i = 1; i <= n; i++)
            //     {
            //         Console.WriteLine($"{i}^3 = {i * i * i}");
            //         //Console.WriteLine($"{i}^3 = {Math.Pow(i,3)}");
            //     }
            // }
            // Pow3(5);

            // Решение 2
            // double[] Pow3(int n)
            // {
            //     double[] array = new double[n];
            //     for (int i = 1; i <= n; i++)
            //     {
            //         array[i - 1] = Math.Pow(i, 3);
            //     }
            //     return array;
            // }
            // double[] Cube = Pow3(5);
            // for (int index = 0; index < Cube.Length; index++) Console.WriteLine(Cube[index]);


            // ============ 25. Найти сумму чисел от 1 до А ===============

            // int SumOfNumbers(int a)
            // {
            //     int sum = 0;
            //     for (int i = 1; i <= a; i++)
            //     {
            //         sum = sum + i;
            //     }
            //     return sum;
            // }
            // Console.WriteLine(SumOfNumbers(10));


            // ========== 26. Возведите число А в натуральную степень B используя цикл ========

            //  Решение без цикла
            // double Pow(int a, int b)
            // {
            //     return Math.Pow(a, b);
            // }
            // Console.WriteLine(Pow(3, 2));

            // double fPow(double numA, int numB)
            // {
            //     double result = numA;
            //     for (int i = 1; i < numB; i++) result = result * numA;
            //     return result;
            // }
            // double a = 2.2;
            // int b = 3;
            // Console.WriteLine(fPow(a, b));

            // ================= 27. Определить количество цифр в числе =================

            // Решение 1
            // int FindNum (int n)
            // {
            //     int result = 1;
            //     int divider = 10;
            //     for(int i = 2; i <= n; i++)
            //     {
            //         if(n / divider !=0)
            //         {
            //             divider = divider * 10;
            //             result = i;
            //         }
            //     }
            //     return result;
            // }
            // Console.WriteLine(FindNum(0));

            // Решение 2
            // int FindNum(int n)
            // {
            //     if(n==0) return 1;
            //     int result = 0;
            //     while (n != 0) { result++; n /= 10; }
            //     return result;
            // }
            // Console.WriteLine(FindNum(0));


            // ============== 28. Подсчитать сумму цифр в числе =================

            // int FindSumNum(int n)
            // {
            //     int result = 0;
            //     while (n != 0) { result = result + n % 10; n /= 10; }
            //     return result;
            // }
            // Console.WriteLine(FindSumNum(1543));


            // =============== 29. Написать программу вычисления произведения чисел от 1 до N ============

            // int fProduct(int n)
            // {
            //     int result = 1;
            //     for (int i = 1; i <= n; i++) { result = result * i; }
            //     return result;
            // }
            // Console.WriteLine(fProduct(5));


            // ========= 30. Показать кубы чисел, заканчивающихся на четную цифру ===============

            // double[] PowEven3(int n)
            // {
            //     double[] array = new double[n / 2];
            //     int count = 0;
            //     for (int i = 2; i <= n; i+=2)
            //     {
            //         array[count] = Math.Pow(i, 3);
            //         count++;
            //     }
            //     return array;
            // }
            // double[] Cube = PowEven3(10);
            // for (int index = 0; index < Cube.Length; index++) Console.WriteLine(Cube[index]);


            // =========== Почувствуй себя сеньором =======================
            // ========== 31. Задать массив из 8 элементов и вывести их на экран  ==============

           




            // 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран 
            // 33. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
            // 34. Написать программу замену элементов массива на противоположные
            // 35. Определить, присутствует ли в заданном массиве, некоторое число 
            // 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
            // 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
            // 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции
            // 39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
            // 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

            // Почувствуй себя лидом
            // 41. Выяснить являются ли три числа сторонами треугольника 
            // 42. Определить сколько чисел больше 0 введено с клавиатуры
            // 43. Написать программу преобразования десятичного числа в двоичное
            // 44. Найти точку пересечения двух прямых заданных уравнением y=kx+b, а1 k1 и а2 и k2 заданы
            // 45. Показать числа Фибоначчи
            // 46. Написать программу масштабирования фигуры
            // 47. Написать программу копирования массива

        }
    }
}
