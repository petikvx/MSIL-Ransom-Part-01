using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Input;

namespace LivePortfolio;

public class SVCCommand : ICommand
{
	private Action _action;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private EventHandler CanExecuteChangedEvent;

	public event EventHandler CanExecuteChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = CanExecuteChangedEvent;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref CanExecuteChangedEvent, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = CanExecuteChangedEvent;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref CanExecuteChangedEvent, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public SVCCommand(Action action)
	{
		_action = action;
	}

	public bool CanExecute(object parameter)
	{
		return true;
	}

	public void Execute(object parameter)
	{
		_action();
	}
}
