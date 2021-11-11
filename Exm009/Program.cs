using System;

namespace Exm009
{
    class Program
    {
        static void Main(string[] args)
        {

            // Почувствуй себя джуном

            int RandomNum(int minValue, int maxValue)
            {
                int num = new Random().Next(minValue, maxValue);
                return num;
            }

            // 15. Дано число. Проверить кратно ли оно 7 и 23

            // bool Multiple(int num1)
            // {
            //     return (num1 % 7 == 0) & (num1 % 23 == 0);
            // }
            // int a = RandomNum(1, 1000);
            // Console.WriteLine(Multiple(a));


            // 16. Дано число обозначающее день недели. Выяснить является номер недели выходным днём

            // bool Weekend(int W)
            // {
            //     return W == 6 | W == 7;
            // }
            // int b = RandomNum(1, 8);
            // Console.WriteLine(Weekend(b));


            // 17. По двум заданным числам проверять является ли одно квадратом другого

            // bool CheckSquare2(int arg1, int arg2)
            // {
            //     return (arg1 == arg2 * arg2) & (arg2 == arg1 * arg1);
            // }
            // Console.WriteLine(CheckSquare2(1, 1));


            // 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

            // bool CheckTruth(bool x, bool y)
            // {
            //     return (!(x | y) == !x & !y);
            // }
            // Console.WriteLine(CheckTruth(true, false));
            
            // Console.WriteLine(CheckTruth(true, true));
            // Console.WriteLine(CheckTruth(false, true));
            // Console.WriteLine(CheckTruth(false, false));


            // 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, 
            // причем X ≠ 0 и Y ≠ 0

            // int FindQuarter (int x, int y)
            // {
            //     if (x > 0 & y > 0) return 1;
            //     if (x < 0 & y > 0) return 2;
            //     if (x < 0 & y < 0) return 3;
            //     else return 4; 
            // }
            //  Console.WriteLine(FindQuarter(-2,5));


            // 20. Ввести номер четверти, показать диапазоны для возможных координат

            //  void ShowQuarter (int q)
            // {
            //     if(q == 1) Console.WriteLine($"x > 0, y > 0");
            //     if(q == 2) Console.WriteLine($"x < 0, y > 0");
            //     if(q == 3) Console.WriteLine($"x < 0,  y < 0");
            //     if(q == 4) Console.WriteLine($"x > 0, y < 0");
            // }
            // int a = RandomNum(1, 5);
            //  ShowQuarter(a);

            // 21. Программа проверяет пятизначное число на палиндромом.

            // bool CheckPalindrome(int P)
            // {
            //     return ((P / 10000) % 10 == P % 10 & (P / 1000) % 10 == (P /10) % 10);
            // }
            // int f = RandomNum(10000, 100000); // int f = 75457; - для проверки числа
            // Console.WriteLine(CheckPalindrome(f));


            // 22. Найти расстояние между точками в пространстве 2D/3D

            // double FindDistance2D(int x1, int x2, int y1, int y2) // AB = √(xb - xa)2 + (yb - ya)2
            // {
            //     return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            // }
            // Console.WriteLine(FindDistance2D(2, 8, -2, 7));


            // double FindDistance3D(int x1, int x2, int y1, int y2, int z1, int z2) 
            // // AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2
            // {
            //     return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)+ Math.Pow((z2 - z1), 2));
            // }
            // Console.WriteLine(FindDistance3D(2, 8, -2, 7, 4, 10));

        }
    }
}
