using Serilog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MapManager.Apis.Config
{
    public class SharedDefaultMap
    {
        private static ILogger Log => Logger.Log.ForContext(typeof(SharedDefaultMap));

        private const string DEFAULT_MAP = "Default.map";
        private static FileInfo _defaultMap;

        public static FileInfo File
        {
            get
            {
                if (_defaultMap != null && _defaultMap.Exists)
                    return _defaultMap;
                _defaultMap = new FileInfo(Path.Combine(Shared.Directory.FullName, DEFAULT_MAP));
                return _defaultMap;
            }
        }
    }
}
