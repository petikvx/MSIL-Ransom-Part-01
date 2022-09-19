using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

public struct GStruct3
{
	public int int_0;

	[MarshalAs(UnmanagedType.LPWStr)]
	public string string_0;

	[MarshalAs(UnmanagedType.LPWStr)]
	public string string_1;

	public FILETIME filetime_0;

	public FILETIME filetime_1;

	public FILETIME filetime_2;

	public GEnum6 genum6_0;

	public string URL => string_0;

	public string UrlString
	{
		get
		{
			int num = string_0.IndexOf('?');
			if (num >= 0)
			{
				return string_0.Substring(0, num);
			}
			return string_0;
		}
	}

	public string Title
	{
		get
		{
			if (string_0.StartsWith("file:"))
			{
				return GClass20.smethod_0(string_0, GClass20.GEnum4.flag_5).Substring(8).Replace('/', '\\');
			}
			return string_1;
		}
	}

	public DateTime LastVisited => GClass20.smethod_1(filetime_0).ToLocalTime();

	public DateTime LastUpdated => GClass20.smethod_1(filetime_1).ToLocalTime();

	public DateTime Expires
	{
		get
		{
			try
			{
				return GClass20.smethod_1(filetime_2).ToLocalTime();
			}
			catch (Exception)
			{
				return DateTime.Now;
			}
		}
	}

	public override string ToString()
	{
		return string_0;
	}
}
