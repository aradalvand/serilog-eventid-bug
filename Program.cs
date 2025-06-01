using Logs;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

builder.Logging.ClearProviders();
builder.Services.AddSerilog(b => b
    .ReadFrom.Configuration(builder.Configuration)
    .WriteTo.Console(
        outputTemplate: "({Level:u4}) [{SourceContext:l}] <{Timestamp:HH:mm:ss.fff}>:{NewLine}{Message:lj}{NewLine}{Exception}---{NewLine}"
    )
);

var app = builder.Build();

app.Logger.LogNotEmitted("foo");
app.Logger.LogEmitted("foo");

app.Run();
