using System;

namespace DevDefined.OAuth.Framework;

public class DisposableAction : IDisposable
{
	private readonly Action _action;

	public DisposableAction(Action action)
	{
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		_action = action;
	}

	public void Dispose()
	{
		_action();
	}
}
