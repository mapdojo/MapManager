using System.IO;
using Serilog;

namespace MapManager.Apis.Gdal
{
    public class Data
    {
        private const string GDAL_DATA = "GDAL_DATA";
        private static ILogger Log => Logger.Log.ForContext(typeof(Data));

        private static DirectoryInfo gdalDataDirectory;
        public static DirectoryInfo GdalDataDirectory
        {
            set
            {
                if (SetGdalDataEnvironment(value))
                {
                    gdalDataDirectory = value;
                }
            }
            get => gdalDataDirectory;
        }

        private static bool SetGdalDataEnvironment(DirectoryInfo gdalData)
        {
            if (gdalData.Exists)
            {
                Log.Debug("Setting {GDAL_DATA} to {gdalData} ...", GDAL_DATA, gdalData);
                OSGeo.GDAL.Gdal.SetConfigOption(GDAL_DATA, gdalData.FullName);
                Log.Debug("{GDAL_DATA} set to {gdalData}", GDAL_DATA, gdalData);
                return true;
            }
            Log.Warning("{GDAL_DATA} could not be set because {gdalData} does not exist.",
                GDAL_DATA, gdalData);
            return false;
        }
    }
}