﻿using System;
using System.IO;
using log4net;
using log4net.Config;

namespace Tools.Logger
{
    public class Log4NetLogger:ILogger
    {
        private readonly ILog _logger;

        public Log4NetLogger(string configFile,string name)
        {
            XmlConfigurator.Configure(new FileInfo(configFile));
            _logger = LogManager.GetLogger(name);
        }

        public void Debug(object log, Exception e = null)
        {
            _logger.Debug(log,e);
        }

        public void Info(object log, Exception e = null)
        {
            _logger.Info(log,e);
        }

        public void Warn(object log, Exception e = null)
        {
            _logger.Warn(log,e);
        }

        public void Error(object log, Exception e = null)
        {
            _logger.Error(log,e);
        }

        public void Fatal(object log, Exception e = null)
        {
            _logger.Fatal(log,e);
        }
    }
}
