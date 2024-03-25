﻿using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ExperimentalThingsUsingWPF.ViewModels;

public class ViewModelBase : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;

    public void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected virtual async Task OnLoaded()
    {
        await Task.CompletedTask;
    }

}
