// Copyright (c) 2022 rverse Contributors (https://rverse.club). Licensed under the Apache License, Version 2.0.
// See the LICENCE file in the repository root for full licence text.

using NLog;
using rverse.Contracts;

namespace rverse.Services.LoggingService;

public class LoggerManager : ILoggerManager
{
    private static readonly ILogger s_logger = LogManager.GetCurrentClassLogger();
    public LoggerManager()
    {
    }

    public void LogDebug(string message) => s_logger.Debug(message);
    public void LogError(string message) => s_logger.Error(message);
    public void LogInfo(string message) => s_logger.Info(message);
    public void LogWarn(string message) => s_logger.Warn(message);

}
