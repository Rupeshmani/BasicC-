using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power
{
    class Factorial
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int res = 0;
            while (num != 0)
            {
                res += num % 10;
                num /= 10;
            }
            Console.WriteLine($"Sum of Digits is {res}");
            Console.ReadLine();
        }
        
    }
}
