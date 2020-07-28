using MapManager.ViewModels;
using ReactiveUI;
using System.Windows.Forms;
using System.Xml;

namespace MapLibrary
{
    public class TreeNodeView : TreeNode, IViewFor<TreeNodeViewModel>
    {
        public TreeNodeView(XmlNode xmlNode) : base()
        {
            this.OneWayBind(ViewModel, vm => vm.Title, v => v.Text);
            this.OneWayBind(ViewModel, vm => vm.ImageIndex, v => v.ImageIndex);
            this.OneWayBind(ViewModel, vm => vm.SelectedImageIndex, v => v.SelectedImageIndex);
            this.OneWayBind(ViewModel, vm => vm.XmlNode, v => v.Tag);

            ViewModel = new TreeNodeViewModel(xmlNode);
        }

        public TreeNodeViewModel ViewModel { get; set; }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (TreeNodeViewModel)value;
        }
    }
}
