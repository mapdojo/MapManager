using System.Collections.Generic;

namespace MapManager.Apis.Ogr
{
    public static class Driver
    {
        public static IEnumerable<string> DriverNames { get; } = GetDriverNames();

        private static IEnumerable<string> GetDriverNames()
        {
            OSGeo.OGR.Ogr.RegisterAll();
            for (var i = 0; i < OSGeo.OGR.Ogr.GetDriverCount(); i++) yield return OSGeo.OGR.Ogr.GetDriver(i).name;
        }
    }
}