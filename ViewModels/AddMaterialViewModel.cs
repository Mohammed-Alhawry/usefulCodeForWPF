using ExperimentalThingsUsingWPF.HelperClasses;
using ExperimentalThingsUsingWPF.Models;
using ExperimentalThingsUsingWPF.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperimentalThingsUsingWPF.ViewModels;

public class AddMaterialViewModel : ViewModelBase
{
    public MaterialObjectViewModel MaterialObject { get; set; }
    public DelegateCommand SaveMaterialCommand { get; set; }
    public AddMaterialViewModel()
    {
        MaterialObject = new MaterialObjectViewModel(new MaterialModel());
        SaveMaterialCommand = new DelegateCommand(SaveMaterial);
    }

    private void SaveMaterial(object parameter)
    {
        var addMaterialWindow = parameter as AddMaterialWindow;
        var isShortNameEmpty = string.IsNullOrWhiteSpace(MaterialObject.ShortName);
        var isFullNameEmpty = string.IsNullOrWhiteSpace(MaterialObject.FullName);
        if (isShortNameEmpty)
        {
            MaterialObject.ShortName = " ";
            MaterialObject.ShortName = "";
        }

        if (isFullNameEmpty)
        {
            MaterialObject.FullName = " ";
            MaterialObject.FullName = "";
        }

        if (!isFullNameEmpty && !isShortNameEmpty)
        {
            addMaterialWindow.Close();
        }
    }
}
