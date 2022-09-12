using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Input;
using ns0;

namespace ns2;

internal sealed class Class1
{
	public delegate IntPtr Delegate0(int int_0, IntPtr intptr_0, IntPtr intptr_1);

	private EventHandler<EventArgs0> eventHandler_0;

	private Delegate0 delegate0_0;

	private IntPtr intptr_0 = IntPtr.Zero;

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr SetWindowsHookEx(int int_0, Delegate0 delegate0_1, IntPtr intptr_1, uint uint_0);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr CallNextHookEx(IntPtr intptr_1, int int_0, IntPtr intptr_2, IntPtr intptr_3);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr GetModuleHandle(string string_0);

	[SpecialName]
	public void method_0(EventHandler<EventArgs0> eventHandler_1)
	{
		EventHandler<EventArgs0> eventHandler = eventHandler_0;
		EventHandler<EventArgs0> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs0> value = (EventHandler<EventArgs0>)Delegate.Combine(eventHandler2, eventHandler_1);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	public Class1()
	{
		delegate0_0 = method_3;
	}

	public void method_1()
	{
		intptr_0 = method_2(delegate0_0);
	}

	private IntPtr method_2(Delegate0 delegate0_1)
	{
		using Process process = Process.GetCurrentProcess();
		using ProcessModule processModule = process.MainModule;
		return SetWindowsHookEx(13, delegate0_1, GetModuleHandle(processModule.ModuleName), 0u);
	}

	private IntPtr method_3(int int_0, IntPtr intptr_1, IntPtr intptr_2)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		if ((int_0 >= 0 && intptr_1 == (IntPtr)256) || intptr_1 == (IntPtr)260)
		{
			int num = Marshal.ReadInt32(intptr_2);
			if (eventHandler_0 != null)
			{
				eventHandler_0(this, new EventArgs0(KeyInterop.KeyFromVirtualKey(num)));
			}
		}
		return CallNextHookEx(intptr_0, int_0, intptr_1, intptr_2);
	}
}
