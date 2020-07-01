using App.UI.Interfaces;
using App.UI.Menu;
using Autofac;
using System;
using System.IO;

namespace App.UI
{
    class Program
    {
        static void Main(string[] args)
        {

            var container = DependencyInjection.Initialize();
            var startup = container.Resolve<IStartup>();
            startup.InitializeDatabase();
            startup.Run();
            
        }
        
    }
}
