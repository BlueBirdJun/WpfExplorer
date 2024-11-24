using Jamesnet.Wpf.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfExplorerSupport.UI.Units
{
    public class DarkWindow: JamesWindow
    {
        static DarkWindow() { 
          DefaultStyleKeyProperty.OverrideMetadata(typeof(DarkWindow),new FrameworkPropertyMetadata(typeof(DarkWindow)));
        }
    }
}
