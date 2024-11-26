using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace WpfExplorer.Main.UI.Units
{
    public class PolygonSelectorItem : ListBoxItem
    {
        static PolygonSelectorItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PolygonSelectorItem),
                new FrameworkPropertyMetadata(typeof(PolygonSelectorItem)));
        }
    }
}
