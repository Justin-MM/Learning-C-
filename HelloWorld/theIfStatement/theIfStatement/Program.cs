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
                Console.WriteLine("Yeessss! You won a Ford Ranger");
            else if (userValue == "1" | userValue == "3")
                Console.WriteLine("Sorry! You are out of luck today.");
            else
            {
                //4 is our magic number. We won't even reveal it has a price till its chosen.
                //sorry if the user enters anything else
                string message = (userValue == "4") ? "Hidden Treasures: You won a trip to Dubai!" : 
                    "Sorry! That's invalid. Try again with a number between 1 and 3";
                Console.WriteLine(message);
            }
            Console.ReadLine();
        }
    }
}
