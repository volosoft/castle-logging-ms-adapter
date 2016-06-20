using Microsoft.Extensions.Logging;

namespace Castle.LoggingFacility.MsLogging
{
    public static class CastleMsLoggerFactoryExtensions
    {
        public static ILoggerFactory AddCastleLogger(this ILoggerFactory factory, Core.Logging.ILoggerFactory castleLoggerFactory)
        {
            factory.AddProvider(new CastleMsLoggerProvider(castleLoggerFactory));
            return factory;
        }
    }
}
