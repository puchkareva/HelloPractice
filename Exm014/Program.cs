using System;

namespace Exm014
{
    class Program
    {
        static void Main(string[] args)
        {

            // ============= Почувствуй себя лидом ==================
            // ========== 41. Выяснить являются ли три числа сторонами треугольника ==============

            // bool Triangle(int a, int b, int c)
            // {
            //     return (a < b + c) && (b < a + c) && (c < a + b);
            // }

            // Console.WriteLine(Triangle(6, 2, 7));


            // ======== 42. Определить сколько чисел больше 0 введено с клавиатуры ==============

            // первое решение
            // int FindNumbers(int n)
            // {
            //     int count = 0;
            //     for (int i = 0; i < n; i++)
            //     {
            //         Console.WriteLine("Введите число: ");
            //         int number = int.Parse(Console.ReadLine());
            //         if (number > 0) count++;
            //     }
            //     return count;
            // }
            // Console.WriteLine(FindNumbers(3));

            // в процессе решения
            // string EnterNumbers()
            // {
            //     Console.WriteLine("Введите числа через пробел:");
            //     return Console.ReadLine();
            // }
            // string numbers = EnterNumbers();

            // // int lengthOfArray(string txt)
            // // {
            // //     int len = 0;
            // //     for (int i = 0; i < txt.Length; i++)
            // //     {
            // //         if (txt[i] == ' ') len++;
            // //     }
            // //     return len;
            // // }

            // int[] ArrayN(string text)
            // {
            //     text += " ";
            //     int len = text.Length;
            //     int[] array = new int[len];
            //     int indexArray = 0;
            //     string s = String.Empty;
            //     for (int i = 0; i < len; i++)
            //     {
            //         if (text[i] == ' ')
            //         {
            //             array[indexArray++] = Convert.ToInt32(s);
            //             s = String.Empty;
            //         }
            //         else
            //         {
            //             s += $"{text[i]}";
            //         }
            //     }
            //     return array;
            // }

            // string PrintArray(int[] array)
            // {
            //     string res = String.Empty;
            //     for (int i = 0; i < array.Length; i++)
            //     {
            //         res += $"{array[i]} ";
            //     }
            //     return res;
            // }

            // int[] A = ArrayN(numbers);
            // Console.WriteLine(PrintArray(A));


            // ====== 43. Написать программу преобразования десятичного числа в двоичное ====

            // string DecimalToBinary(int D)
            // {
            //     string B = String.Empty;
            //     while (D > 0)
            //     {
            //         B = (D % 2) + B;
            //         D = D/2;
            //     }
            //     return B;
            // }
            // Console.WriteLine(DecimalToBinary(7));


            // ==========44. Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, =====
            // ============  b1 k1 и b2 и k2 заданы ====

            // (double, double) IntersectionPoint(double b1, double k1, double b2, double k2)
            // {
            //     double x = (b2 - b1) / (k1 - k2);
            //     double y = k2 * x + b2;
            //     return (x, y);
            // }

            // Console.WriteLine(IntersectionPoint(2, 10, 3, 8));


            // ========== 45. Показать числа Фибоначчи ==============
            // Числа Фибоначчи - числовая последовательность, в которой первые два числа равны 0 и 1, 
            // а каждое последующее число равно сумме двух предыдущих чисел (0, 1, 1, 2, 3, 5, 8, 13, 21, 34, ...)

            // double Fibonacci(int n)
            // {
            //     if (n == 1 || n ==2) return 1;
            //     else return Fibonacci(n-1) + Fibonacci(n-2);
            // }

            // for (int i = 1; i < 20; i++)
            // {
            //     Console.WriteLine(Fibonacci(i));
            // }

            // //  другое решение (массив)

            // int[] FibonacciSequence(int n)
            // {
            //     int[] fib = new int[n];
            //     fib[0] = 0;
            //     fib[1] = 1;
            //     for (int i = 2; i < n; i++)
            //     {
            //         fib[i] = fib[i - 2] + fib[i - 1];
            //     }
            //     return fib;
            // }

            // string PrintArray(int[] array)
            // {
            //     string res = String.Empty;
            //     for (int i = 0; i < array.Length; i++)
            //     {
            //         res += $"{array[i]} ";
            //     }
            //     return res;
            // }

            // int[] a = FibonacciSequence(10);
            // Console.WriteLine(PrintArray(a));


            // ========== 46. Написать программу масштабирования фигуры =============

            //  в процессе решения
            // Console.WriteLine("Введите координаты треугольника a, b, c: ");
            // string triangle = Console.ReadLine();
            // int triang = Convert.ToInt32(triangle);



            // ========== 47. Написать программу копирования массива =================

            // int[] CopyArray(int[] array)
            // {
            //     int[] copy = new int[array.Length];
            //     for (int i = 0; i < array.Length; i++)
            //     {
            //         copy[i] = array[i];
            //     }
            //     return copy;
            // }

            // int[] CreateArray(int count)
            // {
            //     return new int[count];
            // }

            // void FillArray(int[] array, int minValue, int maxValue)
            // {
            //     string res = String.Empty;
            //     for (int i = 0; i < array.Length; i++)
            //     {
            //         array[i] = new Random().Next(minValue, maxValue + 1);
            //     }
            // }

            // string PrintArray(int[] array)
            // {
            //     string res = String.Empty;
            //     for (int i = 0; i < array.Length; i++)
            //     {
            //         res += $"{array[i]} ";
            //     }
            //     return res;
            // }

            // int[] arrA = CreateArray(10);
            // FillArray(arrA, 0, 10);
            // Console.WriteLine(PrintArray(arrA));
            // int[] arrB = CopyArray(arrA);
            // Console.WriteLine(PrintArray(arrB));

        }
    }
}
