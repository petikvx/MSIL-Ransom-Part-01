using System;
using System.Diagnostics;
using System.Management;
using Microsoft.Win32;

namespace YullySpoofer;

internal class Helper
{
	public static bool AntivirusInstalled()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		string text = "\\\\" + Environment.MachineName + "\\root\\SecurityCenter";
		try
		{
			return new ManagementObjectSearcher(text, "SELECT * FROM AntivirusProduct").Get().get_Count() > 0;
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			return false;
		}
	}

	public static string CheckForIssues()
	{
		if (GetSecureBoot() == 1)
		{
			return "Secure boot is enabled please disable in bios.";
		}
		if (AntivirusInstalled())
		{
			return "Please uninstall / disable anti-virus.";
		}
		if (Process.GetProcessesByName("EasyAntiCheat").Length == 1)
		{
			return "Please close easy anti cheat before spoofing.";
		}
		if (Process.GetProcessesByName("BEService").Length == 1)
		{
			return "Please close battle eye before spoofing.";
		}
		string text = Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", "ReleaseId", "")!.ToString();
		bool flag = false;
		string[] array = new string[6] { "1803", "1809", "1909", "2004", "20H1", "20H2" };
		for (int i = 0; i < array.Length; i++)
		{
			if (text == array[i])
			{
				flag = true;
			}
		}
		if (!flag)
		{
			return "Your windows version is not supported fully for spoofing.";
		}
		return "";
	}

	public static int GetSecureBoot()
	{
		int num = 0;
		string keyName = "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\SecureBoot\\State";
		string valueName = "UEFISecureBootEnabled";
		try
		{
			object value = Registry.GetValue(keyName, valueName, num);
			if (value != null)
			{
				num = (int)value;
			}
		}
		catch
		{
		}
		return num;
	}
}
