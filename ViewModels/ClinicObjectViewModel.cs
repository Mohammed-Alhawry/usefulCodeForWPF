using ExperimentalThingsUsingWPF.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace ExperimentalThingsUsingWPF.ViewModels;

public class ClinicObjectViewModel : ValidationViewModelBase, IEditableObject
{
    private ClinicModel _model;
    private ClinicModel _previousClinic;

    public ClinicObjectViewModel(ClinicModel clinic)
    {
        if (clinic is not null)
        {
            _model = clinic;
        }
    }

    public int Id => _model.Id;
    public ObservableCollection<ClinicContactModel> Contacts => _model.Contacts;
    public ObservableCollection<RequestModel> Requests => _model.Requests;
    
    public string Name
    {
        get { return _model.Name; }
        set
        {
            _model.Name = value;
            OnPropertyChanged();
            if (string.IsNullOrWhiteSpace(value))
            {
                AddError(Translations.Translations.ErrorNameRequired);
            }
            else
            {
                ClearErrors();
            }
        }
    }

    public string Address
    {
        get { return _model.Address; }
        set
        {
            _model.Address = value;
            OnPropertyChanged();
            if (string.IsNullOrWhiteSpace(value))
            {
                AddError(Translations.Translations.ErrorAddressRequired);
            }

            else
            {
                ClearErrors();
            }
        }
    }

    public void BeginEdit()
    {
        _previousClinic = new ClinicModel();
        _previousClinic.Id = Id;
        _previousClinic.Name = Name;
        _previousClinic.Address = Address;
    }

    public void CancelEdit()
    {
        Name = _previousClinic.Name;
        Address = _previousClinic.Address;
    }

    public void EndEdit()
    {
        _previousClinic = null;
    }

}
