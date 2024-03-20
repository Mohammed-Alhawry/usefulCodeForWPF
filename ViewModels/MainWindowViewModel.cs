using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExperimentalThingsUsingWPF.ViewModels;

public class MainWindowViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;

    public void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    private bool _isLeftDrawerOpen;

    public bool IsLeftDrawerOpen
    {
        get { return _isLeftDrawerOpen; }
        set
        {
            _isLeftDrawerOpen = value;
            OnPropertyChanged();
        }
    }
}
