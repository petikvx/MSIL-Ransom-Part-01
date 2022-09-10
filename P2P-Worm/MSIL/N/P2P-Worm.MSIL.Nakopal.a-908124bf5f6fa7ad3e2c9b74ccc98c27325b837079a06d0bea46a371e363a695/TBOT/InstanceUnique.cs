using System;
using System.Threading;

namespace TBOT;

internal class InstanceUnique : IDisposable
{
	private readonly Mutex mMutex;

	private bool _mMutexOwned;

	public InstanceUnique(string name)
	{
		mMutex = new Mutex(initiallyOwned: false, name);
		_mMutexOwned = false;
	}

	public void Dispose()
	{
		if (_mMutexOwned)
		{
			mMutex.ReleaseMutex();
		}
	}

	public bool IsRunning()
	{
		_mMutexOwned = mMutex.WaitOne(0, exitContext: true);
		return !_mMutexOwned;
	}
}
