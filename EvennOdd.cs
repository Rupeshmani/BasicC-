using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power
{
    class Program1
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int b = 1;
            string res = "";
            if (Convert.ToBoolean(num & b))
                res = "Odd";
            else
                res = "Even";
            Console.WriteLine($"{num} is {res}");
            Console.ReadLine();
        }
    }
}
