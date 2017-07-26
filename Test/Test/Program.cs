using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            const string text = "Hello There";

            Console.WriteLine("1 - print to screen");
            Console.WriteLine("2 - print to file (d:/text.txt)");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine(text);
                    break;
                case "2":
                    File.WriteAllText(@"d:/test.txt", text);
                    break;
                default:
                    Console.WriteLine("you should be a QA");
                break;
            }
            Console.ReadLine();
        }
    }
}
