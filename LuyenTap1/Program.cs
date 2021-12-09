using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuyenTap1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input n = ");
            int number = Int16.Parse(Console.ReadLine());

            int sum = 0;
            for(int i=1; i <= number; i++)
            {
                sum += i;
            }

            Console.WriteLine("Result = " + sum);
            Console.WriteLine("Big O is O(n)");
            Console.ReadLine();
        }
    }
}