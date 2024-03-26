using ExperimentalThingsUsingWPF.HelperClasses;
using ExperimentalThingsUsingWPF.Models;
using ExperimentalThingsUsingWPF.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ExperimentalThingsUsingWPF.ViewModels;

public class EditMaterialViewModel : ViewModelBase
{
    public MaterialObjectViewModel MaterialObject { get; set; }
    public DelegateCommand SaveMaterialCommand { get; set; }
    public DelegateCommand CancelEditingCommand { get; set; }
    
    public EditMaterialViewModel(MaterialObjectViewModel material)
    {
        material?.BeginEdit();
        MaterialObject = material;
        
        SaveMaterialCommand = new DelegateCommand(SaveMaterial);
        CancelEditingCommand = new DelegateCommand(CancelEditing);
    }

    private void CancelEditing(object obj)
    {
        var senderWindow = obj as Window;
        MaterialObject.CancelEdit();
        senderWindow.Close();
    }

    private void SaveMaterial(object parameter)
    {
        var senderWindow = parameter as Window;
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
            MaterialObject.EndEdit();
            senderWindow.Close();
        }
    }
}
