using Serilog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MapManager.Apis.Config
{
    public class SharedFontList
    {
        private static ILogger Log => Logger.Log.ForContext(typeof(SharedFontList));

        private const string FONT_LIST = "font.list";
        private static FileInfo _fontList;

        public static FileInfo File
        {
            get
            {
                if (_fontList != null && _fontList.Exists)
                    return _fontList;
                _fontList = new FileInfo(Path.Combine(Shared.Directory.FullName, FONT_LIST));
                return _fontList;
            }
        }
    }
}
