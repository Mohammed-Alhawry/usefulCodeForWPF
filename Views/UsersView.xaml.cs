using ExperimentalThingsUsingWPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ExperimentalThingsUsingWPF.Views;

/// <summary>
/// Interaction logic for UsersView.xaml
/// </summary>
public partial class UsersView : UserControl
{
    private readonly UsersViewModel _usersViewModel;
    public UsersView(UsersViewModel usersViewModel)
    {
        InitializeComponent();
        _usersViewModel = usersViewModel;
        DataContext = _usersViewModel;
        Loaded += UsersView_OnLoadedAsync;
    }

    private async void UsersView_OnLoadedAsync(object sender, RoutedEventArgs e)
    {
        await _usersViewModel.OnLoadedAsync();
    }

    private void SearchButton_Click(object sender, RoutedEventArgs e)
    {
        usersGrid.ItemsSource = _usersViewModel.Users.Where(material => material.UserName.Contains(searchTextBox.Text)
                                                            || material.DisplayName.Contains(searchTextBox.Text));
    }
}
