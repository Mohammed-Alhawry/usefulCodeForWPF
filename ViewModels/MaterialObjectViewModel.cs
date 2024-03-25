using ExperimentalThingsUsingWPF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperimentalThingsUsingWPF.ViewModels;

public class MaterialObjectViewModel : ValidationViewModelBase, IEditableObject
{
    private  MaterialModel _model;
    private MaterialModel _editableMaterial;

    public int Id
    {
        get => _model.Id; private set
        {
            _model.Id = value;
            OnPropertyChanged();
        }
    }
    public string FullName
    {
        get { return _model.FullName; }
        set
        {
            _model.FullName = value;
            OnPropertyChanged();
            if (string.IsNullOrWhiteSpace(value))
            {
                AddError("Full Name is required");
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
                AddError("Short Name is required");
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
        _editableMaterial = new MaterialModel();
        _editableMaterial.Id = Id;
        _editableMaterial.ShortName = ShortName;
        _editableMaterial.FullName = FullName;
    }

    public void CancelEdit()
    {
        Id = _editableMaterial.Id;
        ShortName = _editableMaterial.ShortName;
        FullName = _editableMaterial.FullName;

    }

    public void EndEdit()
    {
        _editableMaterial = null;
    }
}
