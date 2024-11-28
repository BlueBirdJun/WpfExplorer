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

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            Border border = GetTemplateChild("PART_Bar") as Border;
            border.MouseMove += Border_MouseMove;
            border.MouseLeftButtonDown += Border_MouseLeftButtonDown;
        }

        private void Border_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                if(this.WindowState == WindowState.Normal)
                    this.WindowState = WindowState.Maximized; 
                else
                    this.WindowState = WindowState.Normal;

            }
        }

        private void Border_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (e.LeftButton == System.Windows.Input.MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }
    }
}
