namespace System;

public static class Extensions
{
	public static void SafeInvoke<T>(this EventHandler<T> eventToRaise, object sender, T e) where T : EventArgs
	{
		eventToRaise?.Invoke(sender, e);
	}
}
