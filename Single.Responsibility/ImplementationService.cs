using Single.Responsibility.Database;
using Single.Responsibility.Email;
using Single.Responsibility.Thanos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Single.Responsibility
{
    public class ImplementationService
    {
        private readonly IThanos _thanos;
        private readonly IEmailService _emailService;
        private readonly IDatabase _database;

        public ImplementationService(IThanos thanos, IEmailService emailService, IDatabase database)
        {
            _thanos = thanos;
            _emailService = emailService;
            _database = database;
        }

        public bool DoWork(string emailAddress)
        {
            var hasSnapped = _thanos.Snap();

            if (!hasSnapped)
                return false;

            _emailService.ValidateEmail(emailAddress);
            _emailService.SendEmail(emailAddress);

            _database.Save();
            return true;
        }
    }
}
