using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace WindowsFormsDiExample
{
    static class Program
    {
        private static void ConfigureService(IServiceCollection services)
        {
            services.AddSingleton<Form1>()
                .AddSingleton<IReportFactory<string, MyReport>, MyReportFactory>()
                .AddSingleton<IConfigProvider, MyConfigProvider>();
        }
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var service = new ServiceCollection();
            ConfigureService(service);
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run( service.BuildServiceProvider().GetRequiredService<Form1>());
        }
    }
}