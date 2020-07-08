using System;
using System.IO;
using System.Linq;
using MapManager.Apis;
using MapManager.Apis.Gdal;
using Serilog;
using Serilog.Events;
using Xunit;
using Xunit.Abstractions;

namespace MapManager.Tests.Apis.Ogr
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
            //var gdalPlugins = new DirectoryInfo(Path.Combine(Environment.CurrentDirectory, "gdalplugins"));
            //Driver.GdalDriverPath = gdalPlugins;
            var driverNames = MapManager.Apis.Ogr.Driver.Names.ToArray();
            Log.Debug("DriverNameCount: {DriveNameCount}", driverNames.Length);
            Assert.Equal(Driver.GdalDriverPath == null ? 84 : 86, driverNames.Length);
            var firstFiveDrivers = driverNames.Take(5).ToArray();
            Assert.Equal(Driver.GdalDriverPath == null ? new[]
            {
                "PCIDSK", "PDS4", "JP2OpenJPEG", "PDF", "MBTiles"
            } : new []
            {
                "netCDF", "AmigoCloud", "MSSQLSpatial", "PCIDSK", "PDS4"
            }, firstFiveDrivers);
            var lastFiveDrivers = driverNames.Skip(driverNames.Length-5).Take(5).ToArray();
            Assert.Equal(new[]
            {
                "TIGER", "AVCBin", "AVCE00", "NGW", "HTTP"
            }, lastFiveDrivers);
        }
    }
}
