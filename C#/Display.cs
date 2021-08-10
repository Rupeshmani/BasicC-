using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aug08
{
    class Display
    {
        static void Main()
        {
            int n, Choice ;

        menu:
            Console.WriteLine("\n**Choice** \n1.Display cube \n2.Display if it is a Prime number\n3.Display Power\n4.Display factorial\n0.Exit \nEnter Choice");
            Choice = Convert.ToInt32(Console.ReadLine());
            if (Choice == 0)
                goto end;
            Console.Write("Enter the number n:");
            n = Convert.ToInt32(Console.ReadLine());
            switch (Choice)
            {
  
                case 1:
                    //Display the cube
                    Console.WriteLine($"Cube of number {n} is:" + (n*n*n));
                    goto menu;
                //Display if it is prime
                case 2:
                    int i, Cou = 0;
                    for (i = 2; i <= Math.Sqrt(n); i++)
                    {
                        if (n % i == 0)
                        {
                            Cou++;
                            break;
                        }
                    }
                    if (Cou == 0)
                    {
                        Console.WriteLine($"{n} is a Prime number:");
                    }
                    else
                    {
                        Console.WriteLine($"{n} is not Prime");
                    }
                    goto menu;
   
                //Power raised to
                case 3:
                    int exp;
                    int b = 1;
                    Console.Write("Enter how many times to raise power: ");
                    exp = Convert.ToInt32(Console.ReadLine());
                    while (exp != 0)
                    {
                        b = b * n;
                        --exp;
                    }
                    Console.Write(b);
                    goto menu;
           
                //factorial of number
                case 4:
                    int fact = 1, a;
                    for (a = 1; a <= n; a++)
                    {
                        fact = fact * a;
                    }
                    Console.WriteLine($"Factorial of {n} is {fact}" );
                    goto menu;
        
            }
        end:
            Console.WriteLine("BYE");
            Console.ReadLine();
        }
    }
}
