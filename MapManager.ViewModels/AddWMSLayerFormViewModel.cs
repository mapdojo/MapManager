using MapManager.Apis.Map;
using ReactiveUI;
using Splat;

namespace MapManager.ViewModels
{
    public class AddWMSLayerFormViewModel : ReactiveObject
    {
        public AddWMSLayerFormViewModel(MapObjectHolder target)
        {
            this.Log().Debug("AddWMSLayerFormViewModel");
        }
    }
}