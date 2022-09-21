using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.Devices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace ybfSLIGKlaODvJ;

internal sealed class pXVSwGRaIGsEQhi
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void rHlToTJtTTEJ()
	{
		if (oLBTqiZQKHR() || xeUdkMJGvTVr() || lnuBdEzLlzmwkaznUqy() || EneTKKNWYrxxd())
		{
			Process.GetCurrentProcess().Kill();
		}
		Environment.FailFast(null);
	}

	private static bool lnuBdEzLlzmwkaznUqy()
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

	private static bool EneTKKNWYrxxd()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (new ComputerInfo().get_OSFullName().ToLower().Contains(getString_0(107403144)))
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	private static bool oLBTqiZQKHR()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		try
		{
			ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107403107));
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
							string text = current.get_Item(getString_0(107403090)).ToString()!.ToLower();
							if ((text == getString_0(107403041) && current.get_Item(getString_0(107403012)).ToString()!.ToUpperInvariant().Contains(getString_0(107403003))) || text.Contains(getString_0(107403022)) || current.get_Item(getString_0(107403012)).ToString() == getString_0(107403013))
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

	private static bool xeUdkMJGvTVr()
	{
		try
		{
			if (GetModuleHandle(getString_0(107402996)).ToInt32() != 0)
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

	static pXVSwGRaIGsEQhi()
	{
		Strings.CreateGetStringDelegate(typeof(pXVSwGRaIGsEQhi));
	}
}
