using Xunit;

namespace MapManager.Tests.Apis.MapServer
{
    public class VersionTest
    {
        [Fact]
        public void VersionInfo()
        {
            var versionInfo = MapManager.Apis.MapServer.Version.VersionInfo;
            Assert.Equal(@"MapServer version 7.4.3
GDAL 3.0.4, released 2020/01/28
proj Rel. 4.8.0, 6 March 2012
geos 3.4.3-CAPI-1.8.3 r4038
zlib 1.2.3
libcurl/7.70.0-DEV OpenSSL/1.1.1g zlib/1.2.3
", versionInfo);
        }
        
        [Fact]
        public void VersionString()
        {
            var versionString = MapManager.Apis.MapServer.Version.VersionString;
            Assert.Equal(
                @"MapServer version 7.4.3 OUTPUT=PNG OUTPUT=JPEG OUTPUT=KML SUPPORTS=PROJ SUPPORTS=AGG SUPPORTS=FREETYPE SUPPORTS=CAIRO SUPPORTS=SVG_SYMBOLS SUPPORTS=SVGCAIRO SUPPORTS=ICONV SUPPORTS=FRIBIDI SUPPORTS=WMS_SERVER SUPPORTS=WMS_CLIENT SUPPORTS=WFS_SERVER SUPPORTS=WFS_CLIENT SUPPORTS=WCS_SERVER SUPPORTS=SOS_SERVER SUPPORTS=FASTCGI SUPPORTS=THREADS SUPPORTS=GEOS SUPPORTS=PBF INPUT=JPEG INPUT=POSTGIS INPUT=OGR INPUT=GDAL INPUT=SHAPEFILE",
                versionString);
        }
    }
}
