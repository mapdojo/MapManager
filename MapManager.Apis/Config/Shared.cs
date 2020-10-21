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
            var sharedDirectory
                = new DirectoryInfo(Path.Combine(new DirectoryInfo(Path.GetDirectoryName(typeof(Version).Assembly.Location)).Parent.Parent.FullName, "Shared"));
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
