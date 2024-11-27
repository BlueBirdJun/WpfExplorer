using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace WpfExplorerSupport.UI.Units
{
    public class CloseButton : Button
    {
        static CloseButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CloseButton),
                new FrameworkPropertyMetadata(typeof(CloseButton)));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("aaa");
        }
    }
}
