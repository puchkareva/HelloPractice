using System;

namespace Exm004
{
    class Program
    {
        static void Main(string[] args)
        {
            
        /*    
        // Задача 1. Посчитать количество натуральных чисел, 
        // не превосходящих заданного числа n, которое
        // делится на k, но не на l
        // делится хотя бы на k или на l
        // не делится на (k + l)

        int number = 1;
        int n = 100;
        int count = 0;
        int k = 8;
        int l = 7;


        while (number <= n)
        {
             bool flag1 = (number % k == 0);
             bool flag2 = (number % l != 0);

             if (flag1 && flag2)
             {
                count++;
             }
             number++;
        }

        Console.WriteLine(count);

        

         while (number <= n)
        {
             bool flag1 = (number % k == 0);
             bool flag2 = (number % l == 0);

             if (flag1 | flag2)
             {
                count++;
             }
             number++;
        }

        Console.WriteLine(count);


         while (number <= n)
        {
             if ((number % (k + l)) != 0)
             {
                count++;
             }
             number++;
        }

        Console.WriteLine(count);

         */

        // Решение задачи через метод

        int Check(int n, int k, int l)
        {
            int count = 0;
            int number = 1;

            while (number <= n)
            {
                bool flag1 = (number % k == 0);
                bool flag2 = (number % l != 0);

                if (flag1 && flag2)
                {
                    count++;
                }
                number++;
            }
            return count;
        }
        Console.Write("count = ");
        Console.WriteLine(Check(39, 2, 5));

        }
    }
}
