
using Serilog;
using Serilog.Events;

namespace MapManager.Apis
{
    public static class Logger
    {
        public static ILogger Log { get; private set; } = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo.Console(LogEventLevel.Debug,
                "{Timestamp:yyyy-MM-dd HH:mm:ss} [{Level}] [{SourceContext}] {Message}{NewLine}{Exception}")
            .Enrich.FromLogContext()
            .CreateLogger();

        public static void Init(ILogger log)
        {
            Log = log;
        }
    }
}