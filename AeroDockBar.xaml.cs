using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace template
{
    public partial class AeroDockBar : UserControl
    {
        public AeroDockBar()
        {
            InitializeComponent();
        }

        private void MinimizeWindow(object sender, RoutedEventArgs e)
        {
            Window parentWindow = Window.GetWindow(this);
            if (parentWindow != null)
            {
                parentWindow.WindowState = WindowState.Minimized;
            }
        }

        private void MaximizeWindow(object sender, RoutedEventArgs e)
        {
            Window parentWindow = Window.GetWindow(this);
            if (parentWindow != null)
            {
                parentWindow.WindowState = parentWindow.WindowState == WindowState.Maximized ? WindowState.Normal : WindowState.Maximized;
            }
        }

        private void CloseWindow(object sender, RoutedEventArgs e)
        {
            Window parentWindow = Window.GetWindow(this);
            if (parentWindow != null)
            {
                parentWindow.Close();
            }
        }
        private void DragWindow(object sender, MouseButtonEventArgs e)
        {
            // Get the parent window that contains the dockbar
            Window parentWindow = Window.GetWindow(this);
            if (e.ButtonState == MouseButtonState.Pressed && parentWindow != null)
            {
                parentWindow.DragMove();
            }
        }
    }
}
