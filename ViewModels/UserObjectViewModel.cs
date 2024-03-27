using ExperimentalThingsUsingWPF.Models;
using System.ComponentModel;

namespace ExperimentalThingsUsingWPF.ViewModels;

public class UserObjectViewModel : ValidationViewModelBase, IEditableObject
{
    private UserModel _model;
    private UserModel _previousUser;

    public UserObjectViewModel(UserModel user)
    {
        if (user is not null)
        {
            _model = user;
        }
    }

    public int Id
    {
        get => _model.Id;
    }
    public UserType UserType
    {
        get => _model.UserType;
        set
        {
            _model.UserType = value;
            OnPropertyChanged();
        }
    }

    public string UserName
    {
        get { return _model.UserName; }
        set
        {
            _model.UserName = value;
            OnPropertyChanged();
            if (string.IsNullOrWhiteSpace(value))
            {
                AddError(Translations.Translations.ErrorUserNameRequired);
            }
            else
            {
                ClearErrors();
            }
        }
    }

    public string DisplayName
    {
        get { return _model.DisplayName; }
        set
        {
            _model.DisplayName = value;
            OnPropertyChanged();
            if (string.IsNullOrWhiteSpace(value))
            {
                _model.DisplayName = UserName;
            }

        }
    }

    public string Password
    {
        get { return _model.Password; }
        set
        {
            _model.Password = value;
            OnPropertyChanged();
            if (string.IsNullOrWhiteSpace(value) || value.Length < 8)
            {
                AddError(Translations.Translations.ErrorPassword);
            }

            else
            {
                ClearErrors();
            }
        }
    }

    public void BeginEdit()
    {
        _previousUser = new UserModel();
        _previousUser.Id = Id;
        _previousUser.UserName = UserName;
        _previousUser.DisplayName = DisplayName;
        _previousUser.Password = Password;
        _previousUser.UserType = UserType;
    }

    public void CancelEdit()
    {
        
        UserName = _previousUser.UserName;
        DisplayName = _previousUser.DisplayName;
        Password = _previousUser.Password;
        UserType = _previousUser.UserType;
    }

    public void EndEdit()
    {
        _previousUser = null;
    }
}
