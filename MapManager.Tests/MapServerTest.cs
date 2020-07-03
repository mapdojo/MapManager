using MapManager.Apis;
using System;
using Xunit;

namespace MapManager.Tests
{
    public class MapServerTest
    {
        [Fact]
        public void Version()
        {
            var mapServer = new MapServer();
            Assert.StartsWith("MapServer version 7.4.3", mapServer.Version);
        }
    }
}
