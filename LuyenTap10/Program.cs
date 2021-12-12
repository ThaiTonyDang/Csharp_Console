using System;
using System.Collections.Generic;
using System.Text;

namespace LuyenTap10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nhập Từ Điển Tiếng Anh Và Tìm Kiếm.
            Dictionary<string, string> dict = new Dictionary<string, string>();
            Console.WriteLine("Input Eng-Viet Dictionary's Vocabulary ");
            string Eng = "";
            string Viet= "";

            do
            {
                Console.Write("Enter the English Word : ");
                 Eng = Console.ReadLine();
                Console.Write("Enter the Vietnamese Word : ");
                 Viet = Console.ReadLine();
                if (Eng != "" && Viet != "" && Eng.Length != 1 && Viet.Length != 1)
                {
                    dict.Add(Eng, Viet);
                }
            } while (Eng != "" && Viet!= "" && Eng.Length != 1 && Viet.Length != 1);

            Console.WriteLine(" Xuat ra Eng-Viet Dict : ");

            foreach (KeyValuePair<string, string> item in dict)
            {
                    Console.WriteLine("ENGLISH: " + item.Key + "  VIETNAMESE: " + item.Value);
            }

            string input = "";
            Console.WriteLine("Enter the English word you want to find");
            input = Console.ReadLine();
            bool Check = dict.ContainsKey(input);

            if (Check == false)
            {
                Console.WriteLine(" Find Not Found ");
            }
            else
            {
                Console.WriteLine(dict[input]);
            }

            Console.ReadLine();
        }
    }
}