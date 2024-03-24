using System.Windows.Input;

namespace ExperimentalThingsUsingWPF.HelperClasses;

public class DelegateCommandAsync : ICommand
{
    private bool _isExecuting;
    private readonly Func<object, Task> _executeAsync;
    private readonly Func<object, bool> _canExecute;
    private readonly Action<Exception> _onException;

    public event EventHandler CanExecuteChanged;

    public DelegateCommandAsync(Func<object, Task> executeAsync, Func<object, bool> canExecute = null, Action<Exception> onException = null)
    {
        ArgumentNullException.ThrowIfNull(executeAsync);
        _executeAsync = executeAsync;
        _canExecute = canExecute;
        _onException = onException;
    }

    private bool IsExecuting
    {
        get { return _isExecuting; }
        set
        {
            _isExecuting = value;
            RaiseCanExecuteChanged();
        }
    }


    public void RaiseCanExecuteChanged()
    {
        CanExecuteChanged?.Invoke(this, EventArgs.Empty);
    }

    public bool CanExecute(object parameter)
    {
        return !_isExecuting && (_canExecute is null || _canExecute(parameter));
    }

    public async void Execute(object parameter)
    {
        await ExecuteAsync(parameter);
    }

    protected async Task ExecuteAsync(object parameter)
    {
        IsExecuting = true;
        try
        {
            await _executeAsync(parameter);
        }
        catch (Exception ex)
        {
            _onException?.Invoke(ex);
        }
        finally
        {
            IsExecuting = false;
        }
    }
}
