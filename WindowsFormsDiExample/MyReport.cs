using System;

namespace WindowsFormsDiExample
{
    public class MyReport: ReportBase, IDisposable
    {
        private readonly IConfigProvider mConfigProvider;
        private static int _id = 0;
        public MyReport(FakeSheet sheet, IConfigProvider configProvider) : base(sheet)
        {
            mConfigProvider = configProvider;
            Console.WriteLine($@"MyReport: {++_id}");
        }

        public override void LogReport()
        {
            var config = mConfigProvider.GetConfig();
            Console.WriteLine($@"Config param1: {config.Param1}, param2: {config.Param2}");
            Console.WriteLine($@"LogReport: {_id}");
        }

        public void Dispose()
        {
            Console.WriteLine($@"Dispose MyReport: {_id}");
        }
    }
}