using ExperimentalThingsUsingWPF.HelperClasses;
using ExperimentalThingsUsingWPF.Models;
using ExperimentalThingsUsingWPF.Windows;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperimentalThingsUsingWPF.ViewModels;

public class AddUserViewModel : ViewModelBase
{
    public UserObjectViewModel UserObject { get; set; }
    public DelegateCommand SaveUserCommand { get; set; }
    public ObservableCollection<UserType> UserTypes { get; set; }
    public AddUserViewModel()
    {
        UserObject = new UserObjectViewModel(new UserModel());
        SaveUserCommand = new DelegateCommand(SaveUser);
        UserTypes = new ObservableCollection<UserType>(Enum.GetValues<UserType>());
    }

    private void SaveUser(object parameter)
    {
        var addUserWindow = parameter as AddUserWindow;
        var isUserNameEmpty = string.IsNullOrWhiteSpace(UserObject.UserName);
        var isPasswordEmpty = string.IsNullOrWhiteSpace(UserObject.Password);
        var isValidPassword = UserObject.Password is not null && UserObject.Password?.Length >= 8;


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
            addUserWindow.Close();
        }
    }
}
