using System;
using System.Text;
using OSGeo.MapServer;
using Serilog;

namespace MapManager.Apis
{
    public class MapServer
    {
        public static readonly string VersionSupport = mapscript.msGetVersion();

        public static readonly string Version = mapscript.MS_VERSION;
        private static ILogger Log => Logger.Log.ForContext(typeof(MapServer));

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

        private const string MS_MAX_OPEN_FILES = "MS_MAX_OPEN_FILES";

        public static int? MaxOpenFiles { 
            get
            {
                Log.Debug("Getting {MS_MAX_OPEN_FILES} ...", MS_MAX_OPEN_FILES);
                var envMaxOpenFiles = Environment.GetEnvironmentVariable(MS_MAX_OPEN_FILES, EnvironmentVariableTarget.Process);
                if (envMaxOpenFiles == null)
                {
                    Log.Warning("{MS_MAX_OPEN_FILES} is NULL.", MS_MAX_OPEN_FILES);
                    return null;
                }
                if (int.TryParse(envMaxOpenFiles, out var maxOpenFiles))
                {
                    Log.Debug("{MS_MAX_OPEN_FILES} is {maxOpenFiles}.", MS_MAX_OPEN_FILES, maxOpenFiles);
                    return maxOpenFiles;
                }
                Log.Warning("{MS_MAX_OPEN_FILES} has the value {} which is not a valid integer.", MS_MAX_OPEN_FILES, envMaxOpenFiles);
                return null;
            }
            set
            {
                Log.Debug("Setting {MS_MAX_OPEN_FILES} to {value} ...", MS_MAX_OPEN_FILES, value);
                Environment.SetEnvironmentVariable(MS_MAX_OPEN_FILES, $"{value}", EnvironmentVariableTarget.Process);
                Log.Debug("{MS_MAX_OPEN_FILES} set to {value}.", MS_MAX_OPEN_FILES, value);
            }
        }

        private const string MS_USE_GLOBAL_FT_CACHE = "MS_USE_GLOBAL_FT_CACHE";
        public static bool? UseGlobalFontCache
        {
            get
            {
                Log.Debug("Getting {MS_USE_GLOBAL_FT_CACHE} ...", MS_USE_GLOBAL_FT_CACHE);
                var envUseGlobalFontCache = Environment.GetEnvironmentVariable(MS_USE_GLOBAL_FT_CACHE, EnvironmentVariableTarget.Process);
                if (envUseGlobalFontCache == null)
                {
                    Log.Warning("{MS_USE_GLOBAL_FT_CACHE} is NULL.", MS_USE_GLOBAL_FT_CACHE);
                    return null;
                }
                
                if (int.TryParse(envUseGlobalFontCache, out var useGlobalFontCache))
                {
                    Log.Debug("{MS_USE_GLOBAL_FT_CACHE} is {useGlobalFontCache}.", MS_USE_GLOBAL_FT_CACHE, useGlobalFontCache);
                    return Convert.ToBoolean(useGlobalFontCache);
                }
                Log.Warning("{MS_USE_GLOBAL_FT_CACHE} has the value {envUseGlobalFontCache} which is not a valid boolean.", MS_USE_GLOBAL_FT_CACHE, envUseGlobalFontCache);
                return null;
            }
            set
            {
                var useGlobalFontCache = Convert.ToInt32(value);
                Log.Debug("Setting {MS_USE_GLOBAL_FT_CACHE} to {value} ...", MS_USE_GLOBAL_FT_CACHE, useGlobalFontCache);
                Environment.SetEnvironmentVariable(MS_USE_GLOBAL_FT_CACHE, $"{useGlobalFontCache}", EnvironmentVariableTarget.Process);
                Log.Debug("{MS_USE_GLOBAL_FT_CACHE} set to {value}.", MS_USE_GLOBAL_FT_CACHE, useGlobalFontCache);
            }
        }
    }
}