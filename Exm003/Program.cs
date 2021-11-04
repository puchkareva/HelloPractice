using System;

namespace Exm003
{
    class Program
    {
        static void Main(string[] args)
        {
            
       // Задача - Поиск максимума из 9

       int Max(int arg1, int arg2, int arg3)
       {
           int result = arg1;
           if(result < arg2) result = arg2;
           if(result < arg3) result = arg3;
           return result;
       }
       /*
        int a1 = 5;
        int a2 = 2;
        int a3 = 1;
        int b1 = 9;
        int b2 = 51;
        int b3 = 17;
        int c1 = 4;
        int c2 = 3;
        int c3 = 21;

        int max = Max(Max(a1, a2, a3), Max(b1, b2, b3), Max(c1, c2, c3));
        Console.WriteLine(max);

        

        // Задача - Поиск максимума из 9. Массив

        int[] array = {11, 211, 31, 41, 15, 61, 17, 18, 19};

        int result = Max(Max(array[0], array[1], array[2]), 
        Max(array[3], array[4], array[5]), Max(array[6], array[7], array[8]));
        Console.WriteLine(result);

        */

        //
    
        

        
       



        }
    }
}
