using System.Collections.Concurrent;
using Microsoft.Extensions.Logging;

namespace Castle.LoggingFacility.MsLogging
{
    public class CastleMsLoggerProvider : ILoggerProvider
    {
        private readonly Core.Logging.ILoggerFactory _castleLoggerFactory;
        private readonly ConcurrentDictionary<string, CastleMsLoggerAdapter> _loggers;

        public CastleMsLoggerProvider(Core.Logging.ILoggerFactory castleLoggerFactory)
        {
            _castleLoggerFactory = castleLoggerFactory;
            _loggers = new ConcurrentDictionary<string, CastleMsLoggerAdapter>();
        }

        public ILogger CreateLogger(string categoryName)
        {
            return _loggers.GetOrAdd(
                categoryName,
                name => new CastleMsLoggerAdapter(_castleLoggerFactory.Create(name))
            );
        }

        public void Dispose()
        {

        }
    }
}