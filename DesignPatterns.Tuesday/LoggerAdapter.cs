using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Tuesday
{
    internal class LoggerAdapter : ILogger
    {
        private readonly LegacyLogger LegacyLogger;

        public LoggerAdapter(LegacyLogger legacyLogger)
        {
            LegacyLogger = legacyLogger;
        }

        public void Log(string message)
        {
            LegacyLogger.LogInfo(message);
            LegacyLogger.LogError(message);
        }
    }
}
