using ExperimentalThingsUsingWPF.Data;
using ExperimentalThingsUsingWPF.HelperClasses;
using ExperimentalThingsUsingWPF.Windows;
using System.Collections.ObjectModel;

namespace ExperimentalThingsUsingWPF.ViewModels;

public class MaterialsViewModel : ViewModelBase
{
    public ObservableCollection<MaterialObjectViewModel> Materials { get; set; }
    public MaterialObjectViewModel SelectedMaterial { get; set; }
    
    public DelegateCommand EditMaterialCommand { get; set; }
    public DelegateCommand OpenAddMaterialWindowCommand { get; set; }
    

    public MaterialsViewModel()
    {
        OpenAddMaterialWindowCommand = new DelegateCommand(OpenAddMaterialWindow);
        EditMaterialCommand = new DelegateCommand(OpenEditMaterialWindow);
    
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
