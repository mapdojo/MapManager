using Serilog;
using Serilog.Events;
using System.Linq;
using MapManager.Apis;
using Xunit;
using Xunit.Abstractions;
using System.IO;
using System;

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
            var driverNames = MapManager.Apis.Gdal.Driver.DriverNames.ToArray();
            Log.Debug("Driver Name Count: {DriverNameCount}", driverNames.Length);
            Assert.Equal(209, driverNames.Length);
            Assert.Equal(new[]
            {
                "Virtual Raster",
                "Derived datasets using VRT pixel functions",
                "GeoTIFF",
                "National Imagery Transmission Format",
                "Raster Product Format TOC format"
            }, driverNames.Take(5).ToArray());
            Assert.Equal(new[]
            {
                "Generic Binary (.hdr Labelled)",
                "ENVI .hdr Labelled",
                "ESRI .hdr Labelled",
                "ISCE raster",
                "HTTP Fetching Wrapper"
            }, driverNames.Skip(204).Take(5).ToArray());
        }

        [Fact]
        public void SetGdalDriverPathEnvironment()
        {
            var gdalPlugins = new DirectoryInfo(Path.Combine(Environment.CurrentDirectory, "gdalplugins"));
            MapManager.Apis.Gdal.Driver.SetGdalDriverPathEnvironment(gdalPlugins);
        }
    }
}