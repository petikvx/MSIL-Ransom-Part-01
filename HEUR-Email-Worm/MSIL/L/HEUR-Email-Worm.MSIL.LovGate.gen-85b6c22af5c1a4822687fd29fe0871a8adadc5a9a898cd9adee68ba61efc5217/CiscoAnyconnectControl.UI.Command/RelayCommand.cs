using System;
using System.Windows.Input;

namespace CiscoAnyconnectControl.UI.Command;

internal class RelayCommand : ICommand
{
	private readonly Action _executeInternal;

	private readonly Func<bool> _canExecuteInternal;

	private static RelayCommand _emptyCommand;

	public static RelayCommand Empty => _emptyCommand ?? (_emptyCommand = new RelayCommand(() => true, delegate
	{
	}));

	public event EventHandler CanExecuteChanged
	{
		add
		{
		}
		remove
		{
		}
	}

	public RelayCommand(Func<bool> canExecute, Action action)
	{
		_executeInternal = action;
		_canExecuteInternal = canExecute;
	}

	public bool CanExecute(object parameter = null)
	{
		return _canExecuteInternal();
	}

	public void Execute(object parameter = null)
	{
		_executeInternal();
	}
}
