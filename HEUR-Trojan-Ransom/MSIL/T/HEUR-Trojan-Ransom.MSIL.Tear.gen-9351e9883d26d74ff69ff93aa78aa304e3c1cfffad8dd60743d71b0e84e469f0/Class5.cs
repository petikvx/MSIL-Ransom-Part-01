using System.IO;
using System.Management;

internal class Class5
{
	public static string smethod_0()
	{
		return smethod_2();
	}

	public static string smethod_1(string string_0)
	{
		return smethod_3(string_0);
	}

	private static string smethod_2()
	{
		return smethod_3("");
	}

	private static string smethod_3(string string_0)
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (string_0 == "")
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			foreach (DriveInfo driveInfo in drives)
			{
				if (driveInfo.IsReady)
				{
					string_0 = driveInfo.RootDirectory.ToString();
					break;
				}
			}
		}
		if (string_0.EndsWith(":\\"))
		{
			string_0 = string_0.Substring(0, string_0.Length - 2);
		}
		ManagementObject val = new ManagementObject("win32_logicaldisk.deviceid=\"" + string_0 + ":\"");
		val.Get();
		string result = ((ManagementBaseObject)val).get_Item("VolumeSerialNumber").ToString();
		val.Dispose();
		return result;
	}

	public Class5()
	{
		Class9.T7DkdFQzGSTU8();
		base._002Ector();
	}
}
