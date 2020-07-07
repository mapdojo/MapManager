using System.Collections.Generic;

namespace MapManager.Apis.Gdal
{
    public static class Driver
    {
        public static IEnumerable<string> DriverNames { get; } = GetDriverNames();

        private static IEnumerable<string> GetDriverNames()
        {
            OSGeo.GDAL.Gdal.AllRegister();
            for (var i = 0; i < OSGeo.GDAL.Gdal.GetDriverCount(); i++)
                yield return OSGeo.GDAL.Gdal.GetDriver(i).LongName;
        }
    }
}