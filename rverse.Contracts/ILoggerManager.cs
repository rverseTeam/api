// Copyright (c) 2022 rverse Contributors (https://rverse.club). Licensed under the Apache License, Version 2.0.
// See the LICENCE file in the repository root for full licence text.

namespace rverse.Contracts;

public interface ILoggerManager
{
    void LogInfo(string message);
    void LogWarn(string message);
    void LogDebug(string message);
    void LogError(string message);
}
