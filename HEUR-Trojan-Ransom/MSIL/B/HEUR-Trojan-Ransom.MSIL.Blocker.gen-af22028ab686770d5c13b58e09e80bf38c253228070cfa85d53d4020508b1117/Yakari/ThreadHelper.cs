using System;
using System.Diagnostics;
using System.Threading;

namespace Yakari;

internal static class ThreadHelper
{
	public static void RunOnDifferentThread(Action action, bool swallowException = false)
	{
		ThreadPool.QueueUserWorkItem(delegate
		{
			try
			{
				action();
			}
			catch (Exception)
			{
				if (!swallowException)
				{
					throw;
				}
			}
		});
	}

	public static void RunOnDifferentThread(Action action, Action<Exception> catchAction)
	{
		ThreadPool.QueueUserWorkItem(delegate
		{
			try
			{
				action();
			}
			catch (Exception obj)
			{
				catchAction(obj);
			}
		});
	}

	public static void WaitFor(TimeSpan timeout)
	{
		Thread.Sleep((int)timeout.TotalMilliseconds);
	}

	public static void WaitFor(int timeout)
	{
		Thread.Sleep(timeout);
	}

	public static void WaitForSeconds(int timeout)
	{
		Thread.Sleep(timeout * Convert.ToInt32(1000.0));
	}

	public static T WaitForResult<T>(Func<T> func, TimeSpan timeout)
	{
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		double totalMilliseconds = timeout.TotalMilliseconds;
		T val;
		do
		{
			val = func();
		}
		while (val == null && !((double)stopwatch.ElapsedMilliseconds >= totalMilliseconds));
		stopwatch.Stop();
		return val;
	}
}
