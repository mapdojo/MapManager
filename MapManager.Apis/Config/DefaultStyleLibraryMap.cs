using Serilog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MapManager.Apis.Config
{
    public class DefaultStyleLibraryMap
    {
        private static ILogger Log => Logger.Log.ForContext(typeof(DefaultStyleLibraryMap));

        private const string STYLE_LIBRARY__MAP = "StyleLibrary.map";
        private static FileInfo _styleLibraryMap;

        public static FileInfo File
        {
            get
            {
                if (_styleLibraryMap != null && _styleLibraryMap.Exists)
                    return _styleLibraryMap;
                _styleLibraryMap = new FileInfo(Path.Combine(Default.Directory.FullName, STYLE_LIBRARY__MAP));
                return _styleLibraryMap;
            }
        }
    }
}
