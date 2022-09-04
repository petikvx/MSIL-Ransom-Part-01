using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SmartAssembly.MemoryManagement;

public sealed class MemoryManager1
{
	private static MemoryManager1 memoryManager1_0;

	private long long_0 = DateTime.Now.Ticks;

	private MemoryManager1()
	{
		Application.add_Idle((EventHandler)method_1);
		method_0();
	}

	[DllImport("kernel32")]
	private static extern int SetProcessWorkingSetSize(IntPtr CO_process, int CO_minimumWorkingSetSize, int CO_maximumWorkingSetSize);

	private void method_0()
	{
		try
		{
			Process currentProcess = Process.GetCurrentProcess();
			try
			{
				do
				{
					if (0 == 0 && 0 == 0)
					{
						SetProcessWorkingSetSize(currentProcess.Handle, -1, -1);
					}
				}
				while (4 == 0);
			}
			finally
			{
				if (5 == 0 || currentProcess != null)
				{
					((IDisposable)currentProcess).Dispose();
				}
			}
		}
		catch
		{
		}
	}

	private void method_1(object sender, EventArgs e)
	{
		try
		{
			if (false)
			{
				goto IL_0018;
			}
			DateTime now = DateTime.Now;
			DateTime dateTime = default(DateTime);
			if (0 == 0)
			{
				dateTime = now;
			}
			long num = dateTime.Ticks;
			goto IL_001f;
			IL_0018:
			long num2;
			num = num2;
			long num3;
			if (uint.MaxValue != 0)
			{
				num3 = long_0;
				if (false)
				{
					goto IL_0034;
				}
				num -= num3;
			}
			if (8 == 0)
			{
				goto IL_001f;
			}
			num3 = 10000000L;
			goto IL_0034;
			IL_0034:
			if (num > num3)
			{
				long_0 = num2;
				method_0();
			}
			return;
			IL_001f:
			num2 = num;
			goto IL_0018;
		}
		catch
		{
		}
	}

	public static void smethod_0()
	{
		try
		{
			if (Environment.OSVersion.Platform == PlatformID.Win32NT)
			{
				memoryManager1_0 = new MemoryManager1();
			}
		}
		catch
		{
		}
	}
}
