// Ignore Spelling: Dashbored

using System.Windows;
using System.Windows.Controls;

namespace ExperimentalThingsUsingWPF.Views;

/// <summary>
/// Interaction logic for DashboredView.xaml
/// </summary>
public partial class DashboredView : UserControl
{
    private readonly MainWindow _mainWindow = (MainWindow)Application.Current.MainWindow;
    public DashboredView()
    {
        InitializeComponent();
    }

    private void MaterialsMenuButton_Checked(object sender, RoutedEventArgs e)
    {
        _mainWindow.contentControl.Content = new MaterialsView();
    }

    private void MaterialsMenuButton_UnChecked(object sender, RoutedEventArgs e)
    {
        _mainWindow.contentControl.Content = null;
    }
}
