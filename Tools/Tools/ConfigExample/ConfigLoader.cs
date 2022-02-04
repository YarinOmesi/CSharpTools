using Tools.Config;
using Tools.Logger.Factory;

namespace Tools.ConfigExample
{
    public class ConfigLoader<T>
    {
        private readonly ConfigurationLoader _configurationLoader;
        private readonly string _name;

        public ConfigLoader(string name, ILoggerFactory loggerFactory)
        {
            _name = name;
            _configurationLoader = new ConfigurationLoader(loggerFactory);
        }

        public T LoadConfig()
        {
            return _configurationLoader.Load<T>(_name);
        }
    }
}
