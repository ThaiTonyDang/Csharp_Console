using System;

namespace LuyenTap8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, -100, -600, 11, 4, 10, 5, 6, 7, 8 };
            int min = array[0];
            int PositionOfMin=0;

            for (int i = 0; i < array.Length; i++)
            {
                if ( min> array[i])
                {
                    PositionOfMin = i;
                }
            }

            Console.WriteLine(" Position of Min is " + PositionOfMin);
            Console.ReadLine();
        }
    }
}