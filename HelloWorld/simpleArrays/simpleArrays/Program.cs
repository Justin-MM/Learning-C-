using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 23, 24, 25, 17, 28, 38, 17, 19 };
            string[] names = new string[] {"James", "Kendi", "Lucy", "Robin"};

            //print all the numbers in the numbers array
            foreach (int number in numbers)
            {
                Console.Write("{0}, ", number);
            }

            //Reverse the second items in the names array
            char[] charArray = names[1].ToCharArray();
            Array.Reverse(charArray);
            foreach (char character in charArray)
            {
                Console.Write(character);
            }
            Console.ReadLine();
        }
    }
}
