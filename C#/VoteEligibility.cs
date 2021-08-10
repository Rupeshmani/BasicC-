using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power
{
    class VoteEligibility
    {
        static void Main(string[] args)
        {
            string name, title = "Mrs.", isn = "";
            int age;
            string gender;
            name = Console.ReadLine();
            gender = (Console.ReadLine());
            age = Convert.ToInt32(Console.ReadLine());
            if (gender == "M")
                title = "Mr.";
            if (age < 18)
                isn = "not";
            Console.WriteLine($"{title}{name} is {isn} eligible to vote");
        }
    }
}
