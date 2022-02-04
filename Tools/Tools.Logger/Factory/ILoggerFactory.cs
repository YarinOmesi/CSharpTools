namespace Tools.Logger.Factory
{
    public interface ILoggerFactory
    {
        ILogger Create(string name);
    }
}