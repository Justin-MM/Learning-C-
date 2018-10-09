using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {

            //string literals
            int num1 = 2;
            int num2 = 3;
            string myString = String.Format("Wow! Today I have {0} C# assignments and {1} python assignments",
                num1, num2);
            Console.WriteLine(myString);
            myString = String.Format("Wow! Today I have {1} C# assignments and {0} python assignments",
                num1, num2);
            Console.WriteLine(myString);
            myString = String.Format("Wow! Today I have {1} C# assignments and {1} python assignments",
                num1, num2);
            Console.WriteLine(myString);

            //string.format - currency
            myString = String.Format("Hey, I need {0:C} to buy a classy shoe", 300.00);
            Console.WriteLine(myString);

            //string.format - Reading long Numbers
            myString = String.Format("I heard that Trump is worth {0:N} dollars. Is it true?", 2000000000.00);
            Console.WriteLine(myString);

            //string.format - Phone Numbers
            myString = String.Format("Hey,my old phone number is +{0:(###) ## #######}", 254735353158);
            Console.WriteLine(myString);

            //string.format - Percentage
            string newString = string.Format("I scored a {0:P} in calculus", .98);
            Console.WriteLine(newString);

            //capitalize
            Console.WriteLine(newString.ToUpper());

            //find and replace
            Console.WriteLine(newString.Replace("scored", "achieved"));

            //escape characters
            newString = string.Format("my cat nickname is \"meow\"");
            Console.WriteLine(newString);

            newString = @"   most of my programs are in my C:\ drive  ";
            Console.WriteLine(newString);

            //StringBuilder class for efficiency
            StringBuilder anotherString = new StringBuilder();
            anotherString.Append("I know Barack Obama! ");
            anotherString.Append("Wow! this is cool");
            Console.WriteLine(anotherString);

            //trimming leading and ending spaces
            newString.Trim();

            //length of a string
            int length = newString.Length;
            Console.WriteLine(length);

            //get a substring of a string
            newString = newString.Substring(7);
            Console.WriteLine(newString);

            //convert an int to a string
            Console.WriteLine("my number is {0}", num1.ToString());

            //delete a part of a string
            Console.WriteLine(newString.Remove(7,18));
            Console.ReadLine();
        }
    }
}
