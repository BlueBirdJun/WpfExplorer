using CommunityToolkit.Mvvm.Input;
using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Mvvm;
using Prism.Ioc;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace WpfExplorer.Forms.Local.ViewModels
{
    public partial class ExplorerViewModel : ObservableBase, IViewLoadable
    {
        private readonly IContainerProvider _containerProvider;
        private readonly IRegionManager _regionManager;
        private  IViewable _view;

        //public List<FolderInfo> Roots { get; init; }

        public ExplorerViewModel(IContainerProvider containerProvider,
            IRegionManager regionManager)
        {
            _containerProvider = containerProvider;
            _regionManager = regionManager;
            
        }

        public void OnLoaded(IViewable view)
        {
            _view = view;
            IRegion mainRegion = _regionManager.Regions["MainRegion"];
            IViewable mainContent = _containerProvider.Resolve<IViewable>("MainContent");

            if (!mainRegion.Views.Contains(mainContent))
            {
                mainRegion.Add(mainContent);
            }
            mainRegion.Activate(mainContent);
            //MessageBox.Show("Show");
        }

        [RelayCommand]
        private void Btn(string parameter)
        {
            Window window = Window.GetWindow(_view.View);            
            switch(parameter) {
                case "Mini":
                    window.WindowState = WindowState.Minimized;
                    break;
                case "Max":
                    if(window.WindowState != WindowState.Maximized)
                        window.WindowState = WindowState.Maximized;
                    else
                        window.WindowState = WindowState.Normal;
                    break;
                case "Close":
                    if(MessageBox.Show("닫을래", "Explorer", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        window.Close();
                    }

                    break;
            }

        }
    }
}
