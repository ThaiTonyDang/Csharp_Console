using System;
using System.Collections.Generic;

namespace LuyenTap9
{
    class Program
    {
        static void Main(string[] args)
        {
            // nhap xuat mang 
            // nhan esc exit
            string input = "";
            List<int> list = new List<int>();
            Console.WriteLine("Nhap bat ki cac phan tu list : ");
            do
            {
                input = Console.ReadLine();
                int number;
                bool isParse = Int32.TryParse(input, out number);
                if (isParse)
                {
                    list.Add(number);
                }
            }
            while (input != "N" && input != "n");
            Console.WriteLine("Xuat cac phan tu list: ");
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.ReadLine();
        }
    }
}