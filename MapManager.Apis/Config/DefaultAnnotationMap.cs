using Serilog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MapManager.Apis.Config
{
    public class DefaultAnnotationMap
    {
        private static ILogger Log => Logger.Log.ForContext(typeof(DefaultAnnotationMap));

        private const string ANNOTATION_MAP = "Annotation.map";
        private static FileInfo annotationMap;

        public static FileInfo File
        {
            get
            {
                if (annotationMap != null && annotationMap.Exists)
                    return annotationMap;
                annotationMap = new FileInfo(Path.Combine(Default.Directory.FullName, ANNOTATION_MAP));
                if (annotationMap.Exists)
                    return annotationMap;
                throw new FileNotFoundException(annotationMap.FullName);
            }
        }
    }
}
