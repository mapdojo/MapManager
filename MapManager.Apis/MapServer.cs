using OSGeo.MapServer;
using System;

namespace MapManager.Apis
{
    public class MapServer
    {
        public string Version { get; } = mapscript.msGetVersion();

    }
}
