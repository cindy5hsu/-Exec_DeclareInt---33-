using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 9;
            int b = 202;
            Console.WriteLine("now larger is {0} and smaller is {1}", a, b);
            if (b > a)
            {
                int temp = b;
                b = a;
                a = temp;
            }
            Console.WriteLine("After exchange, now larger is {0} and smaller is {1}", a, b);

        }
    }
}
