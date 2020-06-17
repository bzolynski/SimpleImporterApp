using System;
using System.Collections.Generic;
using System.Text;

namespace App.UI.Interfaces
{
    public interface IStartup
    {
        void InitializeDatabase();
        void Run();
    }
}
