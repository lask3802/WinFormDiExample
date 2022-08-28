using System;
using Microsoft.Extensions.DependencyInjection;

namespace WindowsFormsDiExample
{
    //Factory pattern as composition root
    public class MyReportFactory : IReportFactory<string, MyReport>
    {
        private readonly IServiceProvider mServiceProvider;

        public MyReportFactory(IServiceProvider serviceProvider)
        {
            mServiceProvider = serviceProvider;
            Console.WriteLine(@"[MyReportFactory] constructor");
        }

        public MyReport Create(string param1)
        {
            //Create scope if needed
            //using (var scope = mServiceProvider.CreateScope())
            {
                var serviceProvider = mServiceProvider;
                var sheet = ActivatorUtilities.CreateInstance<FakeSheet>(serviceProvider, param1);
                return ActivatorUtilities.CreateInstance<MyReport>(serviceProvider, sheet);
            }
        }
    }
}