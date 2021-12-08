using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuyenTap2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Nhập số tự nhiên n = ");
            int n = Int32.Parse(Console.ReadLine());
            int Tong = 0;          
                for (int i = 1; i <= n;i++) 
            {    
                
                Tong = Tong + i*i;
            }
            Console.WriteLine("Kết quả là Tổng = " + Tong);
            Console.ReadLine();
        }
    }
}