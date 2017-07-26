using System.Net;
using System.Net.Mail;

namespace Test
{
    public class EmailSender : ISender
    {
        public void Send(string str, string sendTo)
        {
            var mail = new MailMessage
            {
                From = new MailAddress("your@mail.com"),
                Subject = "Test Mail",
                Body = str
            };
            mail.To.Add(sendTo);

            var smtpServer = new SmtpClient("smtp.mailServer.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("your@username", "password"),
                EnableSsl = true
            };

            smtpServer.Send(mail);
        }
    }
}