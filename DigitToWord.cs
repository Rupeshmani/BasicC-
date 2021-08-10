using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Power{
    class DigitToWord {
        static void Main(string[] args)
        {
            int num;
            string res = "";
            num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 0:
                    res = "Zero";
                    break;
                case 1:
                    res = "One";
                    break;
                case 2:
                    res = "Two";
                    break;
                case 3:
                    res = "Three";
                    break;
                case 4:
                    res = "Four";
                    break;
                case 5:
                    res = "Five";
                    break;
                case 6:
                    res = "Six";
                    break;
                case 7:
                    res = "Seven";
                    break;
                case 8:
                    res = "Eight";
                    break;
                case 9:
                    res = "Nine";
                    break;
                default:
                    res = "not in between 0-9";
                    break;
            }
            Console.WriteLine($"Your Number is {res}");
            Console.ReadLine();
        }
}
}