using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperimentalThingsUsingWPF.ViewModels;
public class MainWindowViewModel : ViewModelBase
{

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
