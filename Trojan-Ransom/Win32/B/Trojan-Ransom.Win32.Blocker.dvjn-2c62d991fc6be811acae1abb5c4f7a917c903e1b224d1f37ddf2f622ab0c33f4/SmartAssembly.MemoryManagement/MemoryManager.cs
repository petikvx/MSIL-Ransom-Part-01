using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ns3;

namespace SmartAssembly.MemoryManagement;

public sealed class MemoryManager
{
	private static MemoryManager memoryManager_0;

	private long long_0;

	[DllImport("kernel32")]
	private static extern int SetProcessWorkingSetSize(IntPtr process, int minimumWorkingSetSize, int maximumWorkingSetSize);

	private void method_0()
	{
		Process currentProcess = default(Process);
		try
		{
			try
			{
				currentProcess = Process.GetCurrentProcess();
				try
				{
					SetProcessWorkingSetSize(currentProcess.Handle, -1, -1);
				}
				finally
				{
					((IDisposable)currentProcess)?.Dispose();
				}
			}
			catch
			{
			}
		}
		catch (Exception exception_)
		{
			Class38.smethod_2(exception_, currentProcess, this);
			throw;
		}
	}

	private void method_1(object sender, EventArgs e)
	{
		DateTime now = default(DateTime);
		long ticks = default(long);
		try
		{
			try
			{
				now = DateTime.Now;
				ticks = now.Ticks;
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
		catch (Exception exception_)
		{
			Class38.smethod_5(exception_, ticks, now, this, sender, e);
			throw;
		}
	}

	private MemoryManager()
	{
		DateTime now = DateTime.Now;
		long_0 = now.Ticks;
		base._002Ector();
		try
		{
			Application.add_Idle((EventHandler)method_1);
			method_0();
		}
		catch (Exception exception_)
		{
			Class38.smethod_2(exception_, now, this);
			throw;
		}
	}

	public static void smethod_0()
	{
		try
		{
			try
			{
				if (Environment.OSVersion.Platform == PlatformID.Win32NT)
				{
					memoryManager_0 = new MemoryManager();
				}
			}
			catch
			{
			}
		}
		catch (Exception exception_)
		{
			Class38.smethod_0(exception_);
			throw;
		}
	}
}
