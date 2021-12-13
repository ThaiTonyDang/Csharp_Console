using System;
using System.Collections.Generic;

namespace LuyenTap11
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            Console.WriteLine("Input Eng-Viet Dictionary's Vocabulary ");
            string Eng = "";
            string Viet = "";
 
            do
            {
                Console.Write("Enter the English Word : ");
                Eng = Console.ReadLine();
                if (!dict.ContainsKey(Eng))
                {
                        Console.Write("Enter the Vietnamese Word : ");
                        Viet = Console.ReadLine();
                        if (Eng != "" && Viet != "" && Eng.Length != 1 && Viet.Length != 1)
                        {
                            dict.Add(Eng, Viet);
                        }
                   
                }
                else
                {
                    Console.WriteLine("ReInput English Word ");
                }
            } while (Eng != "" && Viet != "" && Eng.Length != 1 && Viet.Length != 1);
            
            List<string> list = new List<string>();
            foreach (KeyValuePair<string, string> item in dict)
            {
                if (item.Key.Contains("A") || item.Key.Contains("a"))
                {
                    list.Add(item.Key); 
                }       
            }
            foreach(string keyDelete in list)
            {
                dict.Remove(keyDelete);
                Console.WriteLine("{0} has been deleted ",keyDelete);
            }

            foreach (KeyValuePair<string,string> item in dict)
            {
                Console.WriteLine(" New Dictionary " + "English Word" + item.Key + " VietNamese Word " + item.Value);
            }
            
            Console.ReadLine();
        }
    }
}