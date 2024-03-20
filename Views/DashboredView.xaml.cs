// Ignore Spelling: Dashbored

using System.Windows;
using System.Windows.Controls;

namespace ExperimentalThingsUsingWPF.Views
{
    /// <summary>
    /// Interaction logic for DashboredView.xaml
    /// </summary>
    public partial class DashboredView : UserControl
    {
        public MainWindow MainWindow { get; } = (MainWindow)Application.Current.MainWindow;
        public DashboredView()
        {
            InitializeComponent();   
        }

        private void Materials_OnSelected(object sender, RoutedEventArgs e)
        {
            MainWindow.contentControl.Content = new MaterialsView();
        }
    }
}
