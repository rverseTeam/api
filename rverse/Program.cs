// Copyright (c) 2022 rverse Contributors (https://rverse.club). Licensed under the Apache License, Version 2.0.
// See the LICENCE file in the repository root for full licence text.

using NLog;
using rverse.Extensions;

var builder = WebApplication.CreateBuilder(args);

LogManager.LoadConfiguration(string.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));

builder.Services.ConfigureCors();
builder.Services.ConfigureLoggerService();

builder.Services.AddControllers()
    .AddApplicationPart(typeof(rverse.Presentation.AssemblyReference).Assembly);

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
