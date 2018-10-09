using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workingWithDataTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //show today's date
            DateTime date = DateTime.Now;
            Console.WriteLine(date.ToString());

            Console.WriteLine(date.ToLongDateString());
            Console.WriteLine(date.ToLongTimeString());

            //one week ago
            Console.WriteLine(date.AddDays(-7).ToLongDateString());

            //my birthday
            DateTime Age = new DateTime(1993, 08, 30);
            Console.WriteLine(Age.ToLongDateString());

            //my age
            Console.WriteLine(date.Subtract(Age).TotalDays / 365);

            TimeSpan myAge = DateTime.Now.Subtract(Age);
            Console.WriteLine(myAge.TotalDays.ToString());
            Console.ReadLine();
        }
    }
}
