using Serilog;

namespace MapManager.Apis.Gdal
{
    public class Version
    {
        private static ILogger Log => Logger.Log.ForContext(typeof(Version));
        
        public static readonly string GdalReleaseName = OSGeo.GDAL.Gdal.VersionInfo("GDAL_RELEASE_NAME");
    }
}