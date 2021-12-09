using System;

namespace LuyenTap7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, -100, 11, 4, 10, 5, 6, 7, 8 };

            int max;
            max = array[0];

            for (int i = 0; i <= 10; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }

            Console.WriteLine(" Result of max is " + max);
            Console.ReadLine();
        }
    }
}