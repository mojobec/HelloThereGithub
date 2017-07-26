using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        private const string Text = "Hello There";

        private static void Main()
        {
            PrintMenu();
        }

        private static void PrintMenu()
        {
            Console.WriteLine("1 - send");
            Console.WriteLine("2 - print");
            switch (Console.ReadLine())
            {
                case "1":
                    HandleSend();
                    break;
                case "2":
                    HandlePrint();
                    break;
                default:
                    Console.WriteLine("dont out smart us");
                    break;
            }
            Console.ReadLine();
        }

        private static void HandleSend()
        {
            Console.WriteLine("enter email or webapi");
            var sender = SenderFactory.Create(Console.ReadLine());
            sender.Send(Text, "send@to.com");
        }

        private static void HandlePrint()
        {
            Console.WriteLine("1 - print to screen");
            Console.WriteLine("2 - print to file (d:/text.txt)");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine(Text);
                    break;
                case "2":
                    File.WriteAllText(@"d:/test.txt", Text);
                    break;
                default:
                    Console.WriteLine("you should be a QA");
                    break;
            }
        }
    }
}
