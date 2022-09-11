using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SmartAssembly.MemoryManagement;

public sealed class MemoryManager
{
	internal static MemoryManager memoryManager_0;

	private long long_0 = DateTime.Now.Ticks;

	[DllImport("kernel32")]
	private static extern int SetProcessWorkingSetSize(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2);

	private void method_0()
	{
		try
		{
			using Process process = Process.GetCurrentProcess();
			SetProcessWorkingSetSize(process.Handle, new IntPtr(-1), new IntPtr(-1));
		}
		catch
		{
		}
	}

	private void method_1(object sender, EventArgs e)
	{
		try
		{
			long ticks = DateTime.Now.Ticks;
			if (ticks - long_0 > 10000000L)
			{
				long_0 = ticks;
				method_0();
			}
		}
		catch
		{
		}
	}

	internal MemoryManager()
	{
		Application.add_Idle((EventHandler)method_1);
		method_0();
	}
}
