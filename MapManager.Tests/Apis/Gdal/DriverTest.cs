using Serilog;
using Serilog.Events;
using System.Linq;
using MapManager.Apis;
using Xunit;
using Xunit.Abstractions;

namespace MapManager.Tests.Apis.Gdal
{
    public class DriverTest
    {
        private ILogger Log { get; }
        public DriverTest(ITestOutputHelper output)
        {
            Log = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.TestOutput(output, LogEventLevel.Debug,
                    "{Timestamp:yyyy-MM-dd HH:mm:ss} [{Level}] [{SourceContext}] {Message}{NewLine}{Exception}")
                .Enrich.FromLogContext()
                .CreateLogger()
                .ForContext<DriverTest>();
            Logger.Init(Log);
        }

        [Fact]
        public void DriverNames()
        {
            Log.Debug("Getting Driver Names ...");
            var driverNames = MapManager.Apis.Gdal.Driver.DriverNames.ToArray();
            Log.Debug("Driver Names returned successfully.");
            Assert.Equal(210, driverNames.Length);
            Log.Debug("Driver Name Count: {DriverNameCount}", driverNames.Length);
            Assert.Equal(new[]
            {
                "Virtual Raster",
                "Derived datasets using VRT pixel functions",
                "GeoTIFF",
                "National Imagery Transmission Format",
                "Raster Product Format TOC format"
            }, driverNames.Take(5));
            Assert.Equal(new[]
            {
                "Generic Binary (.hdr Labelled)",
                "ENVI .hdr Labelled",
                "ESRI .hdr Labelled",
                "ISCE raster",
                "HTTP Fetching Wrapper"
            }, driverNames.Skip(205).Take(5));
        }
    }
}