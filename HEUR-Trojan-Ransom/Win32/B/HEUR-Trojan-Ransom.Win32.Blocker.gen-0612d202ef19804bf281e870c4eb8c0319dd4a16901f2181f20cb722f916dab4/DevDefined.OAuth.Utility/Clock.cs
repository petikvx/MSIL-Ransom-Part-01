using System;
using DevDefined.OAuth.Framework;

namespace DevDefined.OAuth.Utility;

public static class Clock
{
	private static Func<DateTime> _nowFunc;

	public static string EpochString => Now.Epoch().ToString();

	public static DateTime Now => _nowFunc();

	static Clock()
	{
		_nowFunc = () => DateTime.Now;
	}

	public static IDisposable FreezeAt(DateTime time)
	{
		return ReplaceImplementation(() => time);
	}

	public static IDisposable Freeze()
	{
		DateTime now = Now;
		return ReplaceImplementation(() => now);
	}

	public static void Reset()
	{
		_nowFunc = () => DateTime.Now;
	}

	public static IDisposable ReplaceImplementation(Func<DateTime> nowFunc)
	{
		Func<DateTime> originalFunc = _nowFunc;
		_nowFunc = nowFunc;
		return new DisposableAction(delegate
		{
			_nowFunc = originalFunc;
		});
	}
}
