﻿using System;

namespace Exm008
{
    class Program
    {
        static void Main(string[] args)
        {
            // 0. Вывести квадрат числа 

            int SquareNumber(int arg) // метод квадрата числа
            {
                return arg * arg;
                // int square = arg * arg;
                // return square;
            }

            int number = new Random().Next(1, 10);
            Console.WriteLine($"Число {number} в квадрате = {SquareNumber(number)}");

            // 1. По двум заданным числам проверять является ли первое квадратом второго 

            string CheckSquare(int arg1, int arg2)
            {
                if (arg1 == arg2 * arg2)
                {
                    return "true";
                }
                else
                {
                    return "false";
                }
            }

            int numA = new Random().Next(1, 100);
            int numB = new Random().Next(1, 10);

            Console.WriteLine($"Является ли число {numA} квадратом числа {numB}? Ответ - {CheckSquare(numA, numB)}");

            // 2. Даны два числа. Показать большее и меньшее число 

            void MoreLess(int a, int b)
            {
                if (a > b)
                {
                    Console.WriteLine($"Большее = {a}, меньшее = {b}");
                }
                if (a < b)
                {
                    Console.WriteLine($"Большее = {b}, меньшее = {a}");
                }
                if (a == b)
                {
                    Console.WriteLine($"Числа {a} и {b} равны");
                }
            }

            MoreLess(numA, numB);

            // 3. По заданному номеру дня недели вывести его название

            // void DayOfWeek(int dayN)
            // {
            //     string[] array = { "Понедельник", "Вторник", "Cреда", "Четверг", "Пятница", "Cуббота", "Воскресенье" };
            //     Console.WriteLine(array[dayN - 1]);
            // }

            // DayOfWeek(3);

            string DayOfWeek(int dayN)
            {
                string[] array = { "Понедельник", "Вторник", "Cреда", "Четверг", "Пятница", "Cуббота", "Воскресенье" };
                return array[dayN - 1];
            }
            int daynum = new Random().Next(1, 8);
            Console.WriteLine($"{daynum} день недели - это {DayOfWeek(daynum)}");

            // 4. Найти максимальное из трех чисел 

            int RandomNum(int minValue, int maxValue)
            {
                int num = new Random().Next(minValue, maxValue);
                return num;
            }
            int a = RandomNum(1, 100);
            int b = RandomNum(1, 100);
            int c = RandomNum(1, 100);

            int FindMax(int a1, int a2, int a3)
            {
                int result = a1;
                if (a2 > result) result = a2;
                if (a3 > result) result = a3;
                return result;
            }

            // FindMax(a, b, c);
            Console.WriteLine($"Максимальное из чисел {a}, {b}, {c} = {FindMax(a, b, c)}");

            // 5. Написать программу вычисления значения функции y=f(a) 

            double Function(double a)
            {
                double result = Math.Sin(a);
                return result;
            }

            double sin = Function(10);
            Console.WriteLine(sin);

            // 6. Выяснить является ли число чётным 

            void EvenNumber(int num)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine($"Число {num} является четным");
                }
                else
                {
                    Console.WriteLine($"Число {num} не является четным");
                }
            }

            int d = RandomNum(1, 20);
            EvenNumber(d);

            // 7. Показать числа от -N до N

            string ShowNums(int N)
            {
                string NumsShow = "";
                for (int i = -N; i <= N; i++)
                {
                    NumsShow = NumsShow + i + " ";
                }
                return NumsShow;
            }

            int num = RandomNum(1, 10);
            Console.WriteLine(ShowNums(num));

            // 8. Показать четные числа от 1 до N 

            // void CreateArray(int[] array, int minValue, int maxValue)
            // {
            //     for (int i = 0; i < array.Length; i++)
            //     {
            //         array[i] = new Random().Next(minValue, maxValue);
            //         Console.Write($"{array[i]} ");
            //     }
            // }

            // int[] arrayA = new int[10];
            // CreateArray(arrayA, 1, 100);

            // void ShowEvenNum(int [] array, int minValue, int maxValue) //выводит только четные числа массива
            // {
            //     for (int i = 0; i < array.Length; i++)
            //     {
            //         array[i] = new Random().Next(minValue, maxValue);
            //         if (array[i] % 2 == 0)
            //         {
            //             Console.Write($"{array[i]} ");
            //         }
            //     }
            // }

            // int[] arrayA = new int[10];
            // ShowEvenNum(arrayA, 1, 100);

            void EvenNumbers(int N)
            {
                for (int i = 2; i <= N; i += 2)
                {
                    Console.Write($"{i} ");
                }
            }
            int N = 20;
            EvenNumbers(N);

            Console.WriteLine();

            // 9. Показать последнюю цифру трёхзначного числа

            int LastNumber(int N)
            {
                return N % 10;
            }

            int e = RandomNum(100, 1000);
            Console.WriteLine($"Последняя цифра числа {e} = {LastNumber(e)}");

            // 10. Показать вторую цифру трёхзначного числа

            int SecondNumber(int N)
            {
                return N % 100 / 10;
            }

            int f = RandomNum(100, 1000);
            Console.WriteLine($"Вторая цифра числа {f} = {SecondNumber(f)}");

            // 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

            int MaxNum(int Num)
            {
                if (Num / 10 > Num % 10)
                {
                    return Num / 10;
                }
                else
                {
                    return Num % 10;
                }
            }

            int g = RandomNum(10, 99);
            Console.WriteLine($"Наибольшая цифра числа {g} = {MaxNum(g)}");

            // 12. Удалить вторую цифру трёхзначного числа

            void DelSecondNum(int num)
            {
                int first = (num / 100);
                int last = (num % 10);
                //int new = first * 10 + last;
                Console.WriteLine($"Число {num} без второй цифры = {first}{last}");
            }

            int k = RandomNum(100, 1000);
            DelSecondNum(k);

            // 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.

            void Multiple (int num1, int num2)
            {
                if(num1 % num2 == 0)
                {
                    Console.WriteLine($"Число {num1} кратно числу {num2}");
                }
                else
                {
                    double num3 = num1 % num2;
                    Console.WriteLine($"Остаток деления {num1} на {num2} = {num3}");
                }
            }

            // int m = RandomNum(1, 100);
            // int n = RandomNum(1, 10);
            // Multiple(m, n);
            
            Multiple(20, 3);

            // 14. Найти третью цифру числа или сообщить, что её нет*/ 

            int LastNumber(int N)
            {
                if
                {

                }
                return N % 10;
            }

            int e = RandomNum(1, 100);
            Console.WriteLine($"Последняя цифра числа {e} = {LastNumber(e)}");






        }
    }
}
