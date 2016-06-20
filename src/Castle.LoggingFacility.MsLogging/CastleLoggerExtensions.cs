using System;
using Microsoft.Extensions.Logging;

namespace Castle.LoggingFacility.MsLogging
{
    /// <summary>
    /// Extensions for <see cref="ILogger"/>.
    /// </summary>
    public static class CastleLoggerExtensions
    {
        public static void Log(this Core.Logging.ILogger logger, LogLevel logLevel, string message)
        {
            switch (logLevel)
            {
                case LogLevel.Critical:
                    logger.Fatal(message);
                    break;
                case LogLevel.Error:
                    logger.Error(message);
                    break;
                case LogLevel.Warning:
                    logger.Warn(message);
                    break;
                case LogLevel.Information:
                    logger.Info(message);
                    break;
                case LogLevel.Debug:
                case LogLevel.Trace:
                    logger.Debug(message);
                    break;
                case LogLevel.None:
                    break;
                default:
                    throw new ArgumentException($"{nameof(logLevel)} value is not implemented: " + logLevel);
            }
        }

        public static void Log(this Core.Logging.ILogger logger, LogLevel logLevel, string message, Exception exception)
        {
            switch (logLevel)
            {
                case LogLevel.Critical:
                    logger.Fatal(message, exception);
                    break;
                case LogLevel.Error:
                    logger.Error(message, exception);
                    break;
                case LogLevel.Warning:
                    logger.Warn(message, exception);
                    break;
                case LogLevel.Information:
                    logger.Info(message, exception);
                    break;
                case LogLevel.Debug:
                case LogLevel.Trace:
                    logger.Debug(message, exception);
                    break;
                case LogLevel.None:
                    break;
                default:
                    throw new ArgumentException($"{nameof(logLevel)} value is not implemented: " + logLevel);
            }
        }

        public static void Log(this Core.Logging.ILogger logger, LogLevel logLevel, Func<string> messageFactory)
        {
            switch (logLevel)
            {
                case LogLevel.Critical:
                    logger.Fatal(messageFactory);
                    break;
                case LogLevel.Error:
                    logger.Error(messageFactory);
                    break;
                case LogLevel.Warning:
                    logger.Warn(messageFactory);
                    break;
                case LogLevel.Information:
                    logger.Info(messageFactory);
                    break;
                case LogLevel.Debug:
                case LogLevel.Trace:
                    logger.Debug(messageFactory);
                    break;
                case LogLevel.None:
                    break;
                default:
                    throw new ArgumentException($"{nameof(logLevel)} value is not implemented: " + logLevel);
            }
        }
    }
}