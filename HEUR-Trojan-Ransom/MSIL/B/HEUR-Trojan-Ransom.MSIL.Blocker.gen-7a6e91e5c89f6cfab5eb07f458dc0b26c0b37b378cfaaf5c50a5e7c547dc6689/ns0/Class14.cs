using System;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace ns0;

internal class Class14
{
	public static string smethod_0()
	{
		IntPtr intPtr = Marshal.AllocHGlobal(255);
		GetVolumeNameForVolumeMountPoint(Environment.GetEnvironmentVariable(_003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_42()) + _003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_10(), intPtr, 255u);
		string text = Marshal.PtrToStringUni(intPtr);
		text = text.Substring(text.IndexOf('{'));
		text = text.Substring(0, text.IndexOf('}') + 1);
		return text.Trim();
	}

	public static bool smethod_1()
	{
		try
		{
			return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
		}
		catch
		{
			return false;
		}
	}

	public static string smethod_2()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		string text = _003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_43();
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			switch (oSVersion.Version.Minor)
			{
			case 90:
				text = _003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_46();
				break;
			case 10:
				text = _003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_45();
				break;
			case 0:
				text = _003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_44();
				break;
			}
		}
		else if (oSVersion.Platform == PlatformID.Win32NT)
		{
			switch (oSVersion.Version.Major)
			{
			case 3:
				text = _003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.d();
				break;
			case 4:
				text = _003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_47();
				break;
			case 5:
				text = ((oSVersion.Version.Minor != 0) ? _003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_49() : _003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_48());
				break;
			case 6:
				switch (oSVersion.Version.Minor)
				{
				case 0:
					text = _003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.GZ();
					break;
				case 1:
					text = _003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_50();
					break;
				case 2:
					text = _003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_51();
					break;
				}
				break;
			}
		}
		return text + (string.IsNullOrEmpty(Environment.GetEnvironmentVariable(_003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_52())) ? _003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_54() : _003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_53());
	}

	[DllImport("kernel32", CharSet = CharSet.Unicode)]
	private static extern bool GetVolumeNameForVolumeMountPoint(string string_0, IntPtr intptr_0, uint uint_0);
}
