using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfExplorerSupport.UI.Units
{
    public class MinimizeButton :Button
    {
        static MinimizeButton() {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MinimizeButton),
                    new FrameworkPropertyMetadata(typeof(MinimizeButton)));
        }
    }
}
