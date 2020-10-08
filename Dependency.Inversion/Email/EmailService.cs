using System;
using System.Collections.Generic;
using System.Text;

namespace Dependency.Inversion.Email
{
    public class EmailService : IEmailService
    {
        public void SendEmail(string emailAddress)
        {
            Console.WriteLine($"Alerting {emailAddress} that half the universe is gone!");
        }

        public bool ValidateEmail(string emailAddress)
        {
            Console.WriteLine($"Validating {emailAddress} email address!");

            return true;
        }
    }
}
