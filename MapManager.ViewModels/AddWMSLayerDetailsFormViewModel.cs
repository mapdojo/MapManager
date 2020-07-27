using System.Reactive;
using System.Xml;
using MapManager.Apis;
using MapManager.Apis.Wms;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Serilog;

namespace MapManager.ViewModels
{
    public class AddWMSLayerDetailsFormViewModel : ReactiveObject
    {
        public AddWMSLayerDetailsFormViewModel(XmlDocument doc, string url, string version)
        {
            Ok = ReactiveCommand.Create(() => Log.Debug("Ok"));

            LayerDetails = new LayerDetails(doc, url, version);
        }

        private static ILogger Log => Logger.Log.ForContext(typeof(AddWMSLayerDetailsFormViewModel));

        public ReactiveCommand<Unit, Unit> Ok { get; }

        [Reactive] public LayerDetails LayerDetails { get; set; }
    }
}