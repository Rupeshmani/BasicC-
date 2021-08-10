using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemos
{
    class IntArr
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            for (int i = 0; i < 5; i++)
                arr[i] = Convert.ToInt32(Console.ReadLine());
            int max = arr[0];
            foreach(int i in arr)
            {
                if (max < i)
                    max = i;
            }
            Console.WriteLine("Largest Number in the Array is "+max);
            Console.ReadLine();
        }
    }
}
