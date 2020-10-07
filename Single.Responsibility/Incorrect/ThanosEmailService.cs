using System;
using System.Collections.Generic;
using System.Text;

namespace Single.Responsibility.Incorrect
{
    public class ThanosEmailService
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

        public void Save()
        {
            Console.WriteLine($"Save the data, so you remember half of your data is gone!");
        }

        private bool Snap()
        {
            Console.WriteLine($"Dread it. Run it. Destiny arrives all the same!");

            return true;
        }

        public bool DoWork(string emailAddress)
        {
            var hasSnapped = Snap();

            if (hasSnapped)
            {
                var isValid = ValidateEmail(emailAddress);

                if (isValid)
                {
                    SendEmail(emailAddress);
                    Save();
                    return true;
                }
            }

            return false;
        }
    }
}
