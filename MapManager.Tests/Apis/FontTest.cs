using System.Linq;
using MapManager.Apis;
using Serilog;
using Serilog.Events;
using Xunit;
using Xunit.Abstractions;

namespace MapManager.Tests.Apis
{
    public class FontTest
    {
        private ILogger Log { get; }
        
        public FontTest(ITestOutputHelper output)
        {
            Log = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.TestOutput(output, LogEventLevel.Debug,
                    "{Timestamp:yyyy-MM-dd HH:mm:ss} [{Level}] [{SourceContext}] {Message}{NewLine}{Exception}")
                .Enrich.FromLogContext()
                .CreateLogger()
                .ForContext<FontTest>();
            Logger.Init(Log);
        }

        [Fact]
        public void NamesCount()
        {
            var nameCount = Font.Names.Count();
            Assert.Equal(225, nameCount);
        }
    }
}
