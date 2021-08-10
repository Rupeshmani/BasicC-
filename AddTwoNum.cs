using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAddDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter Number 1:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sum is s=" + (a + b));
            Console.ReadLine();
        }
    }
}
