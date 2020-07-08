using System;
using System.IO;
using System.Linq;
using MapManager.Apis;
using MapManager.Apis.Gdal;
using Serilog;
using Serilog.Events;
using Xunit;
using Xunit.Abstractions;

namespace MapManager.Tests.Apis.Gdal
{
    public class DriverTest
    {
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

        private ILogger Log { get; }

        [Fact]
        public void DriverNames()
        {
            var driverNames = Driver.Names.ToArray();
            Log.Debug("Driver Name Count: {DriverNameCount}", driverNames.Length);
            Assert.Equal(Driver.GdalDriverPath == null ? 209 : 221, driverNames.Length);
            var firstFiveDrivers = driverNames.Take(5).ToArray();
            Assert.Equal(Driver.GdalDriverPath == null ? new[]
            {
                "Virtual Raster",
                "Derived datasets using VRT pixel functions",
                "GeoTIFF",
                "National Imagery Transmission Format",
                "Raster Product Format TOC format"
            } : new []
            {
                "Bathymetry Attributed Grid", 
                "Flexible Image Transport System", 
                "GMT NetCDF Grid Format", 
                "Hierarchical Data Format Release 4", 
                "HDF4 Dataset"
            }, firstFiveDrivers);
            var lastFiveDrivers = driverNames.Skip(driverNames.Length-5).Take(5).ToArray();
            Assert.Equal(new[]
            {
                "Generic Binary (.hdr Labelled)",
                "ENVI .hdr Labelled",
                "ESRI .hdr Labelled",
                "ISCE raster",
                "HTTP Fetching Wrapper"
            }, lastFiveDrivers);
        }

        [Fact]
        public void SetGdalDriverPathEnvironment()
        {
            var gdalPlugins = new DirectoryInfo(Path.Combine(Environment.CurrentDirectory, "gdalplugins"));
            Driver.GdalDriverPath = gdalPlugins;
        }
    }
}