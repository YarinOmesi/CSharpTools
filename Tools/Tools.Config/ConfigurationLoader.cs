using System;
using System.Configuration;
using System.Reflection;
using Microsoft.Extensions.Configuration;
using Tools.Logger;
using Tools.Logger.Factory;

namespace Tools.Config
{
    public class ConfigurationLoader
    {
        private readonly ILogger _logger;
        private readonly IConfigurationRoot _configurationRoot;

        public ConfigurationLoader(ILoggerFactory loggerFactory, IConfigurationRoot configurationRoot)
        {
            _configurationRoot = configurationRoot;
            _logger = loggerFactory.Create(MethodBase.GetCurrentMethod()!.Name);
        }

        public ConfigurationLoader(ILoggerFactory loggerFactory, string xmlConfigPath)
        {
            _logger = loggerFactory.Create(MethodBase.GetCurrentMethod()!.Name);
            _configurationRoot = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddXmlFile(xmlConfigPath)
                .Build();
        }

        public T Load<T>(string section)
        {
            try
            {
                var configSection = _configurationRoot.GetSection(section);

                return configSection.Get<T>();
            }
            catch (ConfigurationErrorsException e)
            {
                _logger.Error("Cannot Load Config File", e);
                return default;
            }
        }
    }
}
