using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steam_Assistant
{
    class Program
    {
        static void Main(string[] args)
        {
            About about = new About();
            about.Info();

            Console.WriteLine("\n");
            about.Version = "1.0";
            about.showVersion();

            Console.ReadKey();
        }
    }
}
