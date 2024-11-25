using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfExplorerSupport.Local.Models
{
    public class LocationChangedEventArgs : EventArgs
    {
        public FileInfoBase Current { get; }

        public LocationChangedEventArgs(FileInfoBase current)
        {
            Current = current;
        }
    }
}
