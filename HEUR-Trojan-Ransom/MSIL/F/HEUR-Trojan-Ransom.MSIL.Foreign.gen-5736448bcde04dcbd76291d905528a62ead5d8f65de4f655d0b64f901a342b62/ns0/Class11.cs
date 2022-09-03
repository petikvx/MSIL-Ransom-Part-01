using System;
using System.Runtime.InteropServices;

namespace ns0;

internal class Class11
{
	public struct Struct0
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		public int int_4;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		public string string_0;

		public short short_0;

		public short short_1;

		public short short_2;

		public byte byte_0;

		public byte byte_1;
	}

	public static string smethod_0()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		string text = "";
		if (oSVersion.Platform.ToString() == "Win32NT")
		{
			switch (smethod_1(oSVersion.Version))
			{
			case "4.1.2222":
				text = "Windows 98";
				break;
			case "4.1.2600":
				text = "Windows 98SE";
				break;
			case "4.9.3000":
				text = "Windows ME";
				break;
			case "5.0.2195":
				text = "Windows 2000";
				break;
			case "5.1.2600":
			case "5.2.3790":
				text = "Windows XP";
				break;
			case "6.0.6000":
			case "6.0.6001":
			case "6.0.6002":
			case "6.0.6003":
				text = "Windows Vista";
				break;
			case "6.1.7600":
			case "6.1.7601":
			case "6.1.7602":
			case "6.1.7603":
				text = "Windows 7";
				break;
			default:
				text = "Unknown";
				break;
			}
		}
		Struct0 struct0_ = default(Struct0);
		struct0_.int_0 = Marshal.SizeOf(typeof(Struct0));
		if (GetVersionEx(ref struct0_))
		{
			if (struct0_.string_0.ToString().Contains("Service Pack 1"))
			{
				text += " SP1";
			}
			if (struct0_.string_0.ToString().Contains("Service Pack 2"))
			{
				text += " SP2";
			}
			if (struct0_.string_0.ToString().Contains("Service Pack 3"))
			{
				text += " SP3";
			}
			if (struct0_.string_0.ToString().Contains("Service Pack 4"))
			{
				text += " SP4";
			}
			if (struct0_.string_0.ToString().Contains("Service Pack 5"))
			{
				text += " SP5";
			}
			if (struct0_.string_0.ToString().Contains("Service Pack 6"))
			{
				text += " SP6";
			}
			if (struct0_.string_0.ToString().Contains("Service Pack 7"))
			{
				text += " SP7";
			}
			if (struct0_.string_0.ToString().Contains("Service Pack 8"))
			{
				text += " SP8";
			}
			if (struct0_.string_0.ToString().Contains("Service Pack 9"))
			{
				text += " SP9";
			}
			text = ((!smethod_2()) ? (text + " - x86") : (text + " - x64"));
		}
		return text;
	}

	private static string smethod_1(Version version_0)
	{
		return version_0.Major + "." + version_0.Minor + "." + version_0.Build;
	}

	[DllImport("kernel32.dll")]
	private static extern bool GetVersionEx(ref Struct0 struct0_0);

	public static bool smethod_2()
	{
		try
		{
			if (!string.IsNullOrEmpty(Environment.GetEnvironmentVariable("ProgramW6432")))
			{
				return true;
			}
			return false;
		}
		catch
		{
			return false;
		}
	}
}
