using System.Text;
using OSGeo.MapServer;
using Serilog;

namespace MapManager.Apis
{
    public class MapServer
    {
        private static ILogger Log => Logger.Log.ForContext(typeof(MapServer));
        
        public static readonly string VersionSupport = mapscript.msGetVersion();

        public static readonly string Version = mapscript.MS_VERSION;

        public static string VersionInfo
        {
            get
            {
                var stringBuilder = new StringBuilder();
                stringBuilder.AppendLine($"MapServer version {Version}");
                stringBuilder.AppendLine(Gdal.Version.GdalReleaseName);
                stringBuilder.AppendLine($"proj {Proj.Version}");
                stringBuilder.AppendLine($"geos {Geos.Version}");
                stringBuilder.AppendLine($"zlib {ZLib.Version}");
                stringBuilder.AppendLine($"{Curl.Version}");
                return stringBuilder.ToString();
            }
        }
    }
}