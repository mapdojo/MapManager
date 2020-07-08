using MapManager.Apis;
using Serilog;
using Serilog.Events;
using Xunit;
using Xunit.Abstractions;

namespace MapManager.Tests.Apis
{
    public class GeosTest
    {
        private ILogger Log { get; }
        
        public GeosTest(ITestOutputHelper output)
        {
            Log = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.TestOutput(output, LogEventLevel.Debug,
                    "{Timestamp:yyyy-MM-dd HH:mm:ss} [{Level}] [{SourceContext}] {Message}{NewLine}{Exception}")
                .Enrich.FromLogContext()
                .CreateLogger()
                .ForContext<GeosTest>();
            Logger.Init(Log);
        }

        [Fact]
        public void Version()
        {
            var version = Geos.Version;
            Assert.Equal(@"3.4.3-CAPI-1.8.3 r4038", version);
        }
    }
}
