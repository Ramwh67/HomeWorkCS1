using System;

namespace HomeTasks_KisEA
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.Write("Введите целое число ");
            int num = Convert.ToInt32(Console.ReadLine());
            int i = 2;
            if ( num >= i)
            {
                Console.Write("Все чётные числа от 1 до " + num + ": ");
                while ( i <= num )
                {
                    Console.Write( i + " ");
                    i = i + 2;
                }
            }
            else Console.WriteLine("Введите число побольше");
        }

    }
}
