using ExperimentalThingsUsingWPF.HelperClasses;
using ExperimentalThingsUsingWPF.Models;
using ExperimentalThingsUsingWPF.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperimentalThingsUsingWPF.ViewModels;

public class AddClinicViewModel : ViewModelBase
{
    public ClinicObjectViewModel ClinicObject { get; set; }
    public DelegateCommand SaveClinicCommand { get; set; }
    public AddClinicViewModel()
    {
        ClinicObject = new ClinicObjectViewModel(new ClinicModel());
        SaveClinicCommand = new DelegateCommand(SaveClinic);
    }

    private void SaveClinic(object parameter)
    {
        var addClinicWindow = parameter as AddClinicWindow;
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

        addClinicWindow.Close();

    }
}
