using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataTypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int x = 5;
            int y = x + 2;
            Console.WriteLine(y);
            */

            Console.WriteLine("Hey, What's your first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("Now tell me your Last name:-)");
            string lastName = Console.ReadLine();

            Console.WriteLine("Hi " + firstName + " " + lastName + ", I love You!");
            Console.ReadLine();

        }
    }
}
