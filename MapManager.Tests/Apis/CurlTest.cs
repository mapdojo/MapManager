using MapManager.Apis;
using Serilog;
using Serilog.Events;
using Xunit;
using Xunit.Abstractions;

namespace MapManager.Tests.Apis
{
    public class CurlTest
    {
        private ILogger Log { get; }
        
        public CurlTest(ITestOutputHelper output)
        {
            Log = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.TestOutput(output, LogEventLevel.Debug,
                    "{Timestamp:yyyy-MM-dd HH:mm:ss} [{Level}] [{SourceContext}] {Message}{NewLine}{Exception}")
                .Enrich.FromLogContext()
                .CreateLogger()
                .ForContext<CurlTest>();
            Logger.Init(Log);
        }

        [Fact]
        public void Version()
        {
            var version = Curl.Version;
            Assert.Equal(@"libcurl/7.70.0-DEV OpenSSL/1.1.1g zlib/1.2.3", version);
        }
    }
}
