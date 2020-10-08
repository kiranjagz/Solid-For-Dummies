using Dependency.Inversion.Database;
using Dependency.Inversion.Email;
using System;

namespace Dependency.Inversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // You do not need a Ioc framework, it will aid your cause, but is not required.
            IEmailService emailService = new EmailService();
            IDatabase database = new Database.Database();

            var implementedService = new ImplementationService(emailService, database);

            implementedService.DoWork("jeff@email.com");

            Console.Read();
        }
    }
}
