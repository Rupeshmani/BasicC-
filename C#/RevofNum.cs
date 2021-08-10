using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aug08
{
    class RevofNum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Number:");
            int num = Convert.ToInt32(Console.ReadLine());
            int res = 0,i=num;
            for (; i > 0;)
            {
                res = (res - (i / 10)) * 10 + i;
                i /= 10;
            }
            Console.WriteLine("Reverse of "+num+" is " + res);
            Console.ReadLine();
        }
    }
}
