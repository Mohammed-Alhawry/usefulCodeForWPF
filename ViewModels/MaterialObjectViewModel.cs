using ExperimentalThingsUsingWPF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperimentalThingsUsingWPF.ViewModels;

public class MaterialObjectViewModel : ValidationViewModelBase
{
    private readonly MaterialModel _model;


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
}
