﻿using log4net.Core;

namespace Log4net.Appender.InfluxDBSyslog
{
    internal static class Log4netSyslogSeverityConvertor
    {
        internal static SyslogSeverity GetSyslogSeverity(Level level)
        {
            switch (level.Name)
            {
                case "FATAL":
                    return new SyslogSeverity() { Severity = "emerg", SeverityCode = 0 };

                case "ERROR":
                    return new SyslogSeverity() { Severity = "err", SeverityCode = 3 };

                case "WARN":
                    return new SyslogSeverity() { Severity = "warning", SeverityCode = 4 };

                case "INFO":
                    return new SyslogSeverity() { Severity = "info", SeverityCode = 4 };

                case "DEBUG":
                    return new SyslogSeverity() { Severity = "debug", SeverityCode = 6 };

                default:
                    return new SyslogSeverity() { Severity = "notice", SeverityCode = 7 };
            }
        }
    }
}