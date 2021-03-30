using System;

namespace SIngle_Open
{
    public class MembershipService
    {
        public void CreateAccount(string userame, string password, string mail, IEmailService emailService)
        {
            Console.WriteLine("Account Created");
            
            emailService.SendEmail("Asif123@gmail.com", "Hello from OOP ", "Welcome to OOP");
        }
        public void RecoveryAccount(string userName, string mail, IEmailService emailService)
        {
            // same as above but diff message if you want;
            Console.WriteLine("Account Found");
 
            emailService.SendEmail("Asif123@gmail.com", "Hello from OOP ", "Welcome to OOP");
        }
    }
}
