using CommunityToolkit.Mvvm.Input;
using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfExplorerSupport.Local.Helpers;

namespace WpfExplorerSupport.Local.ViewModel
{
    public partial class DarkWindowViewModel : ObservableBase, IViewLoadable
    {
        public void OnLoaded(IViewable view)
        {
            MessageBox.Show("Dark");
        }
        [RelayCommand]
        private void CloseBtn()
        {
            MessageBox.Show("Close");
        }
    }
}
