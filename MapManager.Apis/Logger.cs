
using Serilog;

namespace MapManager.Apis
{
    public static class Logger
    {
        public static ILogger Log { get; private set; } = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo.Console()
            .Enrich.FromLogContext()
            .CreateLogger();

        public static void Init(ILogger log)
        {
            Log = log;
        }
    }
}