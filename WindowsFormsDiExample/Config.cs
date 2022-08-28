namespace WindowsFormsDiExample
{
    public class Config
    {
        public int Param1 { get; }
        public string Param2 { get; }

        public Config(int param1, string param2)
        {
            Param1 = param1;
            Param2 = param2;
        }
    }
}