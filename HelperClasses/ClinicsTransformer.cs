using ExperimentalThingsUsingWPF.Models;
using ExperimentalThingsUsingWPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperimentalThingsUsingWPF.HelperClasses;

public static class ClinicsTransformer
{
    public static ObservableCollection<ClinicObjectViewModel> TransformToViewModels(IEnumerable<ClinicModel> clinics)
    {
        var collection = new ObservableCollection<ClinicObjectViewModel>();

        foreach (var clinicModel in clinics)
            collection.Add(new ClinicObjectViewModel(clinicModel));

        return collection;
    }
}
