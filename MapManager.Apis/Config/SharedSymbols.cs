using Serilog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MapManager.Apis.Config
{
    public class SharedSymbols
    {
        private static ILogger Log => Logger.Log.ForContext(typeof(SharedSymbols));

        private const string SYMBOLS = "symbols.sym";
        private static FileInfo _symbols;

        public static FileInfo File
        {
            get
            {
                if (_symbols != null && _symbols.Exists)
                    return _symbols;
                _symbols = new FileInfo(Path.Combine(Shared.Directory.FullName, SYMBOLS));
                return _symbols;
            }
        }
    }
}
