using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfExplorerSupport.Local.Helpers;
using WpfExplorerSupport.Local.Models;

namespace WpfExplorer.Main.Local.ViewModels
{
    public partial class MainContentViewModel
    {
        //public ICommand FolderChangedCommand { get; init; }
        private readonly FileService _fileService;
        public List<Folderinfo> Roots { get; init; }

        public MainContentViewModel(FileService fileService)
        {
            _fileService = fileService;

            //FolderChangedCommand = new RelayCommand<Folderinfo>(FolderChanged);
            Roots = fileService.GenerateRootNodes();
        }

        //private void FolderChanged(Folderinfo folderInfo)
        //{
        //    MessageBox.Show($"Selected: {folderInfo.Name}");
        //}

        [RelayCommand]
        private void FolderChanged(Folderinfo folderInfo)
        {
            //MessageBox.Show($"Selected: {folderInfo.Name}");
            _fileService.RefreshSubdirectories(folderInfo);
        }

    }
}
