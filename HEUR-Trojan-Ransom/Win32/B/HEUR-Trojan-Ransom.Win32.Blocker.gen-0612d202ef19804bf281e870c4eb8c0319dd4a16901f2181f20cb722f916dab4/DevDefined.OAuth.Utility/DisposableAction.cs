using System;

namespace DevDefined.OAuth.Utility;

public class DisposableAction : IDisposable
{
	private readonly Action _action;

	public DisposableAction(Action action)
	{
		_action = action;
	}

	public void Dispose()
	{
		if (_action != null)
		{
			_action();
		}
	}
}
