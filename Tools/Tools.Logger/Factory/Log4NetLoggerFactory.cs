namespace Tools.Logger.Factory
{
    public class Log4NetLoggerFactory : ILoggerFactory
    {

        private readonly string _configFile;

        public Log4NetLoggerFactory(string configFile)
        {
            _configFile = configFile;
        }

        public ILogger Create(string name)
        {
            return new Log4NetLogger(_configFile,name);
        }
    }
}
