using Jamesnet.Wpf.Global.Location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfExplorer.Forms.Local.ViewModels;
using WpfExplorer.Forms.UI.Views;
using WpfExplorer.Main.Local.ViewModels;
using WpfExplorer.Main.UI.Views;
using WpfExplorerSupport.Local.ViewModel;
using WpfExplorerSupport.UI.Units;

namespace WpfExplorer.Properties
{
    internal class WireDataContext : ViewModelLocationScenario
    {
        protected override void Match(ViewModelLocatorCollection items)
        {

            items.Register<DarkWindow, DarkWindowViewModel>();
            items.Register<MainContent, MainContentViewModel>();
            items.Register<ExplorerWindow, ExplorerViewModel>();
        }
    }
}
