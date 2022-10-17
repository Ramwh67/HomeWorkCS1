using System;

namespace HomeTasks_KisEA
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.Write("Введите первое число ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите третье число ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 >= num2 && num1 >= num3)
            {
                Console.WriteLine("Наибольшее число " + num1);
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                Console.WriteLine("Наибольшее число " + num2);
            }
            else 
            {
                Console.WriteLine("Наибольшее число " + num3);
            }
        }
    }
}