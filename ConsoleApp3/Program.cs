using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //判斷 9， 202 個別是奇數或偶數
            Console.WriteLine("請輸入一個整數：");
            string s = Console.ReadLine();
            int x = int.Parse(s);
            if (x % 2 == 0)
            {
                Console.WriteLine("{0}是偶數", x);
            }
            else
            {
                Console.WriteLine("{0}是奇數", x);
            }
            Console.WriteLine();
        }
    }
}
