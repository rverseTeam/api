// Copyright (c) 2022 rverse Contributors (https://rverse.club). Licensed under the Apache License, Version 2.0.
// See the LICENCE file in the repository root for full licence text.

using rverse.Contracts;
using rverse.Services.LoggingService;

namespace rverse.Extensions;

public static class ServiceExtensions
{
    public static void ConfigureCors(this IServiceCollection services) =>
        services.AddCors(options =>
        {
            options.AddPolicy("CorsPolicy", builder =>
                builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());
        });

    public static void ConfigureLoggerService(this IServiceCollection services) =>
        services.AddSingleton<ILoggerManager, LoggerManager>();
}
