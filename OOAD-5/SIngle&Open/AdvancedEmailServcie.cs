using System;

namespace SIngle_Open
{
   public class AdvancedEmailService : IEmailService
    {
        public void SendEmail(string mail, string subject, string body)
        {
            Console.WriteLine($"Sending mail to {mail} , Subject : {subject}, { body }");
        }
    }
}
