
using System;

namespace WindowsFormsDiExample
{
    public class ReportBase
    {
        private readonly FakeSheet mSheet;
        //private static int _id = 0;
        protected ReportBase(FakeSheet sheet)
        {
            mSheet = sheet;
            //Console.WriteLine($@"ReportBase: {_id++}");
        }

        public virtual void LogReport()
        {
        }
    }
}