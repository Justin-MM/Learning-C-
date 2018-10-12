using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace working_with_dot_net_assemblies
{
    class Program
    {
        static void Main(string[] args)
        {
            //writing to a file
            string text = "Wow! my kids love Nickelodeon";

            // you might want to change the filepath for it to work
            File.WriteAllText(@"C:\Users\Justin Macharia\Desktop\jimjam.txt", text);

            WebClient client = new WebClient();
            text = client.DownloadString("http://www.google.com");

            // you might want to change the filepath for it to work
            File.AppendAllText(@"C:\Users\Justin Macharia\Desktop\jimjam.txt", text);
            Console.ReadLine();
        }
    }
}
