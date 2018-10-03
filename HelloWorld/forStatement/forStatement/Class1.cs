using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forStatement
{
    public class Class1
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                string message = (i == 9) ? "The End" : "Just another number";
                Console.WriteLine(message);
            }
            Console.ReadLine();
        }
    }
}
