using MapManager.Apis;
using ReactiveUI;
using Serilog;

namespace MapLibrary.ViewModels
{   
    public class AddFontFormViewModel : ReactiveObject
    {
        private static ILogger Log => Logger.Log.ForContext(typeof(AddFontFormViewModel));

        public AddFontFormViewModel()
        {
            Log.Debug("AddFontFormViewModel");
        }
    }
}
