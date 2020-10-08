using System;
using System.Collections.Generic;
using System.Text;

namespace Dependency.Inversion.Database
{
    public interface IDatabase
    {
        void Save();
    }
}
