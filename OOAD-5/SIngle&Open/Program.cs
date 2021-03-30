using System;

namespace SIngle_Open
{
    class Program
    {
        static void Main(string[] args)
        {
           var member1 =  new MembershipService();
           member1.CreateAccount("Asif", "1234", "asif123@gmail.com", new EmailService());
           member1.RecoveryAccount("Asif","asif123@gmail.com", new AdvancedEmailService());
        }
    }
}
