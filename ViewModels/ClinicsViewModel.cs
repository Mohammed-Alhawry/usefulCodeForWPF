using ExperimentalThingsUsingWPF.Data;
using ExperimentalThingsUsingWPF.HelperClasses;
using ExperimentalThingsUsingWPF.Windows;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ExperimentalThingsUsingWPF.ViewModels;

public class ClinicsViewModel : ViewModelBase
{
    public ClinicObjectViewModel SelectedClinic { get; set; }
    public ObservableCollection<ClinicObjectViewModel> Clinics { get; set; }

    public DelegateCommand EditClinicCommand { get; set; }
    public DelegateCommand OpenAddClinicWindowCommand { get; set; }
    public DelegateCommand OpenDeleteConfirmationDialogCommand { get; set; }

    public ClinicsViewModel()
    {
        OpenAddClinicWindowCommand = new DelegateCommand(OpenAddClinicWindow);
        EditClinicCommand = new DelegateCommand(OpenEditClinicWindow);
        OpenDeleteConfirmationDialogCommand = new DelegateCommand(OpenDeleteConfirmationDialog);
    }

    private void OpenDeleteConfirmationDialog(object obj)
    {
        if (SelectedClinic is not null)
        {
            var messageBoxText = Translations.Translations.DeleteConfirmationMessage;
            var caption = Translations.Translations.DialogCaption;
            var messageBoxButton = MessageBoxButton.YesNo;
            var messageBoxIcon = MessageBoxImage.Warning;
            var yesOrNo = MessageBox.Show(messageBoxText, caption, messageBoxButton, messageBoxIcon);
            if (yesOrNo == MessageBoxResult.Yes)
                Clinics.Remove(SelectedClinic);

        }
    }

    private void OpenAddClinicWindow(object obj)
    {
        var addClinicWindow = new AddClinicWindow(new AddClinicViewModel());
        addClinicWindow.ShowDialog();
    }

    private void OpenEditClinicWindow(object obj)
    {
        var editWindow = new EditClinicWindow(new EditClinicViewModel(SelectedClinic));

        editWindow.ShowDialog();
    }

    public override async Task OnLoadedAsync()
    {
        await Task.Run(() => Clinics = ClinicsTransformer.TransformToViewModels(DataProvider.GetClinics()));
        OnPropertyChanged(nameof(Clinics));
    }
}
