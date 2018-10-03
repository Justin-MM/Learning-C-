using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theIfStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Awesome Giveaways today! just choose a number");
            Console.WriteLine("Hi User, Will it be 1, 2 or 3?");
            string userValue = Console.ReadLine();

            if (userValue == "2")
            {
                Console.WriteLine("Yeessss! You won a Ford Ranger");
            }
            else if (userValue == "1" | userValue == "3")
            {
                Console.WriteLine("Sorry! You are out of luck today.");
            }
            else
            {
                Console.WriteLine("Sorry! That's invalid. Try again with a number between 1 and 3");
            }
            Console.ReadLine();
        }
    }
}
