using System;

namespace HomeTasks_KisEA
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.Write("Введите первое число ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число ");
            int b = Convert.ToInt32(Console.ReadLine());
           
           if (a > b) 
           {
                Console.WriteLine("Наибольшее число " + a);
            
           }
            else
            {
                Console.WriteLine("Наибольшее число " + b);
            }
        }
    }
}
