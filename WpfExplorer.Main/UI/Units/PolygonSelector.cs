using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace WpfExplorer.Main.UI.Units
{
    public class PolygonSelector : ListBox
    {
        static PolygonSelector()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PolygonSelector),
                new FrameworkPropertyMetadata(typeof(PolygonSelector)));
        }

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new PolygonSelectorItem();
        }
    }
}
