﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace ObserverDemo
{
    public class Logger
    {
        private static readonly NLog.Logger _logger = LogManager.GetCurrentClassLogger();

        public void AfterDoMore(object sender, Tuple<string, string> data)
        {
            Console.WriteLine("Writing down appended {0}.", data.Item2.ToUpper());
            _logger.Debug("Writing down appended {0}", data.Item2.ToUpper());
        }

        public void AfterDoSomethingWith(object sender, string data)
        {
            Console.WriteLine("Writing down {0}.", data.ToUpper());
            _logger.Info("Writing down {0}.", data.ToUpper());
        }
    }
}
