using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemos
{
    class StrSort
    {
        static void Main(string [] args)
        {
            Console.WriteLine("Enter the strings:");
            string[] arr = new string[10];
            for (int i = 0; i < 10; i++)
                arr[i] = Console.ReadLine();
            Array.Sort(arr);
            Console.WriteLine("\nThe Sorted Array of Strings:");
            foreach (string i in arr)
                Console.WriteLine(i);
            Console.WriteLine("\nCount of vowels:");
            foreach (string i in arr)
            {
                int c = 0;
                foreach(char j in i)
                {
                    if (j == 'a' || j == 'A' || j == 'e' || j == 'E' || j == 'i' || j == 'I' || j == 'o' || j == 'O' || j == 'u' || j == 'U')
                        c++;
                }
                Console.WriteLine($"Number of Vowels in {i} are {c}");
            }
            Console.WriteLine("\nNames containing 'r' are:");
            foreach (string i in arr)
            {
        
                foreach (char j in i)
                {
                    if (j == 'r')
                        Console.WriteLine(i);
                }
  
            }
            Console.ReadLine();
        }
    }
}
