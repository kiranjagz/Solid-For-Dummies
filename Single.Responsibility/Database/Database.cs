using System;
using System.Collections.Generic;
using System.Text;

namespace Single.Responsibility.Database
{
    public class Database : IDatabase
    {
        public void Save()
        {
            Console.WriteLine($"Save the data, so you remember half of your data is gone!");
        }
    }
}
