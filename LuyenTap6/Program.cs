using System;

namespace LuyenTap6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Input n = ");
            int number = Int16.Parse(Console.ReadLine());

            int count = 0;
            for (int i  = 1; i <= number; i ++)
            {
                if (number % i == 0) 
                {
                    if (i % 2 == 0)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(" Result = " + count);
            Console.ReadLine();
        }
    }
}