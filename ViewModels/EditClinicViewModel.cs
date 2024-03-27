using ExperimentalThingsUsingWPF.HelperClasses;
using System.Windows;

namespace ExperimentalThingsUsingWPF.ViewModels;

public class EditClinicViewModel : ViewModelBase
{
    public ClinicObjectViewModel ClinicObject { get; set; }
    public DelegateCommand SaveClinicCommand { get; set; }
    public DelegateCommand CancelEditingCommand { get; set; }

    public EditClinicViewModel(ClinicObjectViewModel clinic)
    {
        clinic?.BeginEdit();
        ClinicObject = clinic;

        SaveClinicCommand = new DelegateCommand(SaveClinic);
        CancelEditingCommand = new DelegateCommand(CancelEditing);
    }

    private void CancelEditing(object obj)
    {
        var senderWindow = obj as Window;
        ClinicObject.CancelEdit();
        senderWindow.Close();
    }

    private void SaveClinic(object parameter)
    {
        var senderWindow = parameter as Window;
        var isNameEmpty = string.IsNullOrWhiteSpace(ClinicObject.Name);
        var isAddressEmpty = string.IsNullOrWhiteSpace(ClinicObject.Address);
        if (isNameEmpty)
        {
            ClinicObject.Name = " ";
            ClinicObject.Name = "";
        }

        if (isAddressEmpty)
        {
            ClinicObject.Address = " ";
            ClinicObject.Address = "";
        }

        if (isAddressEmpty || isNameEmpty)
            return;

        ClinicObject.EndEdit();
        senderWindow.Close();
    }
}
