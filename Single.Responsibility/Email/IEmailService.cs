using System;
using System.Collections.Generic;
using System.Text;

namespace Single.Responsibility.Email
{
    public interface IEmailService
    {
        void SendEmail(string emailAddress);
        bool ValidateEmail(string emailAddress);
    }
}
