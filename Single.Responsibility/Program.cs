using Single.Responsibility.Email;
using Single.Responsibility.Incorrect;
using System;

namespace Single.Responsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            // BAD
            // Serarate responsibilities
            var incorrect = new ThanosEmailService();
            incorrect.DoWork("bad");

            Console.WriteLine("=====================================================================================");

            // BETTER
            // Code has been broken down into its own units
            var implementedService = new ImplementationService(new Thanos.Thanos(), new EmailService(), new Database.Database());

            var result = implementedService.DoWork("better");

            Console.Read();
        }
    }
}
