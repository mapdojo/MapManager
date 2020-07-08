using System.Linq;
using MapManager.Apis;
using Serilog;
using Serilog.Events;
using Xunit;
using Xunit.Abstractions;

namespace MapManager.Tests.Apis.Ogr
{
    public class DriverTest
    {
        private ILogger Log { get; }
        public DriverTest(ITestOutputHelper output)
        {
            Log = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.TestOutput(output, LogEventLevel.Debug,
                    "{Timestamp:yyyy-MM-dd HH:mm:ss} [{Level}] [{SourceContext}] {Message}{NewLine}{Exception}")
                .Enrich.FromLogContext()
                .CreateLogger()
                .ForContext<DriverTest>();
            Logger.Init(Log);
        }
        
        [Fact]
        public void DriverNames()
        {
            var driverNames = MapManager.Apis.Ogr.Driver.DriverNames.ToArray();
            Log.Debug("DriverNameCount: {DriveNameCount}", driverNames.Length);
            string[] expectedDriverNames = new string[]
            {
                "PCIDSK",
                "PDS4",
                "JP2OpenJPEG",
                "PDF",
                "MBTiles",
                "EEDA",
                "DB2ODBC",
                "ESRI Shapefile",
                "MapInfo File",
                "UK .NTF",
                "OGR_SDTS",
                "S57",
                "DGN",
                "OGR_VRT",
                "REC",
                "Memory",
                "BNA",
                "CSV",
                "NAS",
                "GML",
                "GPX",
                "LIBKML",
                "KML",
                "GeoJSON",
                "GeoJSONSeq",
                "ESRIJSON",
                "TopoJSON",
                "Interlis 1",
                "Interlis 2",
                "OGR_GMT",
                "GPKG",
                "SQLite",
                "ODBC",
                "WAsP",
                "PGeo",
                "MSSQLSpatial",
                "PostgreSQL",
                "MySQL",
                "OpenFileGDB",
                "XPlane",
                "DXF",
                "CAD",
                "Geoconcept",
                "GeoRSS",
                "GPSTrackMaker",
                "VFK",
                "PGDUMP",
                "OSM",
                "GPSBabel",
                "SUA",
                "OpenAir",
                "OGR_PDS",
                "WFS",
                "WFS3",
                "HTF",
                "AeronavFAA",
                "Geomedia",
                "EDIGEO",
                "GFT",
                "SVG",
                "CouchDB",
                "Cloudant",
                "Idrisi",
                "ARCGEN",
                "SEGUKOOA",
                "SEGY",
                "ODS",
                "XLSX",
                "ElasticSearch",
                "Walk",
                "Carto",
                "SXF",
                "Selafin",
                "JML",
                "PLSCENES",
                "CSW",
                "VDV",
                "GMLAS",
                "MVT",
                "TIGER",
                "AVCBin",
                "AVCE00",
                "NGW",
                "HTTP"
            };
            Assert.Equal(expectedDriverNames, driverNames);
        }
    }
}
