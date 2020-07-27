using MapManager.Apis.Map;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Splat;
using System.Reactive;
using ILogger = Serilog.ILogger;

namespace MapManager.ViewModels
{
    public class AddWMSLayerFormViewModel : ReactiveObject
    {
        public AddWMSLayerFormViewModel(MapObjectHolder target)
        {
            this.Log().Debug("AddWMSLayerFormViewModel");

            Load = ReactiveCommand.Create(() => Log.Debug("Load")); // TODO: Handle Loading in ViewModel
        }

        public ReactiveCommand<Unit, Unit> Load { get; }

        [Reactive] public string ServerUrl { get; set; }

        private static ILogger Log => Apis.Logger.Log.ForContext(typeof(AddWMSLayerFormViewModel));
    }
}