using System;
using Tools.Config;
using Tools.ConfigExample;
using Tools.Logger.Factory;

namespace Tools
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Logging 
            var loggerFactory = new Log4NetLoggerFactory("Log4Net.config");

            var mainLogger = loggerFactory.Create("Main");

            // Loading class from configuration
            var loader = new ConfigurationLoader(loggerFactory, "ConfigExample/App.config");
            var config = loader.Load<NetworkConfig>("networkConfig");
            mainLogger.Info($"Ip:[{config.Ip}, port:[{config.Port}]");

        }
    }
}
