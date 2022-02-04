using System.Configuration;
using System.Reflection;
using Tools.Logger;
using Tools.Logger.Factory;

namespace Tools.Config
{
    public class ConfigurationLoader
    {

        private readonly ILogger _logger;

        public ConfigurationLoader(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.Create(MethodBase.GetCurrentMethod()!.Name);
        }

        public T Load<T>(string section)
        {
            try
            {
                return (T) (dynamic) ConfigurationManager.GetSection(section);
            }
            catch (ConfigurationErrorsException e)
            {
                _logger.Error("Cannot Load Config File",e);
                return default;
            }
        }
    }
}
