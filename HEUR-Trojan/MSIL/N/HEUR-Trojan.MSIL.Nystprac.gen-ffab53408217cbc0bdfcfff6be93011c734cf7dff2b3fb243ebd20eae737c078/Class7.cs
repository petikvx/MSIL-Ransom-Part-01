using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

internal class Class7 : IDisposable
{
	public delegate void Delegate1(IntPtr r1, bool r2);

	private bool bool_0;

	private IntPtr intptr_0;

	private Delegate1 delegate1_0;

	[DebuggerNonUserCode]
	public Class7()
	{
		Class14.hYiyYvszsKHjE();
		base._002Ector();
	}

	[SpecialName]
	public bool method_0()
	{
		return bool_0;
	}

	[DllImport("kernel32.dll")]
	private static extern bool CreateTimerQueueTimer(ref IntPtr intptr_1, IntPtr intptr_2, Delegate1 delegate1_1, IntPtr intptr_3, uint uint_0, uint uint_1, uint uint_2);

	[DllImport("kernel32.dll")]
	private static extern bool DeleteTimerQueueTimer(IntPtr intptr_1, IntPtr intptr_2, IntPtr intptr_3);

	public void method_1(uint uint_0, uint uint_1, Delegate1 delegate1_1)
	{
		if (!bool_0)
		{
			delegate1_0 = delegate1_1;
			bool flag;
			if (!(flag = CreateTimerQueueTimer(ref intptr_0, IntPtr.Zero, delegate1_0, IntPtr.Zero, uint_0, uint_1, 0u)))
			{
				method_3("CreateTimerQueueTimer");
			}
			bool_0 = flag;
		}
	}

	public void method_2()
	{
		if (bool_0)
		{
			bool flag;
			if ((!(flag = DeleteTimerQueueTimer(IntPtr.Zero, intptr_0, IntPtr.Zero)) && Marshal.GetLastWin32Error() != 997) || 0 == 0)
			{
			}
			bool_0 = !flag;
		}
	}

	private void method_3(string string_0)
	{
		throw new Exception($"{string_0} failed. Win32Error: {Marshal.GetLastWin32Error()}");
	}

	public void Dispose()
	{
		method_2();
	}
}
