using System;

namespace LuyenTap5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input n");
            int number = Int16.Parse(Console.ReadLine());

            double multi = 1;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    multi = multi * i;
                }
            }
            Console.WriteLine("Result " + multi);
            Console.ReadLine();
        }

    }
}