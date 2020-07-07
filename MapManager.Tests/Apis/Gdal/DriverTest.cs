using System.Linq;
using Xunit;

namespace MapManager.Tests.Apis.Gdal
{
    public class DriverTest
    {
        [Fact]
        public void DriverNames()
        {
            var driverNames = MapManager.Apis.Gdal.Driver.DriverNames.ToArray();
            Assert.Equal(210, driverNames.Length);
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