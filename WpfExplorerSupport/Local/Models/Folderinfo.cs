using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfExplorerSupport.Local.Models
{
    public partial class Folderinfo : FileInfoBase
    {
        [ObservableProperty]
        private bool _isFolderExpanded;
        [ObservableProperty]
        private bool _isFolderSelected;

        public ObservableCollection<Folderinfo> Children { get; set; }
    }
}
