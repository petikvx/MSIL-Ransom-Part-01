using System.IO;
using System.Management;

namespace FaturaDecryptor;

internal class DiskID
{
	public static string getDiskID()
	{
		return DiskId();
	}

	public static string getDiskID(string diskLetter)
	{
		return DiskId(diskLetter);
	}

	private static string DiskId()
	{
		return DiskId("");
	}

	private static string DiskId(string diskLetter)
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (diskLetter == "")
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			foreach (DriveInfo driveInfo in drives)
			{
				if (driveInfo.IsReady)
				{
					diskLetter = driveInfo.RootDirectory.ToString();
					break;
				}
			}
		}
		if (diskLetter.EndsWith(":\\"))
		{
			diskLetter = diskLetter.Substring(0, diskLetter.Length - 2);
		}
		ManagementObject val = new ManagementObject("win32_logicaldisk.deviceid=\"" + diskLetter + ":\"");
		val.Get();
		string result = ((ManagementBaseObject)val).get_Item("VolumeSerialNumber").ToString();
		val.Dispose();
		return result;
	}
}
