using System;

namespace WindowsFormsDiExample
{
    public class MyConfigProvider: IConfigProvider
    {
        private static int _Id = 0;

        public MyConfigProvider()
        {
            _Id++;
        }
        
        public Config GetConfig()
        {
            Console.WriteLine($@"MyConfigProvider Id: {_Id}");
            return new Config(_Id, "hello world");
        }
    }
}