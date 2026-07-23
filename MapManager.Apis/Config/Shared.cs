using Serilog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MapManager.Apis.Config
{
    public class Shared
    {
        private static ILogger Log => Logger.Log.ForContext(typeof(Shared));
        private static DirectoryInfo _directory;

        private static DirectoryInfo GetDirectory()
        {
            var outputDirectory = new DirectoryInfo(AppContext.BaseDirectory.TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar));
            var sharedDirectory = new DirectoryInfo(Path.Combine(outputDirectory.Parent.Parent.FullName, "Shared"));
            return sharedDirectory;
        }

        public static DirectoryInfo Directory
        {
            get
            {
                if (_directory != null && _directory.Exists)
                    return _directory;
                _directory = GetDirectory();
                return _directory;
            }
        }
    }
}
