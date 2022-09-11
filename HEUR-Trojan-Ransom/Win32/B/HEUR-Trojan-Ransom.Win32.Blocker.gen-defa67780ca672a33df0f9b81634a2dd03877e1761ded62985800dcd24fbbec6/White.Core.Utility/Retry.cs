using System;
using System.Threading;
using White.Core.UIItems.WindowItems;

namespace White.Core.Utility;

public static class Retry
{
	public static TimeSpan WindowWaitDefault = TimeSpan.FromSeconds(30.0);

	public static TimeSpan ElementWaitDefault = TimeSpan.FromSeconds(10.0);

	private static readonly TimeSpan DefaultRetryInterval = TimeSpan.FromMilliseconds(200.0);

	public static Window ForDefault(Func<Window> getMethod)
	{
		return For(getMethod, WindowWaitDefault);
	}

	public static T ForDefault<T>(Func<T> getMethod)
	{
		return For(getMethod, ElementWaitDefault);
	}

	public static Window ForDefault(Func<Window> getMethod, Predicate<Window> shouldRetry)
	{
		return For(getMethod, shouldRetry, WindowWaitDefault);
	}

	public static T ForDefault<T>(Func<T> getMethod, Predicate<T> shouldRetry)
	{
		return For(getMethod, shouldRetry, ElementWaitDefault);
	}

	public static void For(Action action, TimeSpan retryFor)
	{
		DateTime now = DateTime.Now;
		while (DateTime.Now.Subtract(now).TotalMilliseconds < retryFor.TotalMilliseconds)
		{
			try
			{
				action();
				return;
			}
			catch (Exception)
			{
				Thread.Sleep(DefaultRetryInterval);
			}
		}
		action();
	}

	public static bool For(Func<bool> getMethod, TimeSpan retryFor, TimeSpan? retryInterval = null)
	{
		return For(getMethod, (bool g) => !g, retryFor, retryInterval);
	}

	public static T For<T>(Func<T> getMethod, TimeSpan retryFor, TimeSpan? retryInterval = null)
	{
		return For(getMethod, IsValueTypeAndDefault, retryFor, retryInterval);
	}

	public static T For<T>(Func<T> getMethod, Predicate<T> shouldRetry, TimeSpan retryFor, TimeSpan? retryInterval = null)
	{
		DateTime now = DateTime.Now;
		T val;
		while (true)
		{
			if (DateTime.Now.Subtract(now).TotalMilliseconds < retryFor.TotalMilliseconds)
			{
				try
				{
					val = getMethod();
				}
				catch (Exception)
				{
					Thread.Sleep(retryInterval ?? DefaultRetryInterval);
					continue;
				}
				if (typeof(T).IsValueType || val == null || shouldRetry(val))
				{
					if (!(typeof(T) == typeof(bool)) || shouldRetry(val))
					{
						if (typeof(T) != typeof(bool) && !IsReferenceTypeAndIsNull(val) && !shouldRetry(val))
						{
							break;
						}
						Thread.Sleep(retryInterval ?? DefaultRetryInterval);
						continue;
					}
					return val;
				}
				return val;
			}
			return getMethod();
		}
		return val;
	}

	private static bool IsReferenceTypeAndIsNull<T>(T element)
	{
		if (!typeof(T).IsValueType)
		{
			return object.ReferenceEquals(element, null);
		}
		return false;
	}

	private static bool IsValueTypeAndDefault<T>(T element)
	{
		if (typeof(T).IsValueType)
		{
			return element.Equals(default(T));
		}
		return false;
	}
}
