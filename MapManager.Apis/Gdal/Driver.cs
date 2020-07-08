using Serilog;
using System.Collections.Generic;

namespace MapManager.Apis.Gdal
{
    public class Driver
    {
        private static ILogger Log => Logger.Log.ForContext(typeof(Driver));

        public static IEnumerable<string> DriverNames { get; } = GetDriverNames();

        private static IEnumerable<string> GetDriverNames()
        {
            Log.Debug("Registering GDAL Drivers ...");
            OSGeo.GDAL.Gdal.AllRegister();
            Log.Debug("GDAL Drivers Registered.");
            for (var i = 0; i < OSGeo.GDAL.Gdal.GetDriverCount(); i++)
                yield return OSGeo.GDAL.Gdal.GetDriver(i).LongName;
        }
    }
}