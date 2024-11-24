using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Jamesnet.Wpf.Controls;
using WpfExplorer.Forms.UI.Views;
using WpfExplorerSupport.UI.Units;

namespace WpfExplorer
{
    internal class App: JamesApplication
    {
        protected override Window CreateShell()
        {
            // Temporary Window instance
            return new ExplorerWindow();
        }
    }
}
