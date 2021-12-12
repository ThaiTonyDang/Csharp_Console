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
            Console.Write("Enter the Vietnamese Word : ");
            Viet = Console.ReadLine();
            if (Eng != "" && Viet != "" && Eng.Length != 1 && Viet.Length != 1)
            {
                dict.Add(Eng, Viet);
            }
        } while (Eng != "" && Viet!= "" && Eng.Length != 1 && Viet.Length != 1);
            
            
            Console.WriteLine(" The firt Eng-Viet Dict : ");
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
                Console.WriteLine(" New Dictionary " + item.Key + "  " + item.Value);
            }
            
            Console.ReadLine();

}
    }
}