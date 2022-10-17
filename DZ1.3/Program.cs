using System;

namespace HomeTasks_KisEA
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.Write("Введите число ");
            int num = Convert.ToInt32(Console.ReadLine());
            
            if ( num % 2 == 0 )
            {
                Console.WriteLine("Число является чётным");
            }
            else
            {
                Console.WriteLine("Число является нечётным");
            }
        }
    }
}