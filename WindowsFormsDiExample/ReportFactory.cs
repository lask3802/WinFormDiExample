namespace WindowsFormsDiExample
{
    public interface IReportFactory<T>
    {
        T Create();
    }
    
    public interface IReportFactory<TParam1, T>
    {
        T Create(TParam1 param1);
    }
    
    public interface IReportFactory<TParam1, TParam2, T>
    {
        T Create(TParam1 param1, TParam2 param2);
    }
}