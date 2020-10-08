using Dependency.Inversion.Database;
using Dependency.Inversion.Email;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dependency.Inversion
{
    public class ImplementationService
    {
        private readonly IEmailService _emailService;
        private readonly IDatabase _database;

        public ImplementationService(IEmailService emailService, IDatabase database)
        {
            _emailService = emailService;
            _database = database;
        }

        public bool DoWork(string emailAddress)
        {
            _emailService.ValidateEmail(emailAddress);
            _emailService.SendEmail(emailAddress);

            _database.Save();
            return true;
        }
    }
}
