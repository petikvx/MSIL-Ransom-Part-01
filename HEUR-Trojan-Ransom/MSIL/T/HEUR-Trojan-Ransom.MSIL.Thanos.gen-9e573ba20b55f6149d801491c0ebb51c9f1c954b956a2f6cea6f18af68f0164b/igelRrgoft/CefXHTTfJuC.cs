using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.Devices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace igelRrgoft;

internal sealed class CefXHTTfJuC
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void wSFnQgprrqwz()
	{
		if (WNhCZPbmLMU() || RdSDpwrBUDB() || TDhcwPtSmxt() || FeXELGCzJLDQO())
		{
			Process.GetCurrentProcess().Kill();
		}
		Environment.FailFast(null);
	}

	private static bool TDhcwPtSmxt()
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

	private static bool FeXELGCzJLDQO()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (new ComputerInfo().get_OSFullName().ToLower().Contains(getString_0(107406680)))
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	private static bool WNhCZPbmLMU()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		try
		{
			ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107406675));
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
							string text = current.get_Item(getString_0(107406658)).ToString()!.ToLower();
							if ((text == getString_0(107406609) && current.get_Item(getString_0(107406580)).ToString()!.ToUpperInvariant().Contains(getString_0(107406603))) || text.Contains(getString_0(107406558)) || current.get_Item(getString_0(107406580)).ToString() == getString_0(107406549))
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

	private static bool RdSDpwrBUDB()
	{
		try
		{
			if (GetModuleHandle(getString_0(107406564)).ToInt32() != 0)
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

	static CefXHTTfJuC()
	{
		Strings.CreateGetStringDelegate(typeof(CefXHTTfJuC));
	}
}
