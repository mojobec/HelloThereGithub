using System;

namespace Test
{
    internal class SenderFactory
    {
        public static ISender Create(string arg)
        {
            switch (arg)
            {
                case "email":
                    return new EmailSender();
                case "webapi":
                    return new WebApiSender();
                default:
                    throw new ArgumentException("missing arg");
            }
        }
    }
}