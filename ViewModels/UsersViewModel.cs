using ExperimentalThingsUsingWPF.Data;
using ExperimentalThingsUsingWPF.HelperClasses;
using ExperimentalThingsUsingWPF.Models;
using ExperimentalThingsUsingWPF.Windows;
using System.Collections.ObjectModel;
using System.Windows;

namespace ExperimentalThingsUsingWPF.ViewModels;

public class UsersViewModel : ViewModelBase
{
    public UserObjectViewModel SelectedUser { get; set; }
    public ObservableCollection<UserObjectViewModel> Users { get; set; }
    

    public DelegateCommand EditUserCommand { get; set; }
    public DelegateCommand OpenAddUserWindowCommand { get; set; }
    public DelegateCommand OpenDeleteConfirmationDialogCommand { get; set; }


    public UsersViewModel()
    {
        OpenAddUserWindowCommand = new DelegateCommand(OpenAddUserWindow);
        EditUserCommand = new DelegateCommand(OpenEditUserWindow);
        OpenDeleteConfirmationDialogCommand = new DelegateCommand(OpenDeleteConfirmationDialog);
    }

    private void OpenDeleteConfirmationDialog(object obj)
    {
        if (SelectedUser is not null)
        {
            var messageBoxText = Translations.Translations.DeleteConfirmationMessage;
            var caption = Translations.Translations.DialogCaption;
            var messageBoxButton = MessageBoxButton.YesNo;
            var messageBoxIcon = MessageBoxImage.Warning;
            var yesOrNo = MessageBox.Show(messageBoxText, caption, messageBoxButton, messageBoxIcon);
            if (yesOrNo == MessageBoxResult.Yes)
                Users.Remove(SelectedUser);

        }
    }

    private void OpenAddUserWindow(object obj)
    {
        var addUserWindow = new AddUserWindow(new AddUserViewModel());
        addUserWindow.ShowDialog();
    }

    private void OpenEditUserWindow(object obj)
    {
        var editWindow = new EditUserWindow(new EditUserViewModel(SelectedUser));

        editWindow.ShowDialog();
    }

    public override async Task OnLoadedAsync()
    {

        await Task.Run(() => Users = UsersTransformer.TransformToViewModels(DataProvider.GetUsers()));
        OnPropertyChanged(nameof(Users));
    }
}
