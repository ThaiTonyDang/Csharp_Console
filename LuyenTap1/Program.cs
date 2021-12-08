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
            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("Nhập số tự nhiên n = ");
            int n = Int16.Parse(Console.ReadLine());
            int Tong = 0;
            for(int bd=1;bd<=n;bd++)
            {
                Tong = Tong+bd;
            }
            Console.WriteLine("Kết quả là Tổng = "+Tong);
            Console.ReadLine();
        }
    }
}