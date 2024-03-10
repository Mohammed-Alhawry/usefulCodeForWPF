// Ignore Spelling: Navbar

using ExperimentalThingsUsingWPF.Windows;
using System.Windows;
using System.Windows.Controls;

namespace ExperimentalThingsUsingWPF.Views
{
    /// <summary>
    /// Interaction logic for NavbarView.xaml
    /// </summary>
    public partial class NavbarView : UserControl
    {
        public Window MainWindow { get; } = Application.Current.MainWindow;
        public NavbarView()
        {
            InitializeComponent();
        }


        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }


        private void MinimizedButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.WindowState = WindowState.Minimized;
        }

        private void MaximizedButton_Click(object sender, RoutedEventArgs e)
        {
            if (MainWindow.WindowState == WindowState.Maximized)
                MainWindow.WindowState = WindowState.Normal;
            else
            {
                MainWindow.WindowState = WindowState.Maximized;   
            }
        }
    }
}
