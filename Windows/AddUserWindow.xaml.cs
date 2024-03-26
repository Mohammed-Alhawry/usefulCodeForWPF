using ExperimentalThingsUsingWPF.ViewModels;
using System.Windows;

namespace ExperimentalThingsUsingWPF.Windows;

/// <summary>
/// Interaction logic for AddUserWindow.xaml
/// </summary>
public partial class AddUserWindow : Window
{
    public AddUserWindow(AddUserViewModel addUserViewModel)
    {
        InitializeComponent();
        DataContext = addUserViewModel;
    }
}
