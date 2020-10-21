using Serilog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MapManager.Apis.Config
{
    public class SharedAnnotationMap
    {
        private static ILogger Log => Logger.Log.ForContext(typeof(SharedAnnotationMap));

        private const string ANNOTATION_MAP = "Annotation.map";
        private static FileInfo _annotationMap;

        public static FileInfo File
        {
            get
            {
                if (_annotationMap != null && _annotationMap.Exists)
                    return _annotationMap;
                _annotationMap = new FileInfo(Path.Combine(Shared.Directory.FullName, ANNOTATION_MAP));
                return _annotationMap;
            }
        }
    }
}
