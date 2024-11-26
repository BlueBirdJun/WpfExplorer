using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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
        private readonly NavigatorService _navigatorService;

        public List<Folderinfo> Roots { get; init; }
        public ObservableCollection<Folderinfo> Files { get; init; }
        public ObservableCollection<LocationInfo> Locations { get; init; }

        public MainContentViewModel(FileService fileService, NavigatorService navigatorService)
        {
            _fileService = fileService;
            _navigatorService = navigatorService;
            _navigatorService.LocationChanged += _navigatorService_LocationChanged;

            Roots = _fileService.GenerateRootNodes();
            Files = new();
            Locations = new();
        }

        private void _navigatorService_LocationChanged(object? sender, LocationChangedEventArgs e)
        {
            _fileService.TryRefreshFiles(Files, out bool isDenied);
            _fileService.RefreshLocations(Locations);
        }
        //private void FolderChanged(Folderinfo folderInfo)
        //{
        //    MessageBox.Show($"Selected: {folderInfo.Name}");
        //}
        private List<Folderinfo> GetDirectoryItems(string fullPath)
        {
            List<Folderinfo> items = new();

            string[] dirs = Directory.GetDirectories(fullPath);
            foreach (string path in dirs)
            {
                items.Add(new Folderinfo { FullPath = path });
            }

            string[] files = Directory.GetFiles(fullPath);
            foreach (string path in files)
            {
                items.Add(new Folderinfo { FullPath = path });
            }
            return items;
        }
        [RelayCommand]
        private void FolderChanged(Folderinfo folderInfo)
        {
            //MessageBox.Show($"Selected: {folderInfo.Name}");
            _fileService.RefreshSubdirectories(folderInfo);
            _navigatorService.ChangeLocation(folderInfo);
        }
 

        [RelayCommand]
        private void GoBack()
        {
            _navigatorService.GoBack();
        }

        [RelayCommand]
        private void GoForward()
        {
            _navigatorService.GoForward();
        }

        [RelayCommand]
        private void GoToParent()
        {
            _navigatorService.GoToParent();
        }


    }
}
