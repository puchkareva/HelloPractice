using System;

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

            int RandomNum()
            {
                int num = new Random().Next(1, 100);
                return num;
            }
            int a = RandomNum();
            int b = RandomNum();
            int c = RandomNum();

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

            int d = RandomNum();
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

            int num = 10;
            Console.WriteLine(ShowNums(num));

            // 8. Показать четные числа от 1 до N 

            // int[] arrayB = new int(10);

            // CreateArray(arrayB, 1, 100);
            // PrintArray(arrayB);

            // void ShowEvenNum(int array)
            // {
            //     for (int i = 0; i < array.Length; i++)
            //     {
            //         if (array[i] % 2 == 0)
            //         {
            //             Console.Write($"{array[i]} ");
            //         }
            //     }
            // }

            // 9. Показать последнюю цифру трёхзначного числа
            // 10. Показать вторую цифру трёхзначного числа
            // 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
            // 12. Удалить вторую цифру трёхзначного числа
            // 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.
            // 14. Найти третью цифру числа или сообщить, что её нет*/ 


        }
    }
}
