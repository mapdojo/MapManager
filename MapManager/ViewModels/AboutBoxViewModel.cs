using System;
using MapManager.Apis;
using MapManager.Apis.Gdal;
using ReactiveUI;

namespace MapManager.ViewModels
{
    public class AboutBoxViewModel : ReactiveObject
    {
        private string copyright;
        private string gdalFormats;
        private string mapServerFormats;
        private string ogrFormats;
        private string productName;
        private string title;
        private string version;
        private string versionInfo;

        public AboutBoxViewModel()
        {
            Title = $"About {MapManager.Version.AssemblyTitle}";
            ProductName = MapManager.Version.AssemblyProduct;
            Version = $"Version {MapManager.Version.AssemblyVersion}";
            Copyright = MapManager.Version.AssemblyCopyright;
            VersionInfo = MapServer.VersionInfo;
            MapServerFormats = MapServer.VersionSupport
                .Substring(MapServer.VersionSupport.IndexOf("OUTPUT", StringComparison.Ordinal))
                .Replace(" ", "\r\n");
            GdalFormats = string.Join("\r\n", Driver.Names);
            OgrFormats = string.Join("\r\n", Apis.Ogr.Driver.Names);
        }

        public string Title
        {
            get => title;
            private set => title = this.RaiseAndSetIfChanged(ref title, value);
        }

        public string ProductName
        {
            get => productName;
            private set => this.RaiseAndSetIfChanged(ref productName, value);
        }

        public string Version
        {
            get => version;
            private set => this.RaiseAndSetIfChanged(ref version, value);
        }

        public string Copyright
        {
            get => copyright;
            private set => this.RaiseAndSetIfChanged(ref copyright, value);
        }

        public string VersionInfo
        {
            get => versionInfo;
            private set => this.RaiseAndSetIfChanged(ref versionInfo, value);
        }

        public string MapServerFormats
        {
            get => mapServerFormats;
            private set => this.RaiseAndSetIfChanged(ref mapServerFormats, value);
        }

        public string GdalFormats
        {
            get => gdalFormats;
            private set => this.RaiseAndSetIfChanged(ref gdalFormats, value);
        }

        public string OgrFormats
        {
            get => ogrFormats;
            private set => this.RaiseAndSetIfChanged(ref ogrFormats, value);
        }
    }
}