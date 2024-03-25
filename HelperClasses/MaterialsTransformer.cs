using ExperimentalThingsUsingWPF.Models;
using ExperimentalThingsUsingWPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperimentalThingsUsingWPF.HelperClasses;

public static class MaterialsTransformer
{
    public static ObservableCollection<MaterialObjectViewModel> TransformToViewModels(IEnumerable<MaterialModel> materials)
    {
        var collection = new ObservableCollection<MaterialObjectViewModel>();

        foreach (var materialModel in materials)
            collection.Add(new MaterialObjectViewModel(materialModel));

        return collection; 
    }
}
