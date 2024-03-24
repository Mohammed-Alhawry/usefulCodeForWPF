using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExperimentalThingsUsingWPF.ViewModels;

public class ValidationViewModelBase : ViewModelBase, INotifyDataErrorInfo
{
    private readonly Dictionary<string, List<string>> _errorsByPropertyName = new();
    public bool HasErrors => _errorsByPropertyName.Any();

    public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

    public IEnumerable GetErrors(string propertyName)
    {
        if (propertyName is not null && _errorsByPropertyName.ContainsKey(propertyName))
            return _errorsByPropertyName[propertyName];

        return Enumerable.Empty<string>();
    }

    protected virtual void OnErrorsChanged(DataErrorsChangedEventArgs e)
    {
        ErrorsChanged?.Invoke(this, e);
    }

    protected void AddError(string errorMessage, [CallerMemberName] string propertyName = null)
    {
        if (propertyName is null) return;

        if (!_errorsByPropertyName.ContainsKey(propertyName))
            _errorsByPropertyName[propertyName] = new List<string>();

        if (!_errorsByPropertyName[propertyName].Contains(errorMessage))
        {
            _errorsByPropertyName[propertyName].Add(errorMessage);
            OnErrorsChanged(new DataErrorsChangedEventArgs(propertyName));
            OnPropertyChanged(nameof(HasErrors));
        }
    }

    protected void ClearErrors([CallerMemberName] string propertyName = null)
    {
        if (propertyName is null) return;

        if (_errorsByPropertyName.ContainsKey(propertyName))
        {
            _errorsByPropertyName.Remove(propertyName);
            OnErrorsChanged(new DataErrorsChangedEventArgs(propertyName));
            OnPropertyChanged(nameof(HasErrors));
        }
    }

}
