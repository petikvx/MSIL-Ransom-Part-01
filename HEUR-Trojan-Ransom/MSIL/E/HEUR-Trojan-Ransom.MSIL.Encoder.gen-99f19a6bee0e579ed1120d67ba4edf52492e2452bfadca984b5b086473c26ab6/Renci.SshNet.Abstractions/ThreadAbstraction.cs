using System;
using System.Threading;

namespace Renci.SshNet.Abstractions;

internal static class ThreadAbstraction
{
	public static void Sleep(int millisecondsTimeout)
	{
		Thread.Sleep(millisecondsTimeout);
	}

	public static void ExecuteThreadLongRunning(Action action)
	{
		new Thread((ThreadStart)delegate
		{
			action();
		}).Start();
	}

	public static void ExecuteThread(Action action)
	{
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		ThreadPool.QueueUserWorkItem(delegate
		{
			action();
		});
	}
}
