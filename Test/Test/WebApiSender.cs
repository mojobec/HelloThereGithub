using System;

namespace Test
{
    public class WebApiSender : ISender
    {
        public void Send(string str, string sendTo)
        {
            Console.WriteLine("sending to webApi");
        }
    }
}