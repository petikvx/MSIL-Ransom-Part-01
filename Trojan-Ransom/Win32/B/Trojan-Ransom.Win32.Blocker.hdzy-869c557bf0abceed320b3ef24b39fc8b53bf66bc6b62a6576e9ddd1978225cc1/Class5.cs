using System;
using System.Threading;

internal sealed class Class5 : IDisposable
{
	private bool bool_0;

	private readonly Mutex mutex_0;

	public Class5(string string_0)
	{
		mutex_0 = new Mutex(initiallyOwned: false, string_0);
		bool_0 = false;
	}

	public void Dispose()
	{
		if (bool_0)
		{
			mutex_0.ReleaseMutex();
		}
	}

	public bool method_0()
	{
		bool_0 = mutex_0.WaitOne(0, exitContext: true);
		return !bool_0;
	}
}
