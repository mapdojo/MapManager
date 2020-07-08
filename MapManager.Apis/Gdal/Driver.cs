using System.Collections.Generic;
using System.IO;
using Serilog;

namespace MapManager.Apis.Gdal
{
    public class Driver
    {
        private const string GDAL_DRIVER_PATH = "GDAL_DRIVER_PATH";

        private static HashSet<string> names;
        private static ILogger Log => Logger.Log.ForContext(typeof(Driver));

        public static IEnumerable<string> Names
        {
            get
            {
                if (names != null && names.Count > 0) return names;

                names = GetDriverNames();
                return names;
            }
        }

        private static HashSet<string> GetDriverNames()
        {
            Log.Debug("Registering GDAL Drivers ...");
            OSGeo.GDAL.Gdal.AllRegister();
            var driverNames = new HashSet<string>();
            for (var i = 0; i < OSGeo.GDAL.Gdal.GetDriverCount(); i++)
                driverNames.Add(OSGeo.GDAL.Gdal.GetDriver(i).LongName);
            Log.Debug("{DriverLongNamesCount} GDAL Drivers Registered.", driverNames.Count);
            return driverNames;
        }

        private static DirectoryInfo gdalDirectoryPath;
        public static DirectoryInfo GdalDriverPath
        {
            set
            {
                if (SetGdalDriverPathEnvironment(value))
                {
                    gdalDirectoryPath = value;
                }
            }
            get => gdalDirectoryPath;
        }

        private static bool SetGdalDriverPathEnvironment(DirectoryInfo gdalPlugins)
        {
            if (gdalPlugins.Exists)
            {
                Log.Debug("Setting {GDAL_DRIVER_PATH} to {gdalPlugins} ...", GDAL_DRIVER_PATH, gdalPlugins);
                OSGeo.GDAL.Gdal.SetConfigOption(GDAL_DRIVER_PATH, gdalPlugins.FullName);
                Log.Debug("{GDAL_DRIVER_PATH} set to {gdalPlugins}", GDAL_DRIVER_PATH, gdalPlugins);
                return true;
            }
            Log.Warning("{GDAL_DRIVER_PATH} could not be set because {gdalPlugins} does not exist.",
                GDAL_DRIVER_PATH, gdalPlugins);
            return false;
        }

        public static void Register()
        {
            GetDriverNames();
        }
    }
}