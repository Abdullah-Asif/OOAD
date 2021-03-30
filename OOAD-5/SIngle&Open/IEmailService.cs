using System;

namespace SIngle_Open
{
   public interface  IEmailService
    {
        void SendEmail(string mail, string subject, string body);
    }
}
