using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aug08
{
    class Primes_in_range
    {
        static void Main(string[] args)
        {
            int a, b,i,j;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            for (i = a; i <= b; i++)
            {
                int cou = 0;
                for (j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        cou++;
                        break;
                    }
                }
                if (cou == 0)
                    Console.Write(i+" ");
            }
            Console.ReadLine();
        }
    }
}
