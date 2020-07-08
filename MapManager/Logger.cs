using Serilog;

namespace MapManager
{
    public static class Logger
    {
        public static ILogger Log { get; private set; } = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console()
                .CreateLogger();

        public static void Init(ILogger log)
        {
            Log = log;
        }
    }
}