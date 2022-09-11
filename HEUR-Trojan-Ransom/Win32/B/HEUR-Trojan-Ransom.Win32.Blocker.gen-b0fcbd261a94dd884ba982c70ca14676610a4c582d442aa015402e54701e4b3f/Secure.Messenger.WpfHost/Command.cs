using System;
using System.Windows.Input;

namespace Secure.Messenger.WpfHost;

public class Command : ICommand
{
	public delegate void CommandOnExecute(object parameter);

	public delegate bool CommandOnCanExecute(object parameter);

	private CommandOnExecute _execute;

	private CommandOnCanExecute _canExecute;

	public event EventHandler CanExecuteChanged
	{
		add
		{
			Command.smethod_0(value);
		}
		remove
		{
			Command.smethod_1(value);
		}
	}

	public Command(CommandOnExecute onExecuteMethod, CommandOnCanExecute onCanExecuteMethod)
	{
		_execute = onExecuteMethod;
		_canExecute = onCanExecuteMethod;
	}

	public bool CanExecute(object parameter)
	{
		return _canExecute(parameter);
	}

	public void Execute(object parameter)
	{
		_execute(parameter);
	}

	static void smethod_0(EventHandler eventHandler_0)
	{
		CommandManager.add_RequerySuggested(eventHandler_0);
	}

	static void smethod_1(EventHandler eventHandler_0)
	{
		CommandManager.remove_RequerySuggested(eventHandler_0);
	}
}
