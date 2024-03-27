using ExperimentalThingsUsingWPF.Models;
using System.ComponentModel;

namespace ExperimentalThingsUsingWPF.ViewModels;

public class MaterialObjectViewModel : ValidationViewModelBase, IEditableObject
{
    private  MaterialModel _model;
    private MaterialModel _previousMaterial;

    public int Id => _model.Id; 
    
    public string FullName
    {
        get { return _model.FullName; }
        set
        {
            _model.FullName = value;
            OnPropertyChanged();
            if (string.IsNullOrWhiteSpace(value))
            {
                AddError(Translations.Translations.ErrorFullNameRequired);
            }
            else
            {
                ClearErrors();
            }
        }
    }

    public string ShortName
    {
        get { return _model.ShortName; }
        set
        {
            _model.ShortName = value;
            OnPropertyChanged();
            if (string.IsNullOrWhiteSpace(value))
            {
                AddError(Translations.Translations.ErrorShortNameRequired);
            }
            else
            {
                ClearErrors();
            }
        }
    }

    public MaterialObjectViewModel(MaterialModel material)
    {
        if (material is not null)
        {
            _model = material;
        }

    }

    public void BeginEdit()
    {
        _previousMaterial = new MaterialModel();
        
        _previousMaterial.ShortName = ShortName;
        _previousMaterial.FullName = FullName;
    }

    public void CancelEdit()
    {
        
        ShortName = _previousMaterial.ShortName;
        FullName = _previousMaterial.FullName;

    }

    public void EndEdit()
    {
        _previousMaterial = null;
    }
}
