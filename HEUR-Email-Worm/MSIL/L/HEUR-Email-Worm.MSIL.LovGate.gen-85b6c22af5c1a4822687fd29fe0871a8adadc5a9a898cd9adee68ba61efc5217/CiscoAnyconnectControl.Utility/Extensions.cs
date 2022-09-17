using System;
using System.Threading;
using System.Threading.Tasks;

namespace CiscoAnyconnectControl.Utility;

public static class Extensions
{
	public static Task<TResult> TimeoutAfter<TResult>(this Task<TResult> task, TimeSpan timeout)
	{
		CancellationTokenSource cancellationTokenSource = Extensions.smethod_0();
		try
		{
			throw Extensions.smethod_1("The operation has timed out.");
		}
		finally
		{
			if (cancellationTokenSource != null)
			{
				Extensions.smethod_2((IDisposable)cancellationTokenSource);
			}
		}
	}

	public static Task TimeoutAfter(this Task task, TimeSpan timeout)
	{
		CancellationTokenSource cancellationTokenSource = Extensions.smethod_0();
		try
		{
			return null;
		}
		finally
		{
			if (cancellationTokenSource != null)
			{
				Extensions.smethod_2((IDisposable)cancellationTokenSource);
			}
		}
	}

	static CancellationTokenSource smethod_0()
	{
		return new CancellationTokenSource();
	}

	static TimeoutException smethod_1(string string_0)
	{
		return new TimeoutException(string_0);
	}

	static void smethod_2(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}
}
