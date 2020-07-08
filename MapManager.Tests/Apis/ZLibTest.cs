using MapManager.Apis;
using Serilog;
using Serilog.Events;
using Xunit;
using Xunit.Abstractions;

namespace MapManager.Tests.Apis
{
    public class ZLibTest
    {
        private ILogger Log { get; }
        
        public ZLibTest(ITestOutputHelper output)
        {
            Log = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.TestOutput(output, LogEventLevel.Debug,
                    "{Timestamp:yyyy-MM-dd HH:mm:ss} [{Level}] [{SourceContext}] {Message}{NewLine}{Exception}")
                .Enrich.FromLogContext()
                .CreateLogger()
                .ForContext<ZLibTest>();
            Logger.Init(Log);
        }

        [Fact]
        public void Version()
        {
            var version = MapManager.Apis.ZLib.Version;
            Assert.Equal(@"1.2.3", version);
        }
    }
}
