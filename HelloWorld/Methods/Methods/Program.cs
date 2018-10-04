using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    //simply reverse users' input
    class Program
    {
        static void Main(string[] args)
        {
            string userNames = GetUserInput();
            string reversedNames = ReverseNames(userNames);
            //option 1
            Console.WriteLine("Option 1");
            DisplayResults(reversedNames);
            //option 2
            Console.WriteLine("Option 2");
            DisplayResults(userNames, reversedNames);
            Console.ReadLine();
        }

        private static string GetUserInput()
        {
            Console.WriteLine("Enter your first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name: ");
            string lastName = Console.ReadLine();
            return firstName + " " + lastName;
        }

        private static string ReverseNames(string namesToReverse)
        {
            char[] namesArray = namesToReverse.ToCharArray();
            Array.Reverse(namesArray);
            return string.Concat(namesArray);
        }

        private static void DisplayResults(string results)
        {
            Console.WriteLine(results);
        }

        //method overloading
        private static void DisplayResults(string usernames, string results)
        {
            Console.WriteLine("We reversed '{0}' to '{1}'", usernames, results);
        }
    }
}
