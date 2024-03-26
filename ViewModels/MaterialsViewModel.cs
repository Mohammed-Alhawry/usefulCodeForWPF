using ControlzEx.Standard;
using ExperimentalThingsUsingWPF.Data;
using ExperimentalThingsUsingWPF.HelperClasses;
using ExperimentalThingsUsingWPF.Windows;
using System.Collections.ObjectModel;
using System.Windows;


namespace ExperimentalThingsUsingWPF.ViewModels;

public class MaterialsViewModel : ViewModelBase
{
    public ObservableCollection<MaterialObjectViewModel> Materials { get; set; }
    public MaterialObjectViewModel SelectedMaterial { get; set; }

    public DelegateCommand EditMaterialCommand { get; set; }
    public DelegateCommand OpenAddMaterialWindowCommand { get; set; }
    public DelegateCommand OpenDeleteConfirmationDialogCommand { get; set; }


    public MaterialsViewModel()
    {
        OpenAddMaterialWindowCommand = new DelegateCommand(OpenAddMaterialWindow);
        EditMaterialCommand = new DelegateCommand(OpenEditMaterialWindow);
        OpenDeleteConfirmationDialogCommand = new DelegateCommand(OpenDeleteConfirmationDialog);
    }

    private void OpenDeleteConfirmationDialog(object obj)
    {
        if (SelectedMaterial is not null)
        {
            var messageBoxText = Translations.Translations.DeleteConfirmationMessage;
            var caption = Translations.Translations.DialogCaption;
            var messageBoxButton = MessageBoxButton.YesNo;
            var messageBoxIcon = MessageBoxImage.Warning;
            var yesOrNo = MessageBox.Show(messageBoxText, caption, messageBoxButton, messageBoxIcon);
            if (yesOrNo == MessageBoxResult.Yes) 
                Materials.Remove(SelectedMaterial);

        }
    }

    private void OpenAddMaterialWindow(object obj)
    {
        var addMaterialWindow = new AddMaterialWindow(new AddMaterialViewModel());
        addMaterialWindow.ShowDialog();
    }

    private void OpenEditMaterialWindow(object obj)
    {
        var editWindow = new EditMaterialWindow(new EditMaterialViewModel(SelectedMaterial));

        editWindow.ShowDialog();
    }

    public async Task OnLoadedAsync()
    {
        
        await Task.Run(() => Materials = MaterialsTransformer.TransformToViewModels(DataProvider.GetMaterials()));
        OnPropertyChanged(nameof(Materials));
    }


}
