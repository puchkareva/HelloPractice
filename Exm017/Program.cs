using System;

namespace Exm017
{
    class Program
    {
        static void Main(string[] args)
        {
            // =============== ## Рекурсия ===============

            // ======== 66. Показать натуральные числа от 1 до N, N задано ========

            // решение 1, цикл не работает
            // int NaturalNum(int n)
            //     {
            //         if (n == 1) return n;
            //         else return NaturalNum(n - 1);
            //     }

            //     for (int i = 0; i < 10; i++)
            //     {
            //         Console.WriteLine(NaturalNum(i));
            //     }

            // решение 2
            // string NaturalNum(int n)
            // {
            //     if (n == 1)
            //     {
            //         return "1";
            //     }
            //     return NaturalNum(n - 1) + " " + n;
            // }

            // Console.WriteLine(NaturalNum(10));


            // ======= 67. Показать натуральные числа от N до 1, N задано =============

            // string NaturalNum(int n)
            // {
            //     if (n == 1)
            //     {
            //         return "1";
            //     }
            //     return n + " " + NaturalNum(n - 1);
            // }

            // Console.WriteLine(NaturalNum(10));


            // ========== 68. Показать натуральные числа от M до N, N и M заданы =============

            // string NaturalNum(int m, int n)
            // {
            //     if (n == m)
            //     {
            //         return Convert.ToString(m);
            //     }
            //     return NaturalNum(m, n - 1) + " " + n;
            // }

            // Console.WriteLine(NaturalNum(5, 20));


            // 69. Найти сумму элементов от M до N, N и M заданы
            // 70. Найти сумму цифр числа
            // 71. Написать программу вычисления функции Аккермана
            // 72. Написать программу возведения числа А в целую стень B
            // 73. Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем
            // 74. В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита

        }
    }
}

