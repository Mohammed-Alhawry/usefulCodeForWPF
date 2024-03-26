using ExperimentalThingsUsingWPF.HelperClasses;
using ExperimentalThingsUsingWPF.Models;
using ExperimentalThingsUsingWPF.Windows;
using System.Collections.ObjectModel;
using System.Windows;

namespace ExperimentalThingsUsingWPF.ViewModels;

public class EditUserViewModel : ViewModelBase
{
    public UserObjectViewModel UserObject { get; set; }
    public DelegateCommand SaveUserCommand { get; set; }
    public DelegateCommand CancelEditingCommand { get; set; }


    public EditUserViewModel(UserObjectViewModel user)
    {

        user?.BeginEdit();
        UserObject = user;

        SaveUserCommand = new DelegateCommand(SaveUser);
        CancelEditingCommand = new DelegateCommand(CancelEditing);
    }

    private void CancelEditing(object obj)
    {
        var senderWindow = obj as Window;
        UserObject.CancelEdit();
        senderWindow.Close();
    }

    private void SaveUser(object parameter)
    {
        var editUserWindow = parameter as EditUserWindow;
        var isUserNameEmpty = string.IsNullOrWhiteSpace(UserObject.UserName);
        var isPasswordEmpty = string.IsNullOrWhiteSpace(UserObject.Password);
        var isValidPassword = UserObject.Password is not null && UserObject.Password.Length >= 8;

        if (isUserNameEmpty)
        {
            UserObject.UserName = " ";
            UserObject.UserName = "";
        }

        if (!isValidPassword)
        {
            var temp = UserObject.Password;
            UserObject.Password = " ";
            UserObject.Password = temp;
        }

        if (!isPasswordEmpty && !isUserNameEmpty && isValidPassword)
        {
            editUserWindow.Close();
        }
    }
}
