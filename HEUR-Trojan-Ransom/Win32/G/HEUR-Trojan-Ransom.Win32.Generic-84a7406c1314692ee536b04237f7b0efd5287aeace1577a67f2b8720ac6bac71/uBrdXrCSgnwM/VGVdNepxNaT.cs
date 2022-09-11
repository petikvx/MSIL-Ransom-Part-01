using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.Devices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace uBrdXrCSgnwM;

internal sealed class VGVdNepxNaT
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void aDaBTRMOqkVCEV()
	{
		if (RUnDcBwJcdDKY() || vAQpITwxky() || lAbNbDkDMhf() || ddleqgrojuLPy())
		{
			Process.GetCurrentProcess().Kill();
		}
		Environment.FailFast(null);
	}

	private static bool lAbNbDkDMhf()
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

	private static bool ddleqgrojuLPy()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (new ComputerInfo().get_OSFullName().ToLower().Contains(getString_0(107412179)))
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	private static bool RUnDcBwJcdDKY()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		try
		{
			ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107412142));
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
							string text = current.get_Item(getString_0(107412637)).ToString()!.ToLower();
							if ((text == getString_0(107412588) && current.get_Item(getString_0(107412559)).ToString()!.ToUpperInvariant().Contains(getString_0(107412550))) || text.Contains(getString_0(107412569)) || current.get_Item(getString_0(107412559)).ToString() == getString_0(107412560))
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

	private static bool vAQpITwxky()
	{
		try
		{
			if (GetModuleHandle(getString_0(107412543)).ToInt32() != 0)
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

	static VGVdNepxNaT()
	{
		Strings.CreateGetStringDelegate(typeof(VGVdNepxNaT));
	}
}
