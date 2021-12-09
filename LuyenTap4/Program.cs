using System;

namespace LuyenTap4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input x = ");
            int number = Int16.Parse(Console.ReadLine());
            Console.Write("Input n");
            int number1 = Int16.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i <= number1; i++)
            {
                sum += Math.Pow(number, 2*i);
            }

            Console.WriteLine("Result = " + sum);
            Console.WriteLine("Big O is O(n)");
            Console.ReadLine();
        }
    }
}