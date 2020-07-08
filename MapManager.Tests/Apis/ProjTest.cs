using MapManager.Apis;
using Serilog;
using Serilog.Events;
using Xunit;
using Xunit.Abstractions;

namespace MapManager.Tests.Apis
{
    public class ProjTest
    {
        private ILogger Log { get; }
        
        public ProjTest(ITestOutputHelper output)
        {
            Log = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.TestOutput(output, LogEventLevel.Debug,
                    "{Timestamp:yyyy-MM-dd HH:mm:ss} [{Level}] [{SourceContext}] {Message}{NewLine}{Exception}")
                .Enrich.FromLogContext()
                .CreateLogger()
                .ForContext<ProjTest>();
            Logger.Init(Log);
        }

        [Fact]
        public void Version()
        {
            var version = MapManager.Apis.Proj.Version;
            Assert.Equal(@"Rel. 4.8.0, 6 March 2012", version);
        }
    }
}
