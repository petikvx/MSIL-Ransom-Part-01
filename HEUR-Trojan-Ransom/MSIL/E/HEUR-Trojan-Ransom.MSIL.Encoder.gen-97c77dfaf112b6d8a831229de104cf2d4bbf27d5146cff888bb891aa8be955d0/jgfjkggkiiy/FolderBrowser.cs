using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace jgfjkggkiiy;

internal class FolderBrowser : ide
{
	public List<string> GetStartingFolders()
	{
		int num = 0;
		do
		{
			if (num == 0)
			{
				num = 1;
			}
		}
		while (num != 1);
		List<string> list = (from drive in DriveInfo.GetDrives()
			select drive.Name).ToList();
		list.AddRange(Reloadget_Help_003CInitialize_003Eb__13_0());
		return list;
	}

	private List<string> Reloadget_Help_003CInitialize_003Eb__13_0()
	{
		int num = 0;
		do
		{
			if (num == 0)
			{
				num = 1;
			}
		}
		while (num != 1);
		return new List<string>
		{
			Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory),
			Environment.GetFolderPath(Environment.SpecialFolder.Personal),
			Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
			Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
			Environment.GetFolderPath(Environment.SpecialFolder.MyMusic),
			Environment.GetFolderPath(Environment.SpecialFolder.MyVideos)
		};
	}
}
