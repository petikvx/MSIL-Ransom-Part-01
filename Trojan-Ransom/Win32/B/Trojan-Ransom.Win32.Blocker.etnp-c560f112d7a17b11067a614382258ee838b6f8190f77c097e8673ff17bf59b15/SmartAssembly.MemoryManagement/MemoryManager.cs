using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ns0;

namespace SmartAssembly.MemoryManagement;

public sealed class MemoryManager
{
	private static MemoryManager memoryManager_0;

	private long long_0;

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
		catch (Exception cO_)
		{
			Class29.smethod_2(cO_, now, this);
			throw;
		}
	}

	[DllImport("kernel32")]
	private static extern int SetProcessWorkingSetSize(IntPtr CO_process, int CO_minimumWorkingSetSize, int CO_maximumWorkingSetSize);

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
					if (currentProcess != null)
					{
						goto IL_0019;
					}
					goto IL_001f;
					IL_001f:
					if (false)
					{
						goto IL_0019;
					}
					goto end_IL_0016;
					IL_0019:
					((IDisposable)currentProcess).Dispose();
					goto IL_001f;
					end_IL_0016:;
				}
			}
			catch
			{
			}
		}
		catch (Exception cO_)
		{
			Class29.smethod_2(cO_, currentProcess, this);
			throw;
		}
	}

	private void method_1(object sender, EventArgs e)
	{
		DateTime now = default(DateTime);
		long num2 = default(long);
		try
		{
			try
			{
				now = DateTime.Now;
				long num;
				while (true)
				{
					num = now.Ticks;
					if (5u != 0)
					{
						num2 = num;
						if (7 == 0)
						{
							continue;
						}
						num = num2;
						goto IL_0015;
					}
					goto IL_001c;
					IL_001c:
					if (0 == 0)
					{
						break;
					}
					goto IL_0015;
					IL_0015:
					num -= long_0;
					goto IL_001c;
				}
				if (num > 10000000 && 0 == 0)
				{
					long_0 = num2;
					method_0();
				}
			}
			catch
			{
			}
		}
		catch (Exception cO_)
		{
			Class29.smethod_5(cO_, num2, now, this, sender, e);
			throw;
		}
	}

	public static void smethod_0()
	{
		try
		{
			try
			{
				while (true)
				{
					if (8u != 0 && 5u != 0 && Environment.OSVersion.Platform == PlatformID.Win32NT)
					{
						goto IL_0005;
					}
					goto IL_0012;
					IL_0012:
					if (2u != 0)
					{
						break;
					}
					goto IL_0005;
					IL_0005:
					if (false)
					{
						continue;
					}
					memoryManager_0 = new MemoryManager();
					goto IL_0012;
				}
			}
			catch
			{
			}
		}
		catch (Exception cO_)
		{
			Class29.smethod_0(cO_);
			throw;
		}
	}
}
