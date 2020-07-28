using System;
using System.Reactive.Linq;
using System.Xml;
using MapManager.Apis.Wms;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace MapManager.ViewModels
{
    public class TreeNodeViewModel : ReactiveObject
    {
        public TreeNodeViewModel(XmlNode xmlNode)
        {
            XmlNode = xmlNode;
            Title = Layer.GetTitle(xmlNode);
            IsQueryable = Layer.IsQueryable(xmlNode);
            ImageIndex = IsQueryable ? 0 : -1;
            SelectedImageIndex = IsQueryable ? 0 : -1;
            LayerNodes = Layer.GetLayerNodes(xmlNode);
        }

        public XmlNode XmlNode { get; set; }
        public string Title { get; set; }
        public bool IsQueryable { get; set; }
        public int ImageIndex { get; set; }
        public int SelectedImageIndex { get; set; }
        public XmlNodeList LayerNodes { get; set; }
    }
}