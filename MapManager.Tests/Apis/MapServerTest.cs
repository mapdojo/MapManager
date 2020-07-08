using MapManager.Apis;
using Serilog;
using Serilog.Events;
using Xunit;
using Xunit.Abstractions;

namespace MapManager.Tests.Apis
{
    public class MapServerTest
    {
        private ILogger Log { get; }
        
        public MapServerTest(ITestOutputHelper output)
        {
            Log = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.TestOutput(output, LogEventLevel.Debug,
                    "{Timestamp:yyyy-MM-dd HH:mm:ss} [{Level}] [{SourceContext}] {Message}{NewLine}{Exception}")
                .Enrich.FromLogContext()
                .CreateLogger()
                .ForContext<MapServerTest>();
            Logger.Init(Log);
        }

        [Fact]
        public void VersionInfo()
        {
            var versionInfo = MapManager.Apis.MapServer.VersionInfo;
            Log.Debug("VersionInfo: {VersionInfo}", versionInfo);
            Assert.Equal(@"MapServer version 7.4.3
GDAL 3.0.4, released 2020/01/28
proj Rel. 4.8.0, 6 March 2012
geos 3.4.3-CAPI-1.8.3 r4038
zlib 1.2.3
libcurl/7.70.0-DEV OpenSSL/1.1.1g zlib/1.2.3
", versionInfo);
        }
        
        [Fact]
        public void VersionSupport()
        {
            var versionSupport = MapManager.Apis.MapServer.VersionSupport;
            Log.Debug("VersionString: {VersionString}", versionSupport);
            Assert.Equal(
                @"MapServer version 7.4.3 OUTPUT=PNG OUTPUT=JPEG OUTPUT=KML SUPPORTS=PROJ SUPPORTS=AGG SUPPORTS=FREETYPE SUPPORTS=CAIRO SUPPORTS=SVG_SYMBOLS SUPPORTS=SVGCAIRO SUPPORTS=ICONV SUPPORTS=FRIBIDI SUPPORTS=WMS_SERVER SUPPORTS=WMS_CLIENT SUPPORTS=WFS_SERVER SUPPORTS=WFS_CLIENT SUPPORTS=WCS_SERVER SUPPORTS=SOS_SERVER SUPPORTS=FASTCGI SUPPORTS=THREADS SUPPORTS=GEOS SUPPORTS=PBF INPUT=JPEG INPUT=POSTGIS INPUT=OGR INPUT=GDAL INPUT=SHAPEFILE",
                versionSupport);
        }
        
        [Fact]
        public void VersionMapServer()
        {
            var version = MapManager.Apis.MapServer.Version;
            Log.Debug("VersionMapServer: {VersionMapServer}", version);
            Assert.Equal(@"7.4.3", version);
        }
    }
}
