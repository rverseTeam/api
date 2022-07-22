// Copyright (c) 2022 rverse Contributors (https://rverse.club). Licensed under the Apache License, Version 2.0.
// See the LICENCE file in the repository root for full licence text.

using NLog;
using rverse.Contracts;

namespace rverse.Services.LoggingService;

public class LoggerManager : ILoggerManager
{
    private static ILogger logger = LogManager.GetCurrentClassLogger();
    public LoggerManager()
    {
    }

    public void LogDebug(string message) => logger.Debug(message);
    public void LogError(string message) => logger.Error(message);
    public void LogInfo(string message) => logger.Info(message);
    public void LogWarn(string message) => logger.Warn(message);

}
